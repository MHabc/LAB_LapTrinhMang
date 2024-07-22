namespace Lab2
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
            this.btnReadFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbFileName = new System.Windows.Forms.TextBox();
            this.txbSize = new System.Windows.Forms.TextBox();
            this.txbURL = new System.Windows.Forms.TextBox();
            this.txbLineCount = new System.Windows.Forms.TextBox();
            this.txbWordsCount = new System.Windows.Forms.TextBox();
            this.txbCharCount = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnReadFile
            // 
            this.btnReadFile.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFile.Location = new System.Drawing.Point(12, 33);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(237, 37);
            this.btnReadFile.TabIndex = 0;
            this.btnReadFile.Text = "READ FROM FILE";
            this.btnReadFile.UseVisualStyleBackColor = false;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(269, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(503, 400);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "File name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Line count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Words count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Character count";
            // 
            // txbFileName
            // 
            this.txbFileName.Location = new System.Drawing.Point(115, 96);
            this.txbFileName.Name = "txbFileName";
            this.txbFileName.ReadOnly = true;
            this.txbFileName.Size = new System.Drawing.Size(134, 22);
            this.txbFileName.TabIndex = 8;
            // 
            // txbSize
            // 
            this.txbSize.Location = new System.Drawing.Point(115, 140);
            this.txbSize.Name = "txbSize";
            this.txbSize.ReadOnly = true;
            this.txbSize.Size = new System.Drawing.Size(134, 22);
            this.txbSize.TabIndex = 9;
            // 
            // txbURL
            // 
            this.txbURL.Location = new System.Drawing.Point(115, 189);
            this.txbURL.Name = "txbURL";
            this.txbURL.ReadOnly = true;
            this.txbURL.Size = new System.Drawing.Size(134, 22);
            this.txbURL.TabIndex = 10;
            // 
            // txbLineCount
            // 
            this.txbLineCount.Location = new System.Drawing.Point(115, 239);
            this.txbLineCount.Name = "txbLineCount";
            this.txbLineCount.ReadOnly = true;
            this.txbLineCount.Size = new System.Drawing.Size(134, 22);
            this.txbLineCount.TabIndex = 11;
            // 
            // txbWordsCount
            // 
            this.txbWordsCount.Location = new System.Drawing.Point(115, 289);
            this.txbWordsCount.Name = "txbWordsCount";
            this.txbWordsCount.ReadOnly = true;
            this.txbWordsCount.Size = new System.Drawing.Size(134, 22);
            this.txbWordsCount.TabIndex = 12;
            // 
            // txbCharCount
            // 
            this.txbCharCount.Location = new System.Drawing.Point(115, 337);
            this.txbCharCount.Name = "txbCharCount";
            this.txbCharCount.ReadOnly = true;
            this.txbCharCount.Size = new System.Drawing.Size(134, 22);
            this.txbCharCount.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 389);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(237, 37);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txbCharCount);
            this.Controls.Add(this.txbWordsCount);
            this.Controls.Add(this.txbLineCount);
            this.Controls.Add(this.txbURL);
            this.Controls.Add(this.txbSize);
            this.Controls.Add(this.txbFileName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnReadFile);
            this.Name = "Bai02";
            this.Text = "Bai02";
            this.Load += new System.EventHandler(this.Bai02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbFileName;
        private System.Windows.Forms.TextBox txbSize;
        private System.Windows.Forms.TextBox txbURL;
        private System.Windows.Forms.TextBox txbLineCount;
        private System.Windows.Forms.TextBox txbWordsCount;
        private System.Windows.Forms.TextBox txbCharCount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}