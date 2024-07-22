namespace Lab1
{
    partial class Bai03
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
            this.txbNhap = new System.Windows.Forms.TextBox();
            this.txbKetqua = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập vào số nguyên từ 0 đến 9";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kết quả";
            // 
            // txbNhap
            // 
            this.txbNhap.Location = new System.Drawing.Point(274, 101);
            this.txbNhap.Name = "txbNhap";
            this.txbNhap.Size = new System.Drawing.Size(100, 22);
            this.txbNhap.TabIndex = 3;
            // 
            // txbKetqua
            // 
            this.txbKetqua.Location = new System.Drawing.Point(58, 269);
            this.txbKetqua.Name = "txbKetqua";
            this.txbKetqua.ReadOnly = true;
            this.txbKetqua.Size = new System.Drawing.Size(216, 22);
            this.txbKetqua.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(549, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(549, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 41);
            this.button3.TabIndex = 7;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbKetqua);
            this.Controls.Add(this.txbNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai03";
            this.Text = "Bài 03";
            this.Load += new System.EventHandler(this.Bai03_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNhap;
        private System.Windows.Forms.TextBox txbKetqua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}