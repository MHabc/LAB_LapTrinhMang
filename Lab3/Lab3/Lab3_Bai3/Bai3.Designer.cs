namespace Lab3_Bai3
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
            this.btnOpenTCPServer = new System.Windows.Forms.Button();
            this.btnOpenNewTCPClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenTCPServer
            // 
            this.btnOpenTCPServer.BackColor = System.Drawing.Color.Salmon;
            this.btnOpenTCPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenTCPServer.Location = new System.Drawing.Point(237, 128);
            this.btnOpenTCPServer.Name = "btnOpenTCPServer";
            this.btnOpenTCPServer.Size = new System.Drawing.Size(325, 57);
            this.btnOpenTCPServer.TabIndex = 0;
            this.btnOpenTCPServer.Text = "Open TCP Server";
            this.btnOpenTCPServer.UseVisualStyleBackColor = false;
            this.btnOpenTCPServer.Click += new System.EventHandler(this.btnOpenTCPServer_Click);
            // 
            // btnOpenNewTCPClient
            // 
            this.btnOpenNewTCPClient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpenNewTCPClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenNewTCPClient.Location = new System.Drawing.Point(237, 240);
            this.btnOpenNewTCPClient.Name = "btnOpenNewTCPClient";
            this.btnOpenNewTCPClient.Size = new System.Drawing.Size(325, 57);
            this.btnOpenNewTCPClient.TabIndex = 1;
            this.btnOpenNewTCPClient.Text = "Open New TCP Client";
            this.btnOpenNewTCPClient.UseVisualStyleBackColor = false;
            this.btnOpenNewTCPClient.Click += new System.EventHandler(this.btnOpenNewTCPClient_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenNewTCPClient);
            this.Controls.Add(this.btnOpenTCPServer);
            this.Name = "Bai3";
            this.Text = "Bài 3";
            this.Load += new System.EventHandler(this.Bai3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenTCPServer;
        private System.Windows.Forms.Button btnOpenNewTCPClient;
    }
}

