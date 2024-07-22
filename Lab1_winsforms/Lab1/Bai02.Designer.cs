namespace Lab1
{
    partial class Bai02
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
            this.txbSo1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSo2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSo3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSoMin = new System.Windows.Forms.TextBox();
            this.txbSoMax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Thứ Nhất";
            // 
            // txbSo1
            // 
            this.txbSo1.Location = new System.Drawing.Point(128, 93);
            this.txbSo1.Name = "txbSo1";
            this.txbSo1.Size = new System.Drawing.Size(100, 22);
            this.txbSo1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số Thứ Hai";
            // 
            // txbSo2
            // 
            this.txbSo2.Location = new System.Drawing.Point(361, 93);
            this.txbSo2.Name = "txbSo2";
            this.txbSo2.Size = new System.Drawing.Size(100, 22);
            this.txbSo2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Thứ Ba";
            // 
            // txbSo3
            // 
            this.txbSo3.Location = new System.Drawing.Point(599, 93);
            this.txbSo3.Name = "txbSo3";
            this.txbSo3.Size = new System.Drawing.Size(100, 22);
            this.txbSo3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(599, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 8;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số Nhỏ Nhất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số Lớn Nhất";
            // 
            // txbSoMin
            // 
            this.txbSoMin.Location = new System.Drawing.Point(578, 335);
            this.txbSoMin.Name = "txbSoMin";
            this.txbSoMin.ReadOnly = true;
            this.txbSoMin.Size = new System.Drawing.Size(100, 22);
            this.txbSoMin.TabIndex = 11;
            // 
            // txbSoMax
            // 
            this.txbSoMax.Location = new System.Drawing.Point(158, 335);
            this.txbSoMax.Name = "txbSoMax";
            this.txbSoMax.ReadOnly = true;
            this.txbSoMax.Size = new System.Drawing.Size(100, 22);
            this.txbSoMax.TabIndex = 12;
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbSoMax);
            this.Controls.Add(this.txbSoMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbSo3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSo2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbSo1);
            this.Controls.Add(this.label1);
            this.Name = "Bai02";
            this.Text = "Bài 02";
            this.Load += new System.EventHandler(this.Bai02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSo3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSoMin;
        private System.Windows.Forms.TextBox txbSoMax;
    }
}