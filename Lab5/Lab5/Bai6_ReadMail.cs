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
    public partial class Bai6_ReadMail : Form
    {
        public Bai6_ReadMail(string from, string to, string subject, string emailContent)
        {
            InitializeComponent();
            lb_From.Text = from;
            lb_To.Text = to;
            lb_Subject.Text = subject;
            richTextBox1.Text = emailContent;
        }
    }
}