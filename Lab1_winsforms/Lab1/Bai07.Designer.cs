namespace Lab1
{
    partial class Bai07
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
            this.txbNhapSV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txbKetqua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập điểm sinh viên";
            // 
            // txbNhapSV
            // 
            this.txbNhapSV.Location = new System.Drawing.Point(79, 68);
            this.txbNhapSV.Multiline = true;
            this.txbNhapSV.Name = "txbNhapSV";
            this.txbNhapSV.Size = new System.Drawing.Size(679, 58);
            this.txbNhapSV.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(174, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kiểm tra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(560, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txbKetqua
            // 
            this.txbKetqua.Location = new System.Drawing.Point(79, 250);
            this.txbKetqua.Multiline = true;
            this.txbKetqua.Name = "txbKetqua";
            this.txbKetqua.ReadOnly = true;
            this.txbKetqua.Size = new System.Drawing.Size(679, 168);
            this.txbKetqua.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kết quả";
            // 
            // Bai07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbKetqua);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbNhapSV);
            this.Controls.Add(this.label1);
            this.Name = "Bai07";
            this.Text = "Bài 07";
            this.Load += new System.EventHandler(this.Bai07_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNhapSV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txbKetqua;
        private System.Windows.Forms.Label label2;
    }
}