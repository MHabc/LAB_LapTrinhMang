using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void Bai02_Load(object sender, EventArgs e)
        {

        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)    // check xem người dùng đã chọn file hay chưa
            {
                StreamReader sw = new StreamReader(ofd.FileName);
                richTextBox1.Text = sw.ReadToEnd();     // hiển thị nội dung file

                txbFileName.Text = ofd.SafeFileName;    // tên file

                long fileSize = new FileInfo(ofd.FileName).Length;  // kích thước file
                txbSize.Text = fileSize.ToString() + " bytes";  

                txbURL.Text = ofd.FileName;     // đường dẫn URL

                long countLines = richTextBox1.Text.Split('\n').Length;     // đếm số dòng
                txbLineCount.Text = countLines.ToString();      

                long countWords = richTextBox1.Text.Split(new char[] { ' ', '\t', '\n', '\r' }).Length;     // đếm số từ
                txbWordsCount.Text = countWords.ToString();     

                long countChar = richTextBox1.Text.Length;      // đếm số ký tự
                txbCharCount.Text = countChar.ToString();       
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
