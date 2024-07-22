using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Bai4_ProgressBarWithLabel : UserControl
    {
        public Bai4_ProgressBarWithLabel()
        {
            InitializeComponent();
        }

        public event EventHandler ProgressBarClick;
        public event EventHandler ShowDetailsClick;

        public void SetLabelText(string text)
        {
            label.Text = text;
        }

        public void SetPictureBox(PictureBox picturebox)
        {
            if (picturebox.Image != null)
            {
                pictureBox.Image = (Image)picturebox.Image.Clone();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Visible = true;
            }
        }

        public void SetLabellinkText(string text)
        {
            label1.Text = text;
        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            ProgressBarClick?.Invoke(this, e);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            ShowDetailsWebViewClick?.Invoke(this, e);
        }


        public string LabelText => label.Text;
        public Image PictureBoxImage => pictureBox.Image;
        public string LinkLabelText => label1.Text;

        public event EventHandler ShowDetailsWebViewClick;

    }
}
