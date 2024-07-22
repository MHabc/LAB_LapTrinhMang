using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Bai3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenTCPServer_Click(object sender, EventArgs e)
        {
            Form form2 = new TCPServer();
            form2.Show();
        }

        private void btnOpenNewTCPClient_Click(object sender, EventArgs e)
        {
            Form form3 = new TCPClient();
            form3.Show();
        }
    }
}
