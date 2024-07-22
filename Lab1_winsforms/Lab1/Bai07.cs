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
    public partial class Bai07 : Form
    {
        public Bai07()
        {
            InitializeComponent();
        }

        private void Bai07_Load(object sender, EventArgs e)
        {

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            string a = txbNhapSV.Text.Trim();
            string[] arr = a.Split(',');
            if (Check_DieuKien(a) == false)
            {
                MessageBox.Show("Đã nhập sai format\nVui lòng nhập lại !", "Không hợp lệ !");
                return;
            }
            else
            {
                MessageBox.Show("Đã nhập đúng format", "Hợp lệ !");
            }

            // Xuat ra ho va ten sinh vien
            string name = arr[0];                             
            txbKetqua.Text = "- Họ và tên: " + name + "\r\n";
            txbKetqua.Text += "- ";

            // Xuat ra diem cac mon
            double[] scores = arr.Skip(1).Select(double.Parse).ToArray();   
            for (int i = 0; i < scores.Length; i++)
            {
                txbKetqua.Text += "Môn " + (i + 1) + ": " + (scores[i]) + "   "  ;
            }
            txbKetqua.Text += "\r\n";

            // Xuat ra diem trung binh
            double DTB = scores.Average();
            txbKetqua.Text += "- Điểm trung bình: " + DTB + "\r\n";

            // Xuat ra diem cao nhat, thap nhap
            double diemMax = scores.Max();
            double diemMin = scores.Min();
            txbKetqua.Text += "- Điểm cao nhất: " + diemMax + "\r\n";
            txbKetqua.Text += "- Điểm thấp nhất: " + diemMin + "\r\n";

            // Xuat ra so mon dau, khong dau
            int passedMon = scores.Count(score => score >= 5);
            int failedMon = scores.Count(score => score < 5);
            txbKetqua.Text += "- Số môn đậu: " + passedMon + "\r\n";
            txbKetqua.Text += "- Số môn không đậu: " + failedMon + "\r\n";

            // Xep loai sinh vien
            if (DTB >= 8.5 && scores.All(score => score >= 6.5))
            {
                txbKetqua.Text += "- Xếp loại: Giỏi";
            }
            else if (DTB >= 6.5 && scores.All(score => score >= 5))
            {
                txbKetqua.Text += "- Xếp loại: Khá";
            }
            else if (DTB >= 5 && scores.All(score => score >= 3.5))
            {
                txbKetqua.Text += "- Xếp loại: TB";
            }
            else if (DTB >= 3.5 && scores.All(score => score >= 2))
            {
                txbKetqua.Text += "- Xếp loại: Yếu";
            }
            else
            {
                txbKetqua.Text += "- Xếp loại: Kém";
            }
        }
        
        private bool Check_DieuKien(string chuoi)
        {
            string[] arr = chuoi.Split(',');
            if (arr.Length < 2)     //phai co tu 2 phan tu tro len (it nhat la 1 ten va 1 diem)
            {
                return false;
            }

            bool contain_letter = false;  // kiem tra phan tu dau tien co phai la chu cai hay khong
            foreach (char c in arr[0])
            {
                if (char.IsLetter(c))
                {
                    contain_letter = true;
                    break;
                }
            }
            if (!contain_letter)
            {
                return false;
            }

            for (int i = 1; i < arr.Length; i++)    // kiem tra cac phan tu con lai co la so thuc khong
            {
                if (!double.TryParse(arr[i], out _))
                {
                    return false;
                }
            }

            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txbNhapSV.Text = string.Empty;
            txbKetqua.Text = string.Empty;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
