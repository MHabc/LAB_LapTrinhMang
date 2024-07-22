namespace Lab2
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
            this.txtFileContent = new System.Windows.Forms.RichTextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lbWriteName = new System.Windows.Forms.Label();
            this.lbWriteID = new System.Windows.Forms.Label();
            this.lbWriteCourse1 = new System.Windows.Forms.Label();
            this.lbWritePhone = new System.Windows.Forms.Label();
            this.lbWriteCourse2 = new System.Windows.Forms.Label();
            this.lbWriteCourse3 = new System.Windows.Forms.Label();
            this.lbReadName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtWriteName = new System.Windows.Forms.TextBox();
            this.txtWriteCourse3 = new System.Windows.Forms.TextBox();
            this.txtReadID = new System.Windows.Forms.TextBox();
            this.txtReadName = new System.Windows.Forms.TextBox();
            this.txtWriteID = new System.Windows.Forms.TextBox();
            this.txtWritePhone = new System.Windows.Forms.TextBox();
            this.txtWriteCourse1 = new System.Windows.Forms.TextBox();
            this.txtWriteCourse2 = new System.Windows.Forms.TextBox();
            this.txtReadCourse3 = new System.Windows.Forms.TextBox();
            this.txtReadCourse2 = new System.Windows.Forms.TextBox();
            this.txtReadCourse1 = new System.Windows.Forms.TextBox();
            this.txtReadPhone = new System.Windows.Forms.TextBox();
            this.lbReadCourse3 = new System.Windows.Forms.Label();
            this.lbReadCourse2 = new System.Windows.Forms.Label();
            this.lbReadCourse1 = new System.Windows.Forms.Label();
            this.lbReadPhone = new System.Windows.Forms.Label();
            this.lbReadID = new System.Windows.Forms.Label();
            this.lbAverage = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbPageNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFileContent
            // 
            this.txtFileContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileContent.Location = new System.Drawing.Point(451, 10);
            this.txtFileContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.Size = new System.Drawing.Size(462, 735);
            this.txtFileContent.TabIndex = 0;
            this.txtFileContent.Text = "";
            // 
            // btnWrite
            // 
            this.btnWrite.AutoSize = true;
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Location = new System.Drawing.Point(11, 21);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(416, 62);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "Write to an output file";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.AutoSize = true;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(917, 21);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(436, 62);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read from an input file";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lbWriteName
            // 
            this.lbWriteName.AutoSize = true;
            this.lbWriteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWriteName.Location = new System.Drawing.Point(338, 112);
            this.lbWriteName.Name = "lbWriteName";
            this.lbWriteName.Size = new System.Drawing.Size(86, 31);
            this.lbWriteName.TabIndex = 3;
            this.lbWriteName.Text = "Name";
            // 
            // lbWriteID
            // 
            this.lbWriteID.AutoSize = true;
            this.lbWriteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWriteID.Location = new System.Drawing.Point(384, 201);
            this.lbWriteID.Name = "lbWriteID";
            this.lbWriteID.Size = new System.Drawing.Size(42, 31);
            this.lbWriteID.TabIndex = 4;
            this.lbWriteID.Text = "ID";
            // 
            // lbWriteCourse1
            // 
            this.lbWriteCourse1.AutoSize = true;
            this.lbWriteCourse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWriteCourse1.Location = new System.Drawing.Point(298, 375);
            this.lbWriteCourse1.Name = "lbWriteCourse1";
            this.lbWriteCourse1.Size = new System.Drawing.Size(124, 31);
            this.lbWriteCourse1.TabIndex = 6;
            this.lbWriteCourse1.Text = "Course 1";
            // 
            // lbWritePhone
            // 
            this.lbWritePhone.AutoSize = true;
            this.lbWritePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWritePhone.Location = new System.Drawing.Point(332, 285);
            this.lbWritePhone.Name = "lbWritePhone";
            this.lbWritePhone.Size = new System.Drawing.Size(92, 31);
            this.lbWritePhone.TabIndex = 5;
            this.lbWritePhone.Text = "Phone";
            // 
            // lbWriteCourse2
            // 
            this.lbWriteCourse2.AutoSize = true;
            this.lbWriteCourse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWriteCourse2.Location = new System.Drawing.Point(299, 461);
            this.lbWriteCourse2.Name = "lbWriteCourse2";
            this.lbWriteCourse2.Size = new System.Drawing.Size(124, 31);
            this.lbWriteCourse2.TabIndex = 7;
            this.lbWriteCourse2.Text = "Course 2";
            // 
            // lbWriteCourse3
            // 
            this.lbWriteCourse3.AutoSize = true;
            this.lbWriteCourse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWriteCourse3.Location = new System.Drawing.Point(299, 550);
            this.lbWriteCourse3.Name = "lbWriteCourse3";
            this.lbWriteCourse3.Size = new System.Drawing.Size(124, 31);
            this.lbWriteCourse3.TabIndex = 8;
            this.lbWriteCourse3.Text = "Course 3";
            // 
            // lbReadName
            // 
            this.lbReadName.AutoSize = true;
            this.lbReadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReadName.Location = new System.Drawing.Point(1264, 112);
            this.lbReadName.Name = "lbReadName";
            this.lbReadName.Size = new System.Drawing.Size(86, 31);
            this.lbReadName.TabIndex = 9;
            this.lbReadName.Text = "Name";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(11, 659);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(416, 73);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add to list";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtWriteName
            // 
            this.txtWriteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteName.Location = new System.Drawing.Point(11, 110);
            this.txtWriteName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriteName.Name = "txtWriteName";
            this.txtWriteName.Size = new System.Drawing.Size(283, 38);
            this.txtWriteName.TabIndex = 11;
            // 
            // txtWriteCourse3
            // 
            this.txtWriteCourse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteCourse3.Location = new System.Drawing.Point(11, 547);
            this.txtWriteCourse3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriteCourse3.Name = "txtWriteCourse3";
            this.txtWriteCourse3.Size = new System.Drawing.Size(283, 38);
            this.txtWriteCourse3.TabIndex = 12;
            // 
            // txtReadID
            // 
            this.txtReadID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadID.Location = new System.Drawing.Point(917, 198);
            this.txtReadID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReadID.Name = "txtReadID";
            this.txtReadID.Size = new System.Drawing.Size(283, 38);
            this.txtReadID.TabIndex = 13;
            // 
            // txtReadName
            // 
            this.txtReadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadName.Location = new System.Drawing.Point(917, 110);
            this.txtReadName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReadName.Name = "txtReadName";
            this.txtReadName.Size = new System.Drawing.Size(283, 38);
            this.txtReadName.TabIndex = 14;
            // 
            // txtWriteID
            // 
            this.txtWriteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteID.Location = new System.Drawing.Point(11, 198);
            this.txtWriteID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriteID.Name = "txtWriteID";
            this.txtWriteID.Size = new System.Drawing.Size(283, 38);
            this.txtWriteID.TabIndex = 15;
            // 
            // txtWritePhone
            // 
            this.txtWritePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWritePhone.Location = new System.Drawing.Point(11, 282);
            this.txtWritePhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWritePhone.Name = "txtWritePhone";
            this.txtWritePhone.Size = new System.Drawing.Size(283, 38);
            this.txtWritePhone.TabIndex = 16;
            // 
            // txtWriteCourse1
            // 
            this.txtWriteCourse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteCourse1.Location = new System.Drawing.Point(11, 370);
            this.txtWriteCourse1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriteCourse1.Name = "txtWriteCourse1";
            this.txtWriteCourse1.Size = new System.Drawing.Size(283, 38);
            this.txtWriteCourse1.TabIndex = 17;
            // 
            // txtWriteCourse2
            // 
            this.txtWriteCourse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteCourse2.Location = new System.Drawing.Point(11, 458);
            this.txtWriteCourse2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriteCourse2.Name = "txtWriteCourse2";
            this.txtWriteCourse2.Size = new System.Drawing.Size(283, 38);
            this.txtWriteCourse2.TabIndex = 18;
            // 
            // txtReadCourse3
            // 
            this.txtReadCourse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadCourse3.Location = new System.Drawing.Point(917, 547);
            this.txtReadCourse3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReadCourse3.Name = "txtReadCourse3";
            this.txtReadCourse3.Size = new System.Drawing.Size(283, 38);
            this.txtReadCourse3.TabIndex = 19;
            // 
            // txtReadCourse2
            // 
            this.txtReadCourse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadCourse2.Location = new System.Drawing.Point(917, 458);
            this.txtReadCourse2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReadCourse2.Name = "txtReadCourse2";
            this.txtReadCourse2.Size = new System.Drawing.Size(283, 38);
            this.txtReadCourse2.TabIndex = 20;
            // 
            // txtReadCourse1
            // 
            this.txtReadCourse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadCourse1.Location = new System.Drawing.Point(917, 370);
            this.txtReadCourse1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReadCourse1.Name = "txtReadCourse1";
            this.txtReadCourse1.Size = new System.Drawing.Size(283, 38);
            this.txtReadCourse1.TabIndex = 21;
            // 
            // txtReadPhone
            // 
            this.txtReadPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadPhone.Location = new System.Drawing.Point(917, 282);
            this.txtReadPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReadPhone.Name = "txtReadPhone";
            this.txtReadPhone.Size = new System.Drawing.Size(283, 38);
            this.txtReadPhone.TabIndex = 22;
            // 
            // lbReadCourse3
            // 
            this.lbReadCourse3.AutoSize = true;
            this.lbReadCourse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReadCourse3.Location = new System.Drawing.Point(1225, 550);
            this.lbReadCourse3.Name = "lbReadCourse3";
            this.lbReadCourse3.Size = new System.Drawing.Size(124, 31);
            this.lbReadCourse3.TabIndex = 27;
            this.lbReadCourse3.Text = "Course 3";
            // 
            // lbReadCourse2
            // 
            this.lbReadCourse2.AutoSize = true;
            this.lbReadCourse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReadCourse2.Location = new System.Drawing.Point(1225, 461);
            this.lbReadCourse2.Name = "lbReadCourse2";
            this.lbReadCourse2.Size = new System.Drawing.Size(124, 31);
            this.lbReadCourse2.TabIndex = 26;
            this.lbReadCourse2.Text = "Course 2";
            // 
            // lbReadCourse1
            // 
            this.lbReadCourse1.AutoSize = true;
            this.lbReadCourse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReadCourse1.Location = new System.Drawing.Point(1224, 375);
            this.lbReadCourse1.Name = "lbReadCourse1";
            this.lbReadCourse1.Size = new System.Drawing.Size(124, 31);
            this.lbReadCourse1.TabIndex = 25;
            this.lbReadCourse1.Text = "Course 1";
            // 
            // lbReadPhone
            // 
            this.lbReadPhone.AutoSize = true;
            this.lbReadPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReadPhone.Location = new System.Drawing.Point(1259, 285);
            this.lbReadPhone.Name = "lbReadPhone";
            this.lbReadPhone.Size = new System.Drawing.Size(92, 31);
            this.lbReadPhone.TabIndex = 24;
            this.lbReadPhone.Text = "Phone";
            // 
            // lbReadID
            // 
            this.lbReadID.AutoSize = true;
            this.lbReadID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReadID.Location = new System.Drawing.Point(1310, 201);
            this.lbReadID.Name = "lbReadID";
            this.lbReadID.Size = new System.Drawing.Size(42, 31);
            this.lbReadID.TabIndex = 23;
            this.lbReadID.Text = "ID";
            // 
            // lbAverage
            // 
            this.lbAverage.AutoSize = true;
            this.lbAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAverage.Location = new System.Drawing.Point(1233, 639);
            this.lbAverage.Name = "lbAverage";
            this.lbAverage.Size = new System.Drawing.Size(115, 31);
            this.lbAverage.TabIndex = 28;
            this.lbAverage.Text = "Average";
            // 
            // txtAverage
            // 
            this.txtAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAverage.Location = new System.Drawing.Point(917, 637);
            this.txtAverage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(283, 38);
            this.txtAverage.TabIndex = 29;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(940, 694);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 41);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1223, 694);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(116, 41);
            this.btnNext.TabIndex = 31;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbPageNumber
            // 
            this.lbPageNumber.AutoSize = true;
            this.lbPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPageNumber.Location = new System.Drawing.Point(1123, 702);
            this.lbPageNumber.Name = "lbPageNumber";
            this.lbPageNumber.Size = new System.Drawing.Size(29, 31);
            this.lbPageNumber.TabIndex = 32;
            this.lbPageNumber.Text = "0";
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 754);
            this.Controls.Add(this.lbPageNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.lbAverage);
            this.Controls.Add(this.lbReadCourse3);
            this.Controls.Add(this.lbReadCourse2);
            this.Controls.Add(this.lbReadCourse1);
            this.Controls.Add(this.lbReadPhone);
            this.Controls.Add(this.lbReadID);
            this.Controls.Add(this.txtReadPhone);
            this.Controls.Add(this.txtReadCourse1);
            this.Controls.Add(this.txtReadCourse2);
            this.Controls.Add(this.txtReadCourse3);
            this.Controls.Add(this.txtWriteCourse2);
            this.Controls.Add(this.txtWriteCourse1);
            this.Controls.Add(this.txtWritePhone);
            this.Controls.Add(this.txtWriteID);
            this.Controls.Add(this.txtReadName);
            this.Controls.Add(this.txtReadID);
            this.Controls.Add(this.txtWriteCourse3);
            this.Controls.Add(this.txtWriteName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbReadName);
            this.Controls.Add(this.lbWriteCourse3);
            this.Controls.Add(this.lbWriteCourse2);
            this.Controls.Add(this.lbWriteCourse1);
            this.Controls.Add(this.lbWritePhone);
            this.Controls.Add(this.lbWriteID);
            this.Controls.Add(this.lbWriteName);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtFileContent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bai04";
            this.Text = "Bai4";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtFileContent;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lbWriteName;
        private System.Windows.Forms.Label lbWriteID;
        private System.Windows.Forms.Label lbWriteCourse1;
        private System.Windows.Forms.Label lbWritePhone;
        private System.Windows.Forms.Label lbWriteCourse2;
        private System.Windows.Forms.Label lbWriteCourse3;
        private System.Windows.Forms.Label lbReadName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtWriteName;
        private System.Windows.Forms.TextBox txtWriteCourse3;
        private System.Windows.Forms.TextBox txtReadID;
        private System.Windows.Forms.TextBox txtReadName;
        private System.Windows.Forms.TextBox txtWriteID;
        private System.Windows.Forms.TextBox txtWritePhone;
        private System.Windows.Forms.TextBox txtWriteCourse1;
        private System.Windows.Forms.TextBox txtWriteCourse2;
        private System.Windows.Forms.TextBox txtReadCourse3;
        private System.Windows.Forms.TextBox txtReadCourse2;
        private System.Windows.Forms.TextBox txtReadCourse1;
        private System.Windows.Forms.TextBox txtReadPhone;
        private System.Windows.Forms.Label lbReadCourse3;
        private System.Windows.Forms.Label lbReadCourse2;
        private System.Windows.Forms.Label lbReadCourse1;
        private System.Windows.Forms.Label lbReadPhone;
        private System.Windows.Forms.Label lbReadID;
        private System.Windows.Forms.Label lbAverage;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbPageNumber;
    }
}