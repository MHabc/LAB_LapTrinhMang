﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;


namespace Lab5
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void cb_show_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_show_pass.Checked)
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            var client = new ImapClient();
            client.Connect("imap.gmail.com", 993, true);
            client.Authenticate(txt_email.Text, txt_password.Text);
            dataGridView1.Columns.Add("Subject", "Subject");
            dataGridView1.Columns.Add("From", "From");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns["Subject"].ReadOnly = true;
            dataGridView1.Columns["From"].ReadOnly = true;
            dataGridView1.Columns["Date"].ReadOnly = true;
            int limit = 0;
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            for (int i = inbox.Count - 1; i > 0; i--)
            {
                limit++;
                var message = inbox.GetMessage(i);
                string subject = message.Subject;
                string from = message.From.ToString();
                DateTime date = message.Date.DateTime;
                dataGridView1.Rows.Add(subject, from, date);
                if (limit == 5)
                {
                    break;
                }
            }
        }
    }
}