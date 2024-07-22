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
    public partial class Bai08 : Form
    {
        public Bai08()
        {
            InitializeComponent();
            MA_MacDinh();
            dsMA_MacDinh();
        }

        private void Bai08_Load(object sender, EventArgs e)
        {

        }

        private List<string> dsMA = new List<string>();
        private void MA_MacDinh()
        {
            dsMA.Add("Cơm gà xối mỡ");
            dsMA.Add("Bún bò");
            dsMA.Add("Phở");
        }

        private void dsMA_MacDinh()
        {
            foreach (string s in dsMA)
            {
                txbListMA.Text += s.ToString() + "\r\n";
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string MA_moi = txbNhapMAmoi.Text; 
            dsMA.Add(MA_moi);
            txbListMA.Text = string.Empty;
            dsMA_MacDinh();         // cap nhat lai danh sach mon an mac dinh
            txbNhapMAmoi.Text = string.Empty;
            
        }

        private void btnTimMA_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int index = rand.Next(dsMA.Count);
            string MA_homnay = dsMA[index];
            txbKetqua.Text = MA_homnay.ToString();   
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txbListMA.Text = string.Empty;
            txbKetqua.Text = string.Empty;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
