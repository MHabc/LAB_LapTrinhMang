using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4
{
    public partial class Bai4_DatVe : Form
    {
        public Bai4_DatVe()
        {
            InitializeComponent();
            this.Load += new EventHandler(Datve_Load);
        }

        public Dictionary<string, int> dsphim { get; set; }
        private string[] soghedachon;

        private void btnXuatVe_Click(object sender, EventArgs e)
        {
            soghedachon = LayPhanTuDaChon();
            string vitringoi = string.Join("\n", soghedachon);
            if (comboBox1.SelectedItem != null && dsphim.ContainsKey(comboBox1.Text))
            {
                MessageBox.Show(string.Format("Khách hàng: {2}\nPhim: {0}\nPhòng: {4}\nVị trí ngồi: {3}\nGiá: {1}",

               comboBox1.Text, dsphim[comboBox1.Text]*soghedachon.Length, txbhoten.Text, vitringoi, cbphong.Text));
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phim hợp lệ.");
            }
        }

        private string[] LayPhanTuDaChon()
        {
            List<string> phanTuDaChon = new List<string>();

            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                string phanTu = itemChecked.ToString();
                phanTuDaChon.Add(phanTu);
            }

            return phanTuDaChon.ToArray();
        }

        private void Datve_Load(object sender, EventArgs e)
        {
            if (dsphim != null)
            {
                foreach (string phim in dsphim.Keys)
                {
                    comboBox1.Items.Add(phim);
                }
            }
            else
            {
                MessageBox.Show("Danh sách phim trống.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox1.SelectedItem = null;
            cbphong.Text = "";
            cbphong.SelectedItem=null;
            txbhoten.Text="";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            soghedachon = new string[0];
        }
    }
}