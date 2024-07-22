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

namespace BTVN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LogState()      // khởi tạo trạng thái ban đầu cho nút login/ logout
        {
            btnLogin.Enabled = true;
            btnLogout.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)    
        {
            if (listBox1.SelectedIndex != -1)   // nếu giá trị trong listbox được chọn 
            {
                if (listBox1.SelectedIndex == 0)
                {
                    string filename = "letter1.txt";
                    StreamReader sr = new StreamReader(filename);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
                else if (listBox1.SelectedIndex == 1)
                {
                    string filename = "letter2.txt";
                    StreamReader sr = new StreamReader(filename);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    string filename = "letter3.txt";
                    StreamReader sr = new StreamReader(filename);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
                MessageBox.Show("Đã đăng nhập thành công !", "Thông báo !");
                btnLogin.Enabled = false;       // nếu đăng nhập thành công thì nút Login bị inactive
                btnLogout.Enabled = true;       // nút Logout được active
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null)
            {
                richTextBox1.Text = string.Empty;   
                MessageBox.Show("Đã đăng xuất thành công !", "Thông báo !");
                btnLogout.Enabled = false;     // nếu đăng xuất thành công thì nút Logout bị inactive
                btnLogin.Enabled = true;       // nút Login được active trở lại
            }
        }
    }
}
