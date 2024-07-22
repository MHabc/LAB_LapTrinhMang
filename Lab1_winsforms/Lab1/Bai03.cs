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
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }
        private void Bai03_Load(object sender, EventArgs e)
        {

        }
        private void btnDoc_Click(object sender, EventArgs e)
        {
            int k = int.Parse(txbNhap.Text);
            switch (k)
            {
                case 0:
                    txbKetqua.Text = "Không";
                    break;
                case 1:
                    txbKetqua.Text = "Một";
                    break;
                case 2:
                    txbKetqua.Text = "Hai";
                    break;
                case 3:
                    txbKetqua.Text = "Ba";
                    break;
                case 4:
                    txbKetqua.Text = "Bốn";
                    break;
                case 5:
                    txbKetqua.Text = "Năm";
                    break;
                case 6:
                    txbKetqua.Text = "Sáu";
                    break;
                case 7:
                    txbKetqua.Text = "Bảy";
                    break;
                case 8:
                    txbKetqua.Text = "Tám";
                    break;
                case 9:
                    txbKetqua.Text = "Chín";
                    break;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txbNhap.Text = string.Empty;
            txbKetqua.Text = string.Empty;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
