﻿using System;
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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            Bai5_Client client = new Bai5_Client();
            client.Show();
        }

        private void serverBtn_Click(object sender, EventArgs e)
        {
            Bai5_Server server = new Bai5_Server();
            server.Show();
        }
    }
}