using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void Bai01_Load(object sender, EventArgs e)
        {

        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("input1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            richTextBox1.Text = sr.ReadToEnd();
            fs.Close();
            MessageBox.Show("Đọc dữ liệu từ file input1.txt !", "Thông báo");
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("output1.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(richTextBox1.Text.ToUpper());
            sw.Flush();
            fs.Close();
            MessageBox.Show("Đã ghi dữ liệu vào file output1.txt !", "Thông báo");
        }
    }
}
