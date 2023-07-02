using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog { IsFolderPicker = true, Multiselect = true, })
            {
                dialog.ShowDialog();
                var selectedFolders = dialog.FileName;
                string folderPath = Path.GetDirectoryName(selectedFolders);
                // Use folderPath
                fileProcessor.selectedFolder = folderPath;
                folderTextBox.Text = $"{fileProcessor.selectedFolder}"; //$"Number of files: {fileCount}";
                folderSelectedLabel.Text = $"Folder selected: {fileProcessor.selectedFolder}";
                numOfFiles_label.Text = $"Number of files: {fileProcessor.fileCount}";
                progressBar1.Maximum = fileProcessor.fileCount;
                processFiles_button.Enabled = true; // enable processing button once folder is selected
            }
        }

        private async void processFiles_button_Click(object sender, EventArgs e)
        {
            processFiles_button.Enabled = false; // disable the button during processing
            progressBar1.Value = 0; // reset the progress bar

            var progress = new Progress<int>(value =>
            {
                // Update progress bar on UI thread
                progressBar1.Value = value;
            });

            await fileProcessor.ProcessFiles(progress);

            MessageBox.Show("Files processed!");
            processFiles_button.Enabled = true; // re-enable the button after processing
        }
    }


}
