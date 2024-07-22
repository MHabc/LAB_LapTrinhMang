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
    public partial class Bai03_1 : Form
    {
        public Bai03_1()
        {
            InitializeComponent();
        }

        private void Bai3_1_Load(object sender, EventArgs e)
        {

        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            long number;
            if (long.TryParse(txbNhap.Text, out number))
            {
                if (number > 999999999999)
                {
                    MessageBox.Show("Chỉ được nhập tối đa 12 chữ số !", "Lỗi !");
                    return;
                }
            }

            string kq = DocSo(number); 
            if (number < 0)
            {
                kq = "Âm " + DocSo(-number);
            }
            txbKetqua.Text = kq;
        }

        private string DocSo(long number)
        {
            if (number == 0)
                return "Không";

            string words = "";
            string[] nghin = {" ","Nghìn ", "Triệu ", "Tỷ " };

            int i = 0;
            while (number > 0)
            {
                if (number % 1000 != 0)
                {
                    words = DocSoDuoi1000(number % 1000) + " " + nghin[i] + words;
                }
                number /= 1000;
                i++;
            }
            return words.Trim();
        }

        private string DocSoDuoi1000(long number)
        {
            string words = "";

            if (number >= 100)
            {
                words += DocSoDuoi20(number / 100) + "Trăm ";
                number %= 100;
            }

            if (number >= 20)
            {
                words += DocSoDuoi100(number / 10);
                number %= 10;
            }

            if (number > 0)
            {
                words += DocSoDuoi20(number);
            }

            return words.Trim();
        }

        private string DocSoDuoi100(long number)
        {
            switch (number)
            {
                case 2: return "Hai Mươi ";
                case 3: return "Ba Mươi ";
                case 4: return "Bốn Mươi ";
                case 5: return "Năm Mươi ";
                case 6: return "Sáu Mươi ";
                case 7: return "Bảy Mươi ";
                case 8: return "Tám Mươi ";
                case 9: return "Chín Mươi ";
            };
            return "";
        }  

        private string DocSoDuoi20(long number)
        {
            switch (number)
            {
                case 1: return "Một ";
                case 2: return "Hai ";
                case 3: return "Ba ";
                case 4: return "Bốn ";
                case 5: return "Năm ";
                case 6: return "Sáu ";
                case 7: return "Bảy ";
                case 8: return "Tám ";
                case 9: return "Chín ";
                case 10: return "Mười ";
                case 11: return "Mười Một";
                case 12: return "Mười Hai ";
                case 13: return "Mười Ba ";
                case 14: return "Mười Bốn";
                case 15: return "Mười Lăm ";
                case 16: return "Mười Sáu ";
                case 17: return "Mười Bảy ";
                case 18: return "Mười Tám ";
                case 19: return "Mười Chín ";
            };
            return "";
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
