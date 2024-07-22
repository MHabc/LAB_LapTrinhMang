using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai04 : Form
    {
        class Phim
        {
            public string TenPhim { get; set; }
            public int GiaVeChuan { get; set; }
            public int[] PhongChieu { get; set; }
        }

        private Dictionary<string, int[]> phongChieuDict = new Dictionary<string, int[]>
        {
            { "Đào, phở và piano", new int[] { 1, 2, 3 } },
            { "Mai", new int[] { 2, 3 } },
            { "Gặp lại chị bầu", new int[] { 1 } },
            { "Tarot", new int[] { 3 } }
        };

        public Bai04()
        {
            InitializeComponent();

            var phims = new List<Phim>
            {
                new Phim() { TenPhim = "Đào, phở và piano", GiaVeChuan = 45000, PhongChieu = new int[] { 1, 2, 3 } },
                new Phim() { TenPhim = "Mai", GiaVeChuan = 100000, PhongChieu = new int[] { 2, 3 } },
                new Phim() { TenPhim = "Gặp lại chị bầu", GiaVeChuan = 70000, PhongChieu = new int[] { 1 } },
                new Phim() { TenPhim = "Tarot", GiaVeChuan = 90000, PhongChieu = new int[] { 3 } }
            };

            comboBox1.DataSource = phims;
            comboBox1.DisplayMember = "TenPhim";

            // Sự kiện khi chọn phim trong comboBox1
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;

            // Hiển thị phòng chiếu cho phim đầu tiên
            ComboBox1_SelectedIndexChanged(null, null);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy tên phim được chọn
            string selectedPhim = comboBox1.Text;

            // Kiểm tra xem phim có trong từ điển không
            if (phongChieuDict.ContainsKey(selectedPhim))
            {
                // Lấy danh sách phòng chiếu tương ứng với phim
                int[] phongChieu = phongChieuDict[selectedPhim];

                // Cập nhật danh sách phòng chiếu cho comboBox2
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(phongChieu.Select(x => x.ToString()).ToArray());

                // Chọn phòng chiếu đầu tiên (nếu có)
                if (phongChieu.Length > 0)
                    comboBox2.SelectedIndex = 0;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Phim selectedPhim = comboBox1.SelectedItem as Phim;

            List<CheckBox> checkBoxes = groupBox1.Controls.OfType<CheckBox>().ToList();
            double totalPrice = 0;

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    string hangGhe = checkBox.Name.Split('_')[0];
                    int soTTGhe = int.Parse(checkBox.Name.Split('_')[1]);
                    int giaVeChuan = selectedPhim.GiaVeChuan;

                    // Tính giá vé tương ứng với loại ghế
                    double giaVe;
                    switch (hangGhe)
                    {
                        case "A":
                        case "C":
                            giaVe = giaVeChuan * 0.25; // Ghế vé vớt
                            break;
                        case "B" when soTTGhe >= 2 && soTTGhe <= 4:
                            giaVe = giaVeChuan * 2; // Ghế VIP
                            break;
                        default:
                            giaVe = giaVeChuan; // Ghế thường
                            break;
                    }

                    totalPrice += giaVe;
                }
            }

            // Hiển thị tổng tiền
            MessageBox.Show($"Tổng tiền phải thanh toán: {totalPrice} VND");
        }



    }


}

