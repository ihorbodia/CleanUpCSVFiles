using System.Windows.Forms;

namespace CleanUpCSVFiles
{
    public class FilesHelper
    {
        public static string SelectFolder()
        {
            string res = string.Empty;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    res = fbd.SelectedPath;
                }
            }
            return res;
        }

        public static string SelectFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            string selectedFileName = string.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFileName = openFileDialog.FileName;
            }
            else
            {
                selectedFileName = string.Empty;
            }
            return selectedFileName;
        }
    }
}
