using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab1
{
    partial class Bai04
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.A_1 = new System.Windows.Forms.CheckBox();
            this.A_2 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.A_3 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.A_4 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.A_5 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn phim";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Đặt vé";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // A_1
            // 
            this.A_1.AutoSize = true;
            this.A_1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A_1.Location = new System.Drawing.Point(187, 48);
            this.A_1.Name = "A_1";
            this.A_1.Size = new System.Drawing.Size(18, 20);
            this.A_1.TabIndex = 0;
            this.A_1.Text = "1";
            this.A_1.UseVisualStyleBackColor = true;
            // 
            // A_2
            // 
            this.A_2.AutoSize = true;
            this.A_2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A_2.Location = new System.Drawing.Point(214, 48);
            this.A_2.Name = "A_2";
            this.A_2.Size = new System.Drawing.Size(18, 20);
            this.A_2.TabIndex = 0;
            this.A_2.Text = "2";
            this.A_2.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox5.Location = new System.Drawing.Point(187, 75);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(18, 20);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "1";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // A_3
            // 
            this.A_3.AutoSize = true;
            this.A_3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A_3.Location = new System.Drawing.Point(240, 48);
            this.A_3.Name = "A_3";
            this.A_3.Size = new System.Drawing.Size(18, 20);
            this.A_3.TabIndex = 0;
            this.A_3.Text = "3";
            this.A_3.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox10.Location = new System.Drawing.Point(187, 101);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(18, 20);
            this.checkBox10.TabIndex = 0;
            this.checkBox10.Text = "1";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox6.Location = new System.Drawing.Point(214, 75);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(18, 20);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "2";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // A_4
            // 
            this.A_4.AutoSize = true;
            this.A_4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A_4.Location = new System.Drawing.Point(266, 48);
            this.A_4.Name = "A_4";
            this.A_4.Size = new System.Drawing.Size(18, 20);
            this.A_4.TabIndex = 0;
            this.A_4.Text = "4";
            this.A_4.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox11.Location = new System.Drawing.Point(214, 101);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(18, 20);
            this.checkBox11.TabIndex = 0;
            this.checkBox11.Text = "2";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox7.Location = new System.Drawing.Point(240, 75);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(18, 20);
            this.checkBox7.TabIndex = 0;
            this.checkBox7.Text = "3";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // A_5
            // 
            this.A_5.AutoSize = true;
            this.A_5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A_5.Location = new System.Drawing.Point(293, 48);
            this.A_5.Name = "A_5";
            this.A_5.Size = new System.Drawing.Size(18, 20);
            this.A_5.TabIndex = 0;
            this.A_5.Text = "5";
            this.A_5.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox12.Location = new System.Drawing.Point(240, 101);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(18, 20);
            this.checkBox12.TabIndex = 0;
            this.checkBox12.Text = "3";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox8.Location = new System.Drawing.Point(266, 75);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(18, 20);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "4";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox9.Location = new System.Drawing.Point(293, 75);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(18, 20);
            this.checkBox9.TabIndex = 0;
            this.checkBox9.Text = "5";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox13.Location = new System.Drawing.Point(266, 101);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(18, 20);
            this.checkBox13.TabIndex = 0;
            this.checkBox13.Text = "4";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox14.Location = new System.Drawing.Point(293, 101);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(18, 20);
            this.checkBox14.TabIndex = 0;
            this.checkBox14.Text = "5";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "C";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox14);
            this.groupBox1.Controls.Add(this.checkBox13);
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.checkBox12);
            this.groupBox1.Controls.Add(this.A_5);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox11);
            this.groupBox1.Controls.Add(this.A_4);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox10);
            this.groupBox1.Controls.Add(this.A_3);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.A_2);
            this.groupBox1.Controls.Add(this.A_1);
            this.groupBox1.Location = new System.Drawing.Point(9, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 279);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn ghế";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phòng chiếu";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(416, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(132, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 373);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Bai04";
            this.Text = "Bai4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private CheckBox A_1;
        private CheckBox A_2;
        private CheckBox checkBox5;
        private CheckBox A_3;
        private CheckBox checkBox10;
        private CheckBox checkBox6;
        private CheckBox A_4;
        private CheckBox checkBox11;
        private CheckBox checkBox7;
        private CheckBox A_5;
        private CheckBox checkBox12;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox13;
        private CheckBox checkBox14;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Label label5;
        private ComboBox comboBox2;
    }
}