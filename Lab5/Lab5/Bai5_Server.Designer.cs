using System;

namespace Lab5
{
    partial class Bai5_Server
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
            this.WelcomeText = new System.Windows.Forms.Label();
            this.randomBtn = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.imageResult = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOn = new System.Windows.Forms.Button();
            this.lblMonAn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNguoiDongGop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeText
            // 
            this.WelcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.WelcomeText.Location = new System.Drawing.Point(286, 24);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(226, 60);
            this.WelcomeText.TabIndex = 0;
            this.WelcomeText.Text = "HÔM NAY ĂN GÌ ?";
            // 
            // randomBtn
            // 
            this.randomBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.randomBtn.Location = new System.Drawing.Point(940, 105);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(146, 57);
            this.randomBtn.TabIndex = 3;
            this.randomBtn.Text = "RANDOM";
            this.randomBtn.UseVisualStyleBackColor = false;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(736, 208);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(85, 16);
            this.result.TabIndex = 4;
            this.result.Text = "Hôm nay ăn: ";
            // 
            // imageResult
            // 
            this.imageResult.Location = new System.Drawing.Point(739, 304);
            this.imageResult.Name = "imageResult";
            this.imageResult.Size = new System.Drawing.Size(630, 420);
            this.imageResult.TabIndex = 5;
            this.imageResult.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(671, 619);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "xzfw uwfv ghkc gged";
            // 
            // btnOn
            // 
            this.btnOn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOn.Location = new System.Drawing.Point(730, 105);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(158, 57);
            this.btnOn.TabIndex = 8;
            this.btnOn.Text = "ON";
            this.btnOn.UseVisualStyleBackColor = false;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // lblMonAn
            // 
            this.lblMonAn.Location = new System.Drawing.Point(859, 208);
            this.lblMonAn.Name = "lblMonAn";
            this.lblMonAn.Size = new System.Drawing.Size(162, 16);
            this.lblMonAn.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(736, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Người đóng góp";
            // 
            // lblNguoiDongGop
            // 
            this.lblNguoiDongGop.Location = new System.Drawing.Point(859, 254);
            this.lblNguoiDongGop.Name = "lblNguoiDongGop";
            this.lblNguoiDongGop.Size = new System.Drawing.Size(300, 16);
            this.lblNguoiDongGop.TabIndex = 11;
            // 
            // Bai5_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 740);
            this.Controls.Add(this.lblNguoiDongGop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMonAn);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.imageResult);
            this.Controls.Add(this.result);
            this.Controls.Add(this.randomBtn);
            this.Controls.Add(this.WelcomeText);
            this.Controls.Add(this.label1);
            this.Name = "Bai5_Server";
            this.Text = "Bai5_Server";
            this.Load += new System.EventHandler(this.Bai5_Server_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeText;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.PictureBox imageResult;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Label lblMonAn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNguoiDongGop;
    }
}