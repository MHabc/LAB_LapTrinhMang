using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Bai5
{
    public partial class Bai5 : Form
    {
        public Bai5()
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
