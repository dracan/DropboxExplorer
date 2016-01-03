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
            this.textBox_AuthToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ListDirectoryStructure = new System.Windows.Forms.Button();
            this.groupBox_Size = new System.Windows.Forms.GroupBox();
            this.label_SizeInMB = new System.Windows.Forms.Label();
            this.label_SizeInBytes = new System.Windows.Forms.Label();
            this.label_SizeInGB = new System.Windows.Forms.Label();
            this.groupBox_Size.SuspendLayout();
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
            // groupBox_Size
            // 
            this.groupBox_Size.Controls.Add(this.label_SizeInGB);
            this.groupBox_Size.Controls.Add(this.label_SizeInBytes);
            this.groupBox_Size.Controls.Add(this.label_SizeInMB);
            this.groupBox_Size.Location = new System.Drawing.Point(643, 224);
            this.groupBox_Size.Name = "groupBox_Size";
            this.groupBox_Size.Size = new System.Drawing.Size(303, 143);
            this.groupBox_Size.TabIndex = 6;
            this.groupBox_Size.TabStop = false;
            this.groupBox_Size.Text = "Folder Size";
            // 
            // label_SizeInMB
            // 
            this.label_SizeInMB.AutoSize = true;
            this.label_SizeInMB.Location = new System.Drawing.Point(29, 71);
            this.label_SizeInMB.Name = "label_SizeInMB";
            this.label_SizeInMB.Size = new System.Drawing.Size(120, 20);
            this.label_SizeInMB.TabIndex = 7;
            this.label_SizeInMB.Text = "label_SizeInMB";
            // 
            // label_SizeInBytes
            // 
            this.label_SizeInBytes.AutoSize = true;
            this.label_SizeInBytes.Location = new System.Drawing.Point(29, 41);
            this.label_SizeInBytes.Name = "label_SizeInBytes";
            this.label_SizeInBytes.Size = new System.Drawing.Size(136, 20);
            this.label_SizeInBytes.TabIndex = 8;
            this.label_SizeInBytes.Text = "label_SizeInBytes";
            // 
            // label_SizeInGB
            // 
            this.label_SizeInGB.AutoSize = true;
            this.label_SizeInGB.Location = new System.Drawing.Point(29, 101);
            this.label_SizeInGB.Name = "label_SizeInGB";
            this.label_SizeInGB.Size = new System.Drawing.Size(120, 20);
            this.label_SizeInGB.TabIndex = 9;
            this.label_SizeInGB.Text = "label_SizeInGB";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 877);
            this.Controls.Add(this.groupBox_Size);
            this.Controls.Add(this.button_ListDirectoryStructure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_AuthToken);
            this.Controls.Add(this.button_GetFolderSize);
            this.Controls.Add(this.treeView_DirectoryTree);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dropbox Explorer";
            this.groupBox_Size.ResumeLayout(false);
            this.groupBox_Size.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_DirectoryTree;
        private System.Windows.Forms.Button button_GetFolderSize;
        private System.Windows.Forms.TextBox textBox_AuthToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ListDirectoryStructure;
        private System.Windows.Forms.GroupBox groupBox_Size;
        private System.Windows.Forms.Label label_SizeInBytes;
        private System.Windows.Forms.Label label_SizeInMB;
        private System.Windows.Forms.Label label_SizeInGB;
    }
}

