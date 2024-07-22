using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
            InitializeData();
            InitializeListView();
        }
        public class MonAn
        {
            public int IDMA { get; set; }
            public string TenMonAn { get; set; }
            public string HinhAnh { get; set; }
            public int IDNCC { get; set; }

            public MonAn(int idma, string tenMonAn, string hinhAnh, int idncc)
            {
                IDMA = idma;
                TenMonAn = tenMonAn;
                HinhAnh = hinhAnh;
                IDNCC = idncc;
            }
        }

        public class NguoiDung
        {
            public int IDNCC { get; set; }
            public string HoVaTen { get; set; }
            public string QuyenHan { get; set; }

            public NguoiDung(int idncc, string hoVaTen, string quyenHan)
            {
                IDNCC = idncc;
                HoVaTen = hoVaTen;
                QuyenHan = quyenHan;
            }
        }

        List<MonAn> monan = new List<MonAn>();
        List<NguoiDung> nguoidung = new List<NguoiDung>();

        private void InitializeData()
        {
            monan.Add(new MonAn(1, "Cơm gà", @"D:\comga.jpg", 1));
            monan.Add(new MonAn(2, "Bánh cuốn", @"D:\banhcuon.jpg", 2));
            monan.Add(new MonAn(3, "Cháo", @"D:\chao.jpg", 3));

            nguoidung.Add(new NguoiDung(1, "Nguyen Van A", "quyen 1"));
            nguoidung.Add(new NguoiDung(2, "Nguyen Van B", "quyen 2"));
            nguoidung.Add(new NguoiDung(3, "Nguyen Van C", "quyen 3"));
        }

        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Tên món ăn", 200);
            listView1.Columns.Add("Hình ảnh", 100);

            FillListView();
        }

        private void FillListView()
        {
            listView1.Items.Clear(); 

            foreach (MonAn item in monan)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { item.TenMonAn, item.HinhAnh });
                listView1.Items.Add(listViewItem);
            }
        }

        private void btnRandomDish_Click(object sender, EventArgs e)        // xử lý nút Random
        {
            if (monan.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(monan.Count);

                MonAn selectedDish = monan[randomIndex];

                lblMonAn.Text = selectedDish.TenMonAn;

                int ngdung = selectedDish.IDNCC;
                if (selectedDish.IDNCC != null)
                {
                    foreach (NguoiDung nd in nguoidung)
                    {
                        if (nd.IDNCC == ngdung)
                        {
                            lblNguoiDung.Text = nd.HoVaTen;
                        }
                    }
                }

                if (File.Exists(selectedDish.HinhAnh))      // nếu có hình ảnh thì hiển thị ra, không có thì để trống
                {
                    pictureBox1.Image = Image.FromFile(selectedDish.HinhAnh);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox1.Image = null; 
                }
            }
            else
            {
                MessageBox.Show("Chưa có món ăn nào trong danh sách !");
            }
        }

    }
}
