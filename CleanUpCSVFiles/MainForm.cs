using System;
using System.Windows.Forms;

namespace CleanUpCSVFiles
{
    public delegate void UpdateProgressDelegate(string value);
    public delegate void WorkStarted();
    public delegate void WorkFinished();
    public partial class MainForm : Form
    {
        CleanUpLogic logic;
        public MainForm()
        {
            InitializeComponent();
            StatusLabelText.Text = "Choose file";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ChoosenSettingsFileLabel.AutoEllipsis = true;

            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            string displayableVersion = $"Clean up CSV files {version.Major}.{version.Minor}";
            Text = displayableVersion;
            logic = new CleanUpLogic();
            ChoosenHoldingsLabel.Text = Properties.Settings.Default.HoldingFiles;
            ChoosenSettingsFileLabel.Text = Properties.Settings.Default.SettingsFile;

            logic.MessageChanged += UpdateLabel;
            logic.WorkFinished += WorkFinished;
            logic.WorkStarted += WorkStarted;
            logic.ErrorOcured += ErrorOcured;
        }

        private void ErrorOcured(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ChooseHoldingsBtn_Click(object sender, EventArgs e)
        {
            logic.InitHoldingFilesPath(null);
            ChoosenHoldingsLabel.Text = Properties.Settings.Default.HoldingFiles;
        }

        private void UpdateLabel(string value)
        {
            if (this.StatusLabelText.InvokeRequired)
            {
                var progrDel = new UpdateProgressDelegate(UpdateLabel);
                this.BeginInvoke(progrDel, value);
            }
            else
            {
                this.StatusLabelText.Text = value;
            }
        }

        private void WorkStarted()
        {
            if (this.InvokeRequired)
            {
                var progrDel = new WorkStarted(WorkStarted);
                this.BeginInvoke(progrDel);
            }
            else
            {
                this.ChooseHoldingsBtn.Enabled = false;
                this.ChooseSettingsBtn.Enabled = false;
                this.ProcessFilesButton.Enabled = false;
            }
        }

        private void WorkFinished()
        {
            if (this.InvokeRequired)
            {
                var progrDel = new WorkFinished(WorkFinished);
                this.BeginInvoke(progrDel);
            }
            else
            {
                this.ChooseHoldingsBtn.Enabled = true;
                this.ChooseSettingsBtn.Enabled = true;
                this.ProcessFilesButton.Enabled = true;
            }
        }

        private void ProcessFilesButton_Click(object sender, EventArgs e)
        {
            logic.RunProcess();
        }

        private void ChooseSettingsBtn_Click(object sender, EventArgs e)
        {
            logic.InitSettingsFilePath(null);
            ChoosenSettingsFileLabel.Text = Properties.Settings.Default.SettingsFile;
        }
    }
}