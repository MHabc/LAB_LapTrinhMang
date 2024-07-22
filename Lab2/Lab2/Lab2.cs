using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void Lab2_Load(object sender, EventArgs e)
        {

        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            Form form2 = new Bai01();
            form2.Show();
        }

        private void btnBai02_Click(object sender, EventArgs e)
        {
            Form form3 = new Bai02();
            form3.Show();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {
            Form form4 = new Bai03();
            form4.Show();
        }

        private void btnBai04_Click(object sender, EventArgs e)
        {
            Form form5 = new Bai04();
            form5.Show();
        }

        private void btnBai05_Click(object sender, EventArgs e)
        {
            Form form6 = new Bai05();
            form6.Show();
        }

        private void btnBai06_Click(object sender, EventArgs e)
        {
            Form form7 = new Bai06();
            form7.Show();
        }
        private void btnBai07_Click(object sender, EventArgs e)
        {
            Form form8 = new Bai07();
            form8.Show();
        }

    }
}
