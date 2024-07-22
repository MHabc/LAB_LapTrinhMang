using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
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

        private void txbSoThu1_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool number = int.TryParse(txbSoThu1.Text, out txt);
            if (number == false && txbSoThu1.Text != "" && txbSoThu1.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                txbSoThu1.Text = string.Empty;
            }
        }

        private void txbSoThu2_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool number = int.TryParse(txbSoThu2.Text, out txt);
            if (number == false && txbSoThu2.Text != "" && txbSoThu2.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                txbSoThu2.Text = string.Empty;
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txbSoThu1.Text);
            int b = int.Parse(txbSoThu2.Text);
            int sum = a + b;
            txbKetqua.Text= sum.ToString();  
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txbSoThu1.Text = string.Empty;
            txbSoThu2.Text = string.Empty;
            txbKetqua.Text = string.Empty;
        }
    }
}
