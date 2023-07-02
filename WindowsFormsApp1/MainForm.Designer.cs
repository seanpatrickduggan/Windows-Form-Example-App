using System;

namespace WindowsFormApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.folderSelect = new System.Windows.Forms.Button();
            this.folderSelectedLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.processFiles_button = new System.Windows.Forms.Button();
            this.numOfFiles_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderTextBox
            // 
            this.folderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderTextBox.Location = new System.Drawing.Point(17, 16);
            this.folderTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(632, 38);
            this.folderTextBox.TabIndex = 0;
            // 
            // folderSelect
            // 
            this.folderSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderSelect.Location = new System.Drawing.Point(665, 16);
            this.folderSelect.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.folderSelect.Name = "folderSelect";
            this.folderSelect.Size = new System.Drawing.Size(114, 38);
            this.folderSelect.TabIndex = 1;
            this.folderSelect.Text = "Select Folder";
            this.folderSelect.UseVisualStyleBackColor = true;
            this.folderSelect.Click += new System.EventHandler(this.FolderSelect_Click);
            // 
            // folderSelectedLabel
            // 
            this.folderSelectedLabel.AutoSize = true;
            this.folderSelectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.folderSelectedLabel.Location = new System.Drawing.Point(17, 61);
            this.folderSelectedLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.folderSelectedLabel.Name = "folderSelectedLabel";
            this.folderSelectedLabel.Size = new System.Drawing.Size(241, 20);
            this.folderSelectedLabel.TabIndex = 2;
            this.folderSelectedLabel.Text = "Folder Selected: (Select a folder)";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 119);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(647, 38);
            this.progressBar1.TabIndex = 3;
            // 
            // processFiles_button
            // 
            this.processFiles_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processFiles_button.Location = new System.Drawing.Point(665, 119);
            this.processFiles_button.Name = "processFiles_button";
            this.processFiles_button.Size = new System.Drawing.Size(119, 38);
            this.processFiles_button.TabIndex = 4;
            this.processFiles_button.Text = "Process Files";
            this.processFiles_button.UseVisualStyleBackColor = true;
            this.processFiles_button.Click += new System.EventHandler(this.processFiles_button_Click);
            // 
            // numOfFiles_label
            // 
            this.numOfFiles_label.AutoSize = true;
            this.numOfFiles_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numOfFiles_label.Location = new System.Drawing.Point(17, 81);
            this.numOfFiles_label.Name = "numOfFiles_label";
            this.numOfFiles_label.Size = new System.Drawing.Size(235, 20);
            this.numOfFiles_label.TabIndex = 5;
            this.numOfFiles_label.Text = "Number of files: (Select a folder)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 169);
            this.Controls.Add(this.numOfFiles_label);
            this.Controls.Add(this.processFiles_button);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.folderSelectedLabel);
            this.Controls.Add(this.folderSelect);
            this.Controls.Add(this.folderTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainForm";
            this.Text = "File Processor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.Button folderSelect;
        private System.Windows.Forms.Label folderSelectedLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button processFiles_button;
        private System.Windows.Forms.Label numOfFiles_label;
    }
}