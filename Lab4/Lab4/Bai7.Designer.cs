namespace Lab4
{
    partial class Bai7
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
            this.lblHNAG = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAll = new System.Windows.Forms.TabPage();
            this.tpMe = new System.Windows.Forms.TabPage();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHNAG
            // 
            this.lblHNAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHNAG.ForeColor = System.Drawing.Color.Red;
            this.lblHNAG.Location = new System.Drawing.Point(14, 47);
            this.lblHNAG.Name = "lblHNAG";
            this.lblHNAG.Size = new System.Drawing.Size(407, 60);
            this.lblHNAG.TabIndex = 0;
            this.lblHNAG.Text = "Hôm Nay Ăn Gì?";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(703, 93);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(111, 37);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "Ăn gì giờ?";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Visible = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(831, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 37);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm món ăn";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAll);
            this.tabControl1.Controls.Add(this.tpMe);
            this.tabControl1.Location = new System.Drawing.Point(17, 136);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 302);
            this.tabControl1.TabIndex = 3;
            // 
            // tpAll
            // 
            this.tpAll.Location = new System.Drawing.Point(4, 25);
            this.tpAll.Name = "tpAll";
            this.tpAll.Padding = new System.Windows.Forms.Padding(3);
            this.tpAll.Size = new System.Drawing.Size(934, 273);
            this.tpAll.TabIndex = 0;
            this.tpAll.Text = "All";
            this.tpAll.UseVisualStyleBackColor = true;
            // 
            // tpMe
            // 
            this.tpMe.Location = new System.Drawing.Point(4, 25);
            this.tpMe.Name = "tpMe";
            this.tpMe.Padding = new System.Windows.Forms.Padding(3);
            this.tpMe.Size = new System.Drawing.Size(934, 273);
            this.tpMe.TabIndex = 1;
            this.tpMe.Text = "Tôi đóng góp";
            this.tpMe.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(703, 27);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(111, 37);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(831, 27);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(111, 37);
            this.btnDangKy.TabIndex = 5;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 455);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.lblHNAG);
            this.Name = "Bai7";
            this.Text = "Bai7";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHNAG;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAll;
        private System.Windows.Forms.TabPage tpMe;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnDangKy;
    }
}