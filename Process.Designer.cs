namespace NaverAutoClick
{
    partial class Process
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
            this.webBrowserProcess = new System.Windows.Forms.WebBrowser();
            this.textBoxWebBrowserProcessUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // webBrowserProcess
            // 
            this.webBrowserProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserProcess.Location = new System.Drawing.Point(12, 42);
            this.webBrowserProcess.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserProcess.Name = "webBrowserProcess";
            this.webBrowserProcess.Size = new System.Drawing.Size(336, 546);
            this.webBrowserProcess.TabIndex = 0;
            this.webBrowserProcess.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserProcess_DocumentCompleted);
            // 
            // textBoxWebBrowserProcessUrl
            // 
            this.textBoxWebBrowserProcessUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWebBrowserProcessUrl.Location = new System.Drawing.Point(12, 15);
            this.textBoxWebBrowserProcessUrl.Name = "textBoxWebBrowserProcessUrl";
            this.textBoxWebBrowserProcessUrl.Size = new System.Drawing.Size(336, 21);
            this.textBoxWebBrowserProcessUrl.TabIndex = 1;
            this.textBoxWebBrowserProcessUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxWebBrowserProcessUrl_KeyDown);
            // 
            // Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 600);
            this.Controls.Add(this.textBoxWebBrowserProcessUrl);
            this.Controls.Add(this.webBrowserProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Process";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "네이버 자동 클릭";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Process_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserProcess;
        private System.Windows.Forms.TextBox textBoxWebBrowserProcessUrl;
    }
}