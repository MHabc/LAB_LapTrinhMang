namespace Lab5
{
    partial class Bai6_ReadMail
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
            this.lb_From = new System.Windows.Forms.Label();
            this.lb_To = new System.Windows.Forms.Label();
            this.lb_Subject = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "From : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "To: ";
            // 
            // lb_From
            // 
            this.lb_From.Location = new System.Drawing.Point(85, 18);
            this.lb_From.Name = "lb_From";
            this.lb_From.Size = new System.Drawing.Size(633, 16);
            this.lb_From.TabIndex = 2;
            // 
            // lb_To
            // 
            this.lb_To.Location = new System.Drawing.Point(85, 52);
            this.lb_To.Name = "lb_To";
            this.lb_To.Size = new System.Drawing.Size(681, 16);
            this.lb_To.TabIndex = 3;
            // 
            // lb_Subject
            // 
            this.lb_Subject.Location = new System.Drawing.Point(21, 91);
            this.lb_Subject.Name = "lb_Subject";
            this.lb_Subject.Size = new System.Drawing.Size(745, 23);
            this.lb_Subject.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 133);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(800, 454);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // Bai6_ReadMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lb_Subject);
            this.Controls.Add(this.lb_To);
            this.Controls.Add(this.lb_From);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai6_ReadMail";
            this.Text = "Bai6_ReadMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_From;
        private System.Windows.Forms.Label lb_To;
        private System.Windows.Forms.Label lb_Subject;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}