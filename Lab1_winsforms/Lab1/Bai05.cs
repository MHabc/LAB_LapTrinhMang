using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        private void Bai05_Load(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int A = int.Parse(txbNhapA.Text);
            int B = int.Parse(txbNhapB.Text);
            if (comboBox1.SelectedIndex == 0)   // bang cuu chuong
            {
                int k = B - A;
                txbKetqua.Text = "Bảng cửu chương : B - A = " + k + "\r\n";
                for (int i = 1; i <= 10; i++)
                {
                    txbKetqua.Text += k + " x " + i + " = ";
                    txbKetqua.Text += (B*i - A*i).ToString() + "\r\n";
                }
            }
            else if (comboBox1.SelectedIndex == 1)    // tinh toan cac gia tri
            {
                if (A < B)
                {
                    MessageBox.Show("Không tính được (A-B)! vì A-B < 0");

                    txbKetqua.Text += "S = A^1 + A^2 + A^3 + A^4 + ... + A^B = ";
                    double S = 0;       
                    for (int i = 1; i <= B; i++)
                    {
                        S += Math.Pow(A, i);
                    }
                    txbKetqua.Text += S.ToString();
                }
                else
                {
                    txbKetqua.Text = "(A - B)! = ";
                    txbKetqua.Text += Factorial(A-B).ToString() + "\r\n";    

                    txbKetqua.Text += "S = A^1 + A^2 + A^3 + A^4 + ... + A^B = ";
                    double S = 0;      
                    for (int i = 1; i <= B; i++)
                    {
                        S += Math.Pow(A, i);
                    }
                    txbKetqua.Text += S.ToString();
                }
            }
        }

        private int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txbNhapA.Text = string.Empty;
            txbNhapB.Text = string.Empty;
            txbKetqua.Text= string.Empty;
            comboBox1.Text = string.Empty;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
