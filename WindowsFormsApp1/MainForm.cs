using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsFormApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        FileProcessor fileProcessor = new FileProcessor();

        private void FolderSelect_Click(object sender, EventArgs e)
        {
            try
            {
                using (CommonOpenFileDialog dialog = new CommonOpenFileDialog { IsFolderPicker = true, Multiselect = true, })
                {
                    dialog.ShowDialog();
                    string folderPath = dialog.FileName;
                    UpdateFolderSelection(folderPath);
                }
            }
            catch (Exception ex)
            {
                if (ex is InvalidOperationException) { }
                else
                    MessageBox.Show(ex.Message);
            }
        }

        private async void processFiles_button_Click(object sender, EventArgs e)
        {
            processFiles_button.Enabled = false; // disable the button during processing
            progressBar1.Value = 0; // reset the progress bar

            var progress = new Progress<Tuple<int, string>>(value =>
            {
                // Update progress bar on UI thread
                progressBar1.Value = value.Item1;
                currentFile.Text = $"Current file: {value.Item2}";
            });

            await fileProcessor.ProcessFiles(progress);

            MessageBox.Show("Files processed!");
            processFiles_button.Enabled = true; // re-enable the button after processing
        }

        private void selectedFolderTextBoxChanged(object sender, EventArgs e)
        {
            string folderPath = folderTextBox.Text;
            UpdateFolderSelection(folderPath);
        }

        private void UpdateFolderSelection(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                fileProcessor.selectedFolder = folderPath;
                folderTextBox.Text = $"{fileProcessor.selectedFolder}"; //$"Number of files: {fileCount}";
                folderSelectedLabel.Text = $"Folder selected: {fileProcessor.selectedFolder}";
                numOfFiles_label.Text = $"Number of files: ";
                //progressBar1.Maximum = fileProcessor.fileCount;
                processFiles_button.Enabled = true; // enable processing button once folder is selected
            }
            else
            {
                fileProcessor.selectedFolder = "";
                folderSelectedLabel.Text = $"Folder selected: (Select a folder)";
                //numOfFiles_label.Text = $"Number of files: (Select a folder)";
            }
        }
    }
}
