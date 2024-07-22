namespace Lab5
{
    partial class Bai5
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
            this.serverBtn = new System.Windows.Forms.Button();
            this.clientBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverBtn
            // 
            this.serverBtn.BackColor = System.Drawing.Color.LightCoral;
            this.serverBtn.Location = new System.Drawing.Point(158, 190);
            this.serverBtn.Name = "serverBtn";
            this.serverBtn.Size = new System.Drawing.Size(155, 52);
            this.serverBtn.TabIndex = 0;
            this.serverBtn.Text = "SERVER";
            this.serverBtn.UseVisualStyleBackColor = false;
            this.serverBtn.Click += new System.EventHandler(this.serverBtn_Click);
            // 
            // clientBtn
            // 
            this.clientBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clientBtn.Location = new System.Drawing.Point(464, 190);
            this.clientBtn.Name = "clientBtn";
            this.clientBtn.Size = new System.Drawing.Size(155, 52);
            this.clientBtn.TabIndex = 1;
            this.clientBtn.Text = "CLIENT";
            this.clientBtn.UseVisualStyleBackColor = false;
            this.clientBtn.Click += new System.EventHandler(this.clientBtn_Click);
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clientBtn);
            this.Controls.Add(this.serverBtn);
            this.Name = "Bai5";
            this.Text = "Bài 5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button serverBtn;
        private System.Windows.Forms.Button clientBtn;
    }
}