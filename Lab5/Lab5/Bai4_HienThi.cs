using Microsoft.Web.WebView2.WinForms;
using System;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Bai4_HienThi : Form
    {
        public Bai4_HienThi()
        {
            InitializeComponent();
        }

        public void Hienthiweb(string s)
        {
            string url = s;
            webView21.Source = new Uri(url);
        }
    }
}
