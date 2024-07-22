namespace Lab3
{
    partial class Bai1
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
            this.btnUDPServer = new System.Windows.Forms.Button();
            this.btnUDPClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUDPServer
            // 
            this.btnUDPServer.BackColor = System.Drawing.Color.LightCoral;
            this.btnUDPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUDPServer.Location = new System.Drawing.Point(124, 140);
            this.btnUDPServer.Name = "btnUDPServer";
            this.btnUDPServer.Size = new System.Drawing.Size(179, 50);
            this.btnUDPServer.TabIndex = 0;
            this.btnUDPServer.Text = "UDP Server";
            this.btnUDPServer.UseVisualStyleBackColor = false;
            this.btnUDPServer.Click += new System.EventHandler(this.btnUDPServer_Click);
            // 
            // btnUDPClient
            // 
            this.btnUDPClient.BackColor = System.Drawing.Color.YellowGreen;
            this.btnUDPClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUDPClient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUDPClient.Location = new System.Drawing.Point(471, 140);
            this.btnUDPClient.Name = "btnUDPClient";
            this.btnUDPClient.Size = new System.Drawing.Size(179, 50);
            this.btnUDPClient.TabIndex = 1;
            this.btnUDPClient.Text = "UDP Client";
            this.btnUDPClient.UseVisualStyleBackColor = false;
            this.btnUDPClient.Click += new System.EventHandler(this.btnUDPClient_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(777, 348);
            this.Controls.Add(this.btnUDPClient);
            this.Controls.Add(this.btnUDPServer);
            this.Name = "Bai1";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Bai1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUDPServer;
        private System.Windows.Forms.Button btnUDPClient;
    }
}

