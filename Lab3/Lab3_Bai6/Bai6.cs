using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Bai6
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void Bai5_Load(object sender, EventArgs e)
        {

        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Form form2 = new Server();
            form2.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Form form3 = new Client();
            form3.Show();
        }
    }
}
