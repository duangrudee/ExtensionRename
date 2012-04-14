namespace RenameFile
{
    partial class Form1
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
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFromExt = new System.Windows.Forms.TextBox();
            this.txtToExt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.browseBtn = new System.Windows.Forms.Button();
            this.chkSubFolderSearch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(118, 161);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder :";
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Location = new System.Drawing.Point(91, 20);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(252, 20);
            this.txtSourceFolder.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "From Extension";
            // 
            // txtFromExt
            // 
            this.txtFromExt.Location = new System.Drawing.Point(118, 94);
            this.txtFromExt.Name = "txtFromExt";
            this.txtFromExt.Size = new System.Drawing.Size(128, 20);
            this.txtFromExt.TabIndex = 4;
            // 
            // txtToExt
            // 
            this.txtToExt.Location = new System.Drawing.Point(118, 121);
            this.txtToExt.Name = "txtToExt";
            this.txtToExt.Size = new System.Drawing.Size(128, 20);
            this.txtToExt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "To Extension";
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(267, 47);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 7;
            this.browseBtn.Text = "Browse...";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // chkSubFolderSearch
            // 
            this.chkSubFolderSearch.AutoSize = true;
            this.chkSubFolderSearch.Location = new System.Drawing.Point(91, 46);
            this.chkSubFolderSearch.Name = "chkSubFolderSearch";
            this.chkSubFolderSearch.Size = new System.Drawing.Size(120, 17);
            this.chkSubFolderSearch.TabIndex = 8;
            this.chkSubFolderSearch.Text = "Include Sub Folders";
            this.chkSubFolderSearch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 206);
            this.Controls.Add(this.chkSubFolderSearch);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.txtToExt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFromExt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSourceFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.Text = "Rename File Extension";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFromExt;
        private System.Windows.Forms.TextBox txtToExt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.CheckBox chkSubFolderSearch;
    }
}

