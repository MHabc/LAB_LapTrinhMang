using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Form form1 = new Bai1();
            form1.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Form form2 = new Bai2();
            form2.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Form form3 = new Bai3();
            form3.Show();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            Form form4 = new Bai4_Main();
            form4.Show();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            Form form5 = new Bai5();
            form5.Show();
        }

        private void btnBai6_Click(object sender, EventArgs e)
        {
            Form form6 = new Bai6();
            form6.Show();
        }

        private void btnBai7_Click(object sender, EventArgs e)
        {
            Form form7 = new Bai7();
            form7.Show();
        }
    }
}
