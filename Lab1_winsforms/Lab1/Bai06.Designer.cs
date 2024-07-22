namespace Lab1
{
    partial class Bai06
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
            this.txbNgay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbThang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbKetqua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập ngày tháng năm sinh";
            // 
            // txbNgay
            // 
            this.txbNgay.Location = new System.Drawing.Point(151, 92);
            this.txbNgay.Name = "txbNgay";
            this.txbNgay.Size = new System.Drawing.Size(76, 22);
            this.txbNgay.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kiểm tra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(523, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kết quả";
            // 
            // txbThang
            // 
            this.txbThang.Location = new System.Drawing.Point(354, 92);
            this.txbThang.Multiline = true;
            this.txbThang.Name = "txbThang";
            this.txbThang.Size = new System.Drawing.Size(76, 22);
            this.txbThang.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tháng";
            // 
            // txbNam
            // 
            this.txbNam.Location = new System.Drawing.Point(580, 92);
            this.txbNam.Name = "txbNam";
            this.txbNam.Size = new System.Drawing.Size(76, 22);
            this.txbNam.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Năm";
            // 
            // txbKetqua
            // 
            this.txbKetqua.Location = new System.Drawing.Point(142, 316);
            this.txbKetqua.Multiline = true;
            this.txbKetqua.Name = "txbKetqua";
            this.txbKetqua.ReadOnly = true;
            this.txbKetqua.Size = new System.Drawing.Size(433, 78);
            this.txbKetqua.TabIndex = 11;
            // 
            // Bai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbKetqua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbNgay);
            this.Controls.Add(this.label1);
            this.Name = "Bai06";
            this.Text = "Bài 06";
            this.Load += new System.EventHandler(this.Bai06_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNgay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbKetqua;
    }
}