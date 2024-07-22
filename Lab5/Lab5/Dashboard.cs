using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            Form form1 = new Bai1();
            form1.Show();
        }

        private void btnBai02_Click(object sender, EventArgs e)
        {
            Form form2 = new Bai2();
            form2.Show();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {
            Form form3 = new Bai3();
            form3.Show();
        }

        private void btnBai04_Click(object sender, EventArgs e)
        {
            Form form4 = new Bai4();
            form4.Show();
        }

        private void btnBai05_Click(object sender, EventArgs e)
        {
            Form form5 = new Bai5();
            form5.Show();
        }

        private void btnBai06_Click(object sender, EventArgs e)
        {
            Form form6 = new Bai6();
            form6.Show();
        }
    }
}
