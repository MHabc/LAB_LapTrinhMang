using System.Drawing;
using System.Windows.Forms;

namespace Lab5
{
    partial class Bai2
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
            this.lb_mail = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_recent = new System.Windows.Forms.Label();
            this.lb_show_total = new System.Windows.Forms.Label();
            this.lb_show_recent = new System.Windows.Forms.Label();
            this.cb_show_pass = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_mail
            // 
            this.lb_mail.AutoSize = true;
            this.lb_mail.Location = new System.Drawing.Point(18, 19);
            this.lb_mail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mail.Name = "lb_mail";
            this.lb_mail.Size = new System.Drawing.Size(44, 16);
            this.lb_mail.TabIndex = 0;
            this.lb_mail.Text = "Email:";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Location = new System.Drawing.Point(18, 54);
            this.lb_pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(70, 16);
            this.lb_pass.TabIndex = 1;
            this.lb_pass.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(92, 50);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(265, 22);
            this.txt_password.TabIndex = 2;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(92, 15);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(265, 22);
            this.txt_email.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_login.Location = new System.Drawing.Point(491, 19);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(147, 51);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(21, 127);
            this.lb_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(41, 16);
            this.lb_total.TabIndex = 5;
            this.lb_total.Text = "Total:";
            // 
            // lb_recent
            // 
            this.lb_recent.AutoSize = true;
            this.lb_recent.Location = new System.Drawing.Point(169, 127);
            this.lb_recent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_recent.Name = "lb_recent";
            this.lb_recent.Size = new System.Drawing.Size(53, 16);
            this.lb_recent.TabIndex = 6;
            this.lb_recent.Text = "Recent:";
            // 
            // lb_show_total
            // 
            this.lb_show_total.AutoSize = true;
            this.lb_show_total.Location = new System.Drawing.Point(86, 127);
            this.lb_show_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_show_total.Name = "lb_show_total";
            this.lb_show_total.Size = new System.Drawing.Size(0, 16);
            this.lb_show_total.TabIndex = 8;
            // 
            // lb_show_recent
            // 
            this.lb_show_recent.AutoSize = true;
            this.lb_show_recent.Location = new System.Drawing.Point(246, 127);
            this.lb_show_recent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_show_recent.Name = "lb_show_recent";
            this.lb_show_recent.Size = new System.Drawing.Size(0, 16);
            this.lb_show_recent.TabIndex = 9;
            // 
            // cb_show_pass
            // 
            this.cb_show_pass.AutoSize = true;
            this.cb_show_pass.Location = new System.Drawing.Point(233, 85);
            this.cb_show_pass.Margin = new System.Windows.Forms.Padding(2);
            this.cb_show_pass.Name = "cb_show_pass";
            this.cb_show_pass.Size = new System.Drawing.Size(124, 20);
            this.cb_show_pass.TabIndex = 10;
            this.cb_show_pass.Text = "Show password";
            this.cb_show_pass.UseVisualStyleBackColor = true;
            this.cb_show_pass.CheckedChanged += new System.EventHandler(this.cb_show_pass_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 156);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(617, 266);
            this.dataGridView1.TabIndex = 15;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 433);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_show_pass);
            this.Controls.Add(this.lb_show_recent);
            this.Controls.Add(this.lb_show_total);
            this.Controls.Add(this.lb_recent);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_mail);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bai2";
            this.Text = "Bai2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_mail;
        private Label lb_pass;
        private TextBox txt_password;
        private TextBox txt_email;
        private Button btn_login;
        private Label lb_total;
        private Label lb_recent;
        private Label lb_show_total;
        private Label lb_show_recent;
        private CheckBox cb_show_pass;
        private DataGridView dataGridView1;
    }
}