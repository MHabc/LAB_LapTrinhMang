namespace Lab3_Bai5
{
    partial class Client 
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
            this.labelMonAn = new System.Windows.Forms.Label();
            this.txtMonAn = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.labelMonAnHomNay = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lblMonAnHomNay = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMonAn
            // 
            this.labelMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonAn.Location = new System.Drawing.Point(26, 81);
            this.labelMonAn.Name = "labelMonAn";
            this.labelMonAn.Size = new System.Drawing.Size(135, 53);
            this.labelMonAn.TabIndex = 0;
            this.labelMonAn.Text = "Nhập món ăn";
            // 
            // txtMonAn
            // 
            this.txtMonAn.Location = new System.Drawing.Point(150, 81);
            this.txtMonAn.Name = "txtMonAn";
            this.txtMonAn.Size = new System.Drawing.Size(331, 22);
            this.txtMonAn.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(600, 81);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(166, 38);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(163, 155);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(166, 38);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send to Server";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // labelMonAnHomNay
            // 
            this.labelMonAnHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonAnHomNay.Location = new System.Drawing.Point(336, 293);
            this.labelMonAnHomNay.Name = "labelMonAnHomNay";
            this.labelMonAnHomNay.Size = new System.Drawing.Size(166, 26);
            this.labelMonAnHomNay.TabIndex = 4;
            this.labelMonAnHomNay.Text = "Món ăn hôm nay:";
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(600, 155);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(166, 38);
            this.btnRandom.TabIndex = 6;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lblMonAnHomNay
            // 
            this.lblMonAnHomNay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMonAnHomNay.Location = new System.Drawing.Point(142, 332);
            this.lblMonAnHomNay.Name = "lblMonAnHomNay";
            this.lblMonAnHomNay.Size = new System.Drawing.Size(524, 80);
            this.lblMonAnHomNay.TabIndex = 7;
            this.lblMonAnHomNay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(600, 235);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(166, 38);
            this.btnDisconnect.TabIndex = 11;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.lblMonAnHomNay);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.labelMonAnHomNay);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtMonAn);
            this.Controls.Add(this.labelMonAn);
            this.Name = "Client";
            this.Text = "Bài 5 - Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMonAn;
        private System.Windows.Forms.TextBox txtMonAn;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label labelMonAnHomNay;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label lblMonAnHomNay;
        private System.Windows.Forms.Button btnDisconnect;
    }
}