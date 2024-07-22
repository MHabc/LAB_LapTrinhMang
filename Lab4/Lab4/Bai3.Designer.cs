namespace Lab4
{
    partial class Bai3
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDownFile = new System.Windows.Forms.Button();
            this.btnDownSources = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(104, 28);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Website";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(122, 15);
            this.txtDomain.Multiline = true;
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(756, 25);
            this.txtDomain.TabIndex = 1;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(884, 12);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(86, 28);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDownFile
            // 
            this.btnDownFile.Location = new System.Drawing.Point(976, 12);
            this.btnDownFile.Name = "btnDownFile";
            this.btnDownFile.Size = new System.Drawing.Size(92, 28);
            this.btnDownFile.TabIndex = 3;
            this.btnDownFile.Text = "Down Files";
            this.btnDownFile.UseVisualStyleBackColor = true;
            this.btnDownFile.Click += new System.EventHandler(this.btnDownFile_Click);
            // 
            // btnDownSources
            // 
            this.btnDownSources.Location = new System.Drawing.Point(1074, 13);
            this.btnDownSources.Name = "btnDownSources";
            this.btnDownSources.Size = new System.Drawing.Size(163, 28);
            this.btnDownSources.TabIndex = 4;
            this.btnDownSources.Text = "Down Resources";
            this.btnDownSources.UseVisualStyleBackColor = true;
            this.btnDownSources.Click += new System.EventHandler(this.btnDownSources_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(12, 47);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1225, 638);
            this.webView21.TabIndex = 5;
            this.webView21.ZoomFactor = 1D;
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 697);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.btnDownSources);
            this.Controls.Add(this.btnDownFile);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.btnLoad);
            this.Name = "Bai3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bai3";
            this.Load += new System.EventHandler(this.Bai3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDownFile;
        private System.Windows.Forms.Button btnDownSources;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}