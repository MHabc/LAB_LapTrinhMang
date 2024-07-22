namespace Lab1
{
    partial class Bai08
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
            this.txbNhapMAmoi = new System.Windows.Forms.TextBox();
            this.txbListMA = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbKetqua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập món ăn";
            // 
            // txbNhapMAmoi
            // 
            this.txbNhapMAmoi.Location = new System.Drawing.Point(173, 22);
            this.txbNhapMAmoi.Name = "txbNhapMAmoi";
            this.txbNhapMAmoi.Size = new System.Drawing.Size(198, 22);
            this.txbNhapMAmoi.TabIndex = 1;
            // 
            // txbListMA
            // 
            this.txbListMA.Location = new System.Drawing.Point(412, 12);
            this.txbListMA.Multiline = true;
            this.txbListMA.Name = "txbListMA";
            this.txbListMA.ReadOnly = true;
            this.txbListMA.Size = new System.Drawing.Size(363, 217);
            this.txbListMA.TabIndex = 2;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(291, 71);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(80, 40);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(100, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Tìm món ăn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnTimMA_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(412, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(695, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hôm nay sẽ ăn :";
            // 
            // txbKetqua
            // 
            this.txbKetqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbKetqua.Location = new System.Drawing.Point(230, 366);
            this.txbKetqua.Multiline = true;
            this.txbKetqua.Name = "txbKetqua";
            this.txbKetqua.ReadOnly = true;
            this.txbKetqua.Size = new System.Drawing.Size(296, 22);
            this.txbKetqua.TabIndex = 9;
            this.txbKetqua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bai08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbKetqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txbListMA);
            this.Controls.Add(this.txbNhapMAmoi);
            this.Controls.Add(this.label1);
            this.Name = "Bai08";
            this.Text = "Bài 08";
            this.Load += new System.EventHandler(this.Bai08_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNhapMAmoi;
        private System.Windows.Forms.TextBox txbListMA;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbKetqua;
    }
}