using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUDPServer_Click(object sender, EventArgs e)
        {
            Form form2 = new UDPServer();
            form2.Show();
        }

        private void btnUDPClient_Click(object sender, EventArgs e)
        {
            Form form3 = new UDPClient();
            form3.Show();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }
    }
}
