using OfficeOpenXml;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CleanUpCSVFiles
{
    public delegate void MessageChangedHandler(string value);
    public delegate void ErrorOcurHandler(string message);
    public delegate void WorkFinishedHandler();
    public delegate void WorkStartedHandler();

    public class CleanUpLogic
    {
        public event MessageChangedHandler MessageChanged;
        public event WorkFinishedHandler WorkFinished;
        public event WorkStartedHandler WorkStarted;
        public event ErrorOcurHandler ErrorOcured;

        public FileInfo SettingsFile { get; private set; }
        public DirectoryInfo HoldingFiles { get; private set; }

        public string InfoMessage { get; private set; }

        private void OnWorkStarted()
        {
            (WorkStarted as WorkStartedHandler)?.Invoke();
        }
        private void OnErrorOcured(string message)
        {
            var del = ErrorOcured as ErrorOcurHandler;
            if (del != null)
            {
                InfoMessage = message;
                del(message);
            }
        }

        private void OnWorkFinished()
        {
            (WorkFinished as WorkFinishedHandler)?.Invoke();
        }

        public void RunProcess()
        {
            if (SettingsFile == null || string.IsNullOrEmpty(Properties.Settings.Default.SettingsFile))
            {
                OnErrorOcured("You cannot start without choosen settings file!");
                return;
            }
            if (HoldingFiles == null || string.IsNullOrEmpty(Properties.Settings.Default.HoldingFiles))
            {
                OnErrorOcured("You cannot start without choosen holdings file!");
                return;
            }
            Task.Factory.StartNew(new Action(StartProcessing));
        }

        private void OnMessageChanged(string value)
        {
            var del = MessageChanged as MessageChangedHandler;
            if (del != null)
            {
                InfoMessage = value;
                del(value);
            }
        }

        private void StartProcessing()
        {
            OnWorkStarted();
            OnMessageChanged("Start processing...");
            try
            {
                FileInfo[] Files = HoldingFiles.GetFiles("*.csv");
                using (var pck = new ExcelPackage(SettingsFile))
                {
                    var ws = pck.Workbook.Worksheets[1];
                    for (int i = 0; i < ws.Dimension.Rows; i++)
                    {
                        var cellValue = ws.Cells[$"B{i + 2}"].GetValue<int>();
                        var fileName = ws.Cells[$"A{i + 2}"].Text;

                        FileInfo file = Files.FirstOrDefault(x => x.Name.Contains(fileName) && !string.IsNullOrEmpty(fileName));
                        if (file != null)
                        {
                            var headData = File.ReadAllLines(file.FullName).Take(3);
                            var remainData = File.ReadAllLines(file.FullName).Skip(cellValue + 1);
                            File.WriteAllLines(file.FullName, headData);
                            File.AppendAllLines(file.FullName, remainData);
                        }
                        OnMessageChanged($"Processed: {i + 1}/{ws.Dimension.Rows + 1}");
                    }
                }
            }
            catch (Exception ex)
            {
                OnMessageChanged(ex.Message);
                OnErrorOcured(ex.Message);
            }
            OnMessageChanged("Finished");
            OnWorkFinished();
        }

        public bool CheckIsAppCanStartProcess()
        {
            return Directory.Exists(HoldingFiles?.FullName) &&
            File.Exists(SettingsFile?.FullName);
        }

        public void InitHoldingFilesPath(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) str = FilesHelper.SelectFolder();
            if (string.IsNullOrWhiteSpace(str)) return;
            HoldingFiles = new DirectoryInfo(str);

            Properties.Settings.Default.HoldingFiles = str;
            Properties.Settings.Default.Save();
        }
        public void InitSettingsFilePath(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) str = FilesHelper.SelectFile(); 
            if (string.IsNullOrWhiteSpace(str)) return;
            SettingsFile = new FileInfo(str);

            Properties.Settings.Default.SettingsFile = str;
            Properties.Settings.Default.Save();
        }
    }
}
