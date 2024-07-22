using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using System.Diagnostics;
namespace Lab5
{
    public partial class Bai4 : Form
    {
        private readonly string websiteUrl = "https://betacinemas.vn/phim.htm";

        public Bai4()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = false;
        }

        private void Bai4_Load(object sender, EventArgs e)
        {
            try
            {
                HtmlWeb web = new HtmlWeb();
                HtmlDocument htmlDoc = web.Load(websiteUrl);
                List<string> tenPhimList = new List<string>();
                List<string> imageUrls = new List<string>();
                List<string> links = new List<string>();

                var h3Nodes = htmlDoc.DocumentNode.SelectNodes("//div[@class='film-info film-xs-info']/h3/a");
                if (h3Nodes != null)
                {
                    foreach (var node in h3Nodes)
                    {
                        string tenBoPhim = node.InnerText.Trim();
                        tenPhimList.Add(tenBoPhim);
                    }
                }

                var imgNodes = htmlDoc.DocumentNode.SelectNodes("//div[@class='pi-img-wrapper']/img[@src]");
                if (imgNodes != null)
                {
                    foreach (var imgNode in imgNodes)
                    {
                        string imageUrl = imgNode.GetAttributeValue("src", "");
                        imageUrls.Add(imageUrl);
                    }
                }

                var linkNodes = htmlDoc.DocumentNode.SelectNodes("//div[@class='film-info film-xs-info']/h3/a");
                if (linkNodes != null)
                {
                    foreach (var linkNode in linkNodes)
                    {
                        string linkUrl = linkNode.GetAttributeValue("href", "");
                        links.Add(linkUrl);
                    }
                }

                if (tenPhimList.Count > 0 && imageUrls.Count > 0 && links.Count > 0)
                {
                    int minCount = Math.Min(tenPhimList.Count, Math.Min(imageUrls.Count, links.Count));
                    for (int i = 0; i < minCount; i++)
                    {
                        string tenPhim = tenPhimList[i];
                        string imageUrl = imageUrls[i];
                        string link = links[i];
                        link = "https://betacinemas.vn/" + link;

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Load(imageUrl);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                        AddProgressBar(tenPhim, pictureBox, link);
                    }
                }
                else
                {
                    MessageBox.Show("Không có thông tin về các bộ phim hoặc hình ảnh trên trang web.");
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải nội dung HTML từ URL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void AddProgressBar(string tenPhim, PictureBox pictureBox, string link)
        {
            Bai4_ProgressBarWithLabel progressBarWithLabel = new Bai4_ProgressBarWithLabel();
            progressBarWithLabel.SetLabelText(tenPhim);
            progressBarWithLabel.SetPictureBox(pictureBox);
            progressBarWithLabel.SetLabellinkText(link);
            progressBarWithLabel.ProgressBarClick += ProgressBarWithLabel_Click;
            progressBarWithLabel.ShowDetailsWebViewClick += ProgressBarWithLabel_ShowDetailsWebViewClick;
            flowLayoutPanel1.Controls.Add(progressBarWithLabel);
        }

        private void ProgressBarWithLabel_Click(object sender, EventArgs e)
        {
            Bai4_ProgressBarWithLabel progressBarWithLabel = sender as Bai4_ProgressBarWithLabel;
            Bai4_BookingForm bookingForm = new Bai4_BookingForm(progressBarWithLabel.LinkLabelText, progressBarWithLabel.LabelText, progressBarWithLabel.PictureBoxImage);
            bookingForm.Show();
        }

        private void ProgressBarWithLabel_ShowDetailsWebViewClick(object sender, EventArgs e)
        {
            Bai4_ProgressBarWithLabel progressBarWithLabel = sender as Bai4_ProgressBarWithLabel;
            string url = progressBarWithLabel.LinkLabelText;
            Bai4_HienThi hienthi = new Bai4_HienThi();
            hienthi.Hienthiweb(url);
            hienthi.Show();
        }
    }
}
