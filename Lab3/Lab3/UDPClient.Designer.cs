namespace Lab3
{
    partial class UDPClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.txbPort = new System.Windows.Forms.TextBox();
            this.rtxbMessage = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Remote host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Message";
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(72, 94);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(344, 22);
            this.txbIP.TabIndex = 3;
            // 
            // txbPort
            // 
            this.txbPort.Location = new System.Drawing.Point(577, 93);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(142, 22);
            this.txbPort.TabIndex = 4;
            // 
            // rtxbMessage
            // 
            this.rtxbMessage.Location = new System.Drawing.Point(72, 202);
            this.rtxbMessage.Name = "rtxbMessage";
            this.rtxbMessage.Size = new System.Drawing.Size(647, 144);
            this.rtxbMessage.TabIndex = 5;
            this.rtxbMessage.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(72, 369);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(113, 36);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // UDPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtxbMessage);
            this.Controls.Add(this.txbPort);
            this.Controls.Add(this.txbIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UDPClient";
            this.Text = "UDP Client";
            this.Load += new System.EventHandler(this.UDPClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.TextBox txbPort;
        private System.Windows.Forms.RichTextBox rtxbMessage;
        private System.Windows.Forms.Button btnSend;
    }
}