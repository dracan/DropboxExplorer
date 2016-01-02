namespace DropboxExplorer
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
            this.treeView_DirectoryTree = new System.Windows.Forms.TreeView();
            this.button_GetFolderSize = new System.Windows.Forms.Button();
            this.label_Results = new System.Windows.Forms.Label();
            this.textBox_AuthToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ListDirectoryStructure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView_DirectoryTree
            // 
            this.treeView_DirectoryTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView_DirectoryTree.Location = new System.Drawing.Point(0, 0);
            this.treeView_DirectoryTree.Name = "treeView_DirectoryTree";
            this.treeView_DirectoryTree.Size = new System.Drawing.Size(602, 877);
            this.treeView_DirectoryTree.TabIndex = 0;
            this.treeView_DirectoryTree.DoubleClick += new System.EventHandler(this.treeView_DirectoryTree_DoubleClick);
            // 
            // button_GetFolderSize
            // 
            this.button_GetFolderSize.Location = new System.Drawing.Point(640, 139);
            this.button_GetFolderSize.Name = "button_GetFolderSize";
            this.button_GetFolderSize.Size = new System.Drawing.Size(306, 54);
            this.button_GetFolderSize.TabIndex = 1;
            this.button_GetFolderSize.Text = "Get Folder Size";
            this.button_GetFolderSize.UseVisualStyleBackColor = true;
            this.button_GetFolderSize.Click += new System.EventHandler(this.button_GetFolderSize_Click);
            // 
            // label_Results
            // 
            this.label_Results.AutoSize = true;
            this.label_Results.Location = new System.Drawing.Point(672, 225);
            this.label_Results.Name = "label_Results";
            this.label_Results.Size = new System.Drawing.Size(197, 20);
            this.label_Results.TabIndex = 2;
            this.label_Results.Text = "RESULT PLACEHOLDER";
            // 
            // textBox_AuthToken
            // 
            this.textBox_AuthToken.Location = new System.Drawing.Point(759, 26);
            this.textBox_AuthToken.Name = "textBox_AuthToken";
            this.textBox_AuthToken.Size = new System.Drawing.Size(433, 26);
            this.textBox_AuthToken.TabIndex = 3;
            this.textBox_AuthToken.TextChanged += new System.EventHandler(this.textBox_AuthToken_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Auth Token:";
            // 
            // button_ListDirectoryStructure
            // 
            this.button_ListDirectoryStructure.Location = new System.Drawing.Point(640, 79);
            this.button_ListDirectoryStructure.Name = "button_ListDirectoryStructure";
            this.button_ListDirectoryStructure.Size = new System.Drawing.Size(306, 54);
            this.button_ListDirectoryStructure.TabIndex = 5;
            this.button_ListDirectoryStructure.Text = "List Directory Structure";
            this.button_ListDirectoryStructure.UseVisualStyleBackColor = true;
            this.button_ListDirectoryStructure.Click += new System.EventHandler(this.button_ListDirectoryStructure_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 877);
            this.Controls.Add(this.button_ListDirectoryStructure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_AuthToken);
            this.Controls.Add(this.label_Results);
            this.Controls.Add(this.button_GetFolderSize);
            this.Controls.Add(this.treeView_DirectoryTree);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dropbox Explorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_DirectoryTree;
        private System.Windows.Forms.Button button_GetFolderSize;
        private System.Windows.Forms.Label label_Results;
        private System.Windows.Forms.TextBox textBox_AuthToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ListDirectoryStructure;
    }
}

