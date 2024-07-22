using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Lab4
{
    public partial class Bai4_Main : Form
    {
        private bool isProgressBarRunning = false;

        private List<Phim> _PhimList;
        private int ygroupbox = 3;
        public Dictionary<string, int> _dsphim { get; set; }

        public class Phim
        {
            public string TenPhim { get; set; }
            public string LinkPhim { get; set; }
            public string LinkImage { get; set; }
            public int Giave { get; set; }
        }
        public Bai4_Main()
        {
            InitializeComponent();
            _dsphim = new Dictionary<string, int>();

            foreach (Control control in panel1.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    groupBox.Click += GroupBox_Click;
                }
            }
        }

        private void Bai4_Load(object sender, EventArgs e)
        {
            _PhimList = DeserializeFromFileJson<List<Phim>>(@"D:\Lab4\Lab4\data.json");
            if (_PhimList != null && _PhimList.Count > 0)
            {


                foreach (var phim in _PhimList)
                {
                    GroupBox groupBox = new GroupBox
                    {
                        Location = new Point(4, ygroupbox),
                        Size = new Size(802, 181),
                        Text = ""
                    };
                    groupBox.Click += GroupBox_Click;
                    panel1.Controls.Add(groupBox);
                    ygroupbox += 187;

                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(146, 164),
                        Location = new Point(5, 11),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    pictureBox.Load(phim.LinkImage);
                    groupBox.Controls.Add(pictureBox);

                    Label labelName = new Label
                    {
                        AutoSize = true,
                        Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                        ForeColor = Color.LightCoral,
                        Location = new Point(177, 11),
                        Size = new Size(92, 32),
                        Text = phim.TenPhim
                    };
                    groupBox.Controls.Add(labelName);

                    Label labelLink = new Label
                    {
                        AutoSize = true,
                        Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                        Location = new Point(180, 61),
                        Size = new Size(64, 25),
                        Text = phim.LinkPhim
                    };
                    groupBox.Controls.Add(labelLink);


                    _dsphim[phim.TenPhim] = phim.Giave;


                }
            }
        }

        static T DeserializeFromFileJson<T>(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                return System.Text.Json.JsonSerializer.Deserialize<T>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return default;
            }
        }

        private void ShowWeb_FormClosed(object sender, FormClosedEventArgs e)
        {
            isProgressBarRunning = false;
            progressBar1.Value = 0;
        }

        private void StartProgressBar()
        {
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += (sender, e) =>
            {
                if (progressBar1.Value < 100)
                {
                    progressBar1.Value += 10;
                }
                else
                {
                    timer.Stop();
                    isProgressBarRunning = false;
                }
            };
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai4_DatVe datve = new Bai4_DatVe
            {
                dsphim = _dsphim
            };
            datve.Show();
        }

        private void GroupBox_Click(object sender, EventArgs e)
        {
            if (!isProgressBarRunning)
            {
                isProgressBarRunning = true;
                StartProgressBar();
            }
            GroupBox clickedGroupBox = (GroupBox)sender;
            string movieLink = "";

            foreach (Control control in clickedGroupBox.Controls)
            {
                if (control is Label label && label.Text.Contains("http"))
                {
                    movieLink = label.Text;
                    break;
                }
            }

            if (!string.IsNullOrEmpty(movieLink))
            {
                Bai4_ShowWeb showWeb = new Bai4_ShowWeb
                {
                    ReceivedMessage = movieLink
                };
                showWeb.FormClosed += ShowWeb_FormClosed;
                showWeb.Show();
            }
            else
            {
                MessageBox.Show("Không tìm thấy liên kết hợp lệ trong groupbox.");
            }
        }
    }
}