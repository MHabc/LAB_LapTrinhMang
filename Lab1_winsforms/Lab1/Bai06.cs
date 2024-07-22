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
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
        }

        private void Bai06_Load(object sender, EventArgs e)
        {

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int day = int.Parse(txbNgay.Text);
            int month = int.Parse(txbThang.Text);
            int year = int.Parse(txbNam.Text);
            switch (month)
            {
                case 1:
                    if (day <= 20)
                    {
                        txbKetqua.Text = "22/12 – 20/01: cung Ma Kết";
                        break;
                    }
                    else
                    {
                        txbKetqua.Text = "21/01 – 19/02: cung Bảo Bình";
                        break;
                    }
                case 2:
                    if (day <= 19)
                    {
                        txbKetqua.Text = "21/01 – 19/02: cung Bảo Bình";
                        break;
                    }
                    else
                    {
                        txbKetqua.Text = "20/02 – 20/03: cung Song Ngư";
                        break;
                    }
                case 3:
                    if (day <= 20)
                    {
                        txbKetqua.Text = "20/02 – 20/03: cung Song Ngư";
                        break;
                    }
                    else
                    {
                        txbKetqua.Text = "21/03 – 20/04: cung Bạch Dương";
                        break;
                    }
                case 4:
                    if (day <= 20)
                    {
                        txbKetqua.Text = "21/03 – 20/04: cung Bạch Dương";
                        break;
                    }
                    else
                    {
                        txbKetqua.Text = "21/04 – 21/05: cung Kim Ngưu";
                        break;
                    }
                case 5:
                    if (day <= 21)
                    {
                        txbKetqua.Text = "21/04 – 21/05: cung Kim Ngưu";
                        break;
                    }
                    else
                    {
                        txbKetqua.Text = "22/05 – 21/06: cung Song Tử";
                        break;
                    }
                case 6:
                    if (day <= 21)
                    {
                        txbKetqua.Text = "22/05 – 21/06: cung Song Tử";
                        break;
                    }
                    else
                    {
                        txbKetqua.Text = "22/06 – 22/07: cung Cự Giải";
                        break;
                    }
                case 7:
                    if (day <= 22)
                    {
                        txbKetqua.Text = "22/06 – 22/07: cung Cự Giải";
                        break;
                    }
                    else
                    {
                        txbKetqua.Text = "23/07 – 22/08: cung Sư Tử";
                        break;
                    }
                case 8:
                    if (day <= 22)
                    {
                        txbKetqua.Text = "23/07 – 22/08: cung Sư Tử";
                        break;
                    }
                    else
                    {
                        txbKetqua.Text = "23/08 – 23/09: cung Xử Nữ";
                        break;
                    }
                case 9:
                    if (day <= 23)
                    {
                        txbKetqua.Text = "23/08 – 23/09: cung Xử Nữ";
                        break;
                    }
                    else
                    {
                        txbKetqua.Text = "24/09 – 23/10: cung Thiên Bình";
                        break;
                    }
                case 10:
                    if (day <= 23)
                    {
                        txbKetqua.Text = "24/09 – 23/10: cung Thiên Bình";
                        break;
                    }
                    else
                    {
                        txbKetqua.Text = "24/10 – 22/11: cung Thần Nông";
                        break;
                    }
                case 11:
                    if (day <= 22)
                    {
                        txbKetqua.Text = "24/10 – 22/11: cung Thần Nông";
                        break;
                    }
                    else
                    {
                        txbKetqua.Text = "23/11 – 21/12: cung Nhân Mã";
                        break;
                    }
                case 12:
                    if (day <= 21)
                    {
                        txbKetqua.Text = "23/11 – 21/12: cung Nhân Mã";
                        break;
                    }
                    else
                    {
                        txbKetqua.Text = "22/12 – 20/01: cung Ma Kết";
                        break;
                    }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txbNgay.Text = string.Empty;
            txbThang.Text = string.Empty;
            txbNam.Text = string.Empty;
            txbKetqua.Text = string.Empty;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
