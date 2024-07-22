namespace Lab2
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblMonAn = new System.Windows.Forms.Label();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.btnRandomDish = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(314, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(474, 215);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblMonAn
            // 
            this.lblMonAn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonAn.Location = new System.Drawing.Point(159, 266);
            this.lblMonAn.Name = "lblMonAn";
            this.lblMonAn.Size = new System.Drawing.Size(273, 47);
            this.lblMonAn.TabIndex = 1;
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiDung.Location = new System.Drawing.Point(159, 343);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(273, 47);
            this.lblNguoiDung.TabIndex = 2;
            // 
            // btnRandomDish
            // 
            this.btnRandomDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomDish.Location = new System.Drawing.Point(94, 97);
            this.btnRandomDish.Name = "btnRandomDish";
            this.btnRandomDish.Size = new System.Drawing.Size(140, 55);
            this.btnRandomDish.TabIndex = 3;
            this.btnRandomDish.Text = "RANDOM";
            this.btnRandomDish.UseVisualStyleBackColor = true;
            this.btnRandomDish.Click += new System.EventHandler(this.btnRandomDish_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(455, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 172);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 274);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(111, 39);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Món ăn: ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên người dùng: ";
            // 
            // Bai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRandomDish);
            this.Controls.Add(this.lblNguoiDung);
            this.Controls.Add(this.lblMonAn);
            this.Controls.Add(this.listView1);
            this.Name = "Bai06";
            this.Text = "Bai6";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblMonAn;
        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.Button btnRandomDish;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
    }
}