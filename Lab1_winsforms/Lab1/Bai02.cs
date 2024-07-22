using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txbSo1.Text);
            double b = double.Parse(txbSo2.Text); 
            double c = double.Parse(txbSo3.Text);
            double kqMin = Math.Min(Math.Min(a, b), c);
            double kqMax = Math.Max(Math.Max(a,b), c);
            txbSoMin.Text = kqMin.ToString();
            txbSoMax.Text = kqMax.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txbSo1.Text = string.Empty;
            txbSo2.Text = string.Empty;
            txbSo3.Text = string.Empty;
            txbSoMin.Text = string.Empty;
            txbSoMax.Text = string.Empty;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
