using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Bai4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void Bai4_Load(object sender, EventArgs e)
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
