using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai07 : Form
    {
        public Bai07()
        {
            InitializeComponent();
            DriveInfo[] dr = DriveInfo.GetDrives(); // lấy danh sách thư mục 
            foreach (DriveInfo drive in dr)
            {
                TreeNode node = new TreeNode(drive.Name);
                node.Tag = drive.RootDirectory;
                treeView1.Nodes.Add(node);
                LoadNode(node);
            }
        }

        private void LoadNode(TreeNode parentNode)
        {
            DirectoryInfo[] dct = ((DirectoryInfo)parentNode.Tag).GetDirectories();
            AddNodes(parentNode, dct);

            FileInfo[] files = ((DirectoryInfo)parentNode.Tag).GetFiles();
            AddNodes(parentNode, files);
        }

        private void AddNodes(TreeNode parentNode, FileSystemInfo[] items)      // thêm các nút vào TreeView
        {
            foreach (var item in items)
            {
                TreeNode node;
                if (item is DirectoryInfo directory)
                {
                    node = new TreeNode(directory.Name);
                    node.Tag = directory;
                    node.Nodes.Add("");
                }
                else
                {
                    node = new TreeNode(item.Name);
                    node.Tag = item;
                }
                parentNode.Nodes.Add(node);
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is DirectoryInfo directory)
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Remove();
                }
                DirectoryInfo[] subDirectories = directory.GetDirectories();
                AddNodes(e.Node, subDirectories); // Thêm các nút cho các thư mục con

                FileInfo[] files = directory.GetFiles();
                AddNodes(e.Node, files);
            }
            else if (e.Node.Tag is FileInfo file)
            {
                if (CheckImage(file.FullName))
                {
                    ShowImage(file.FullName);
                }
                else
                {
                    ShowText(file.FullName);
                }
            }
        }

        private bool CheckImage(string filePath)
        {
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif" };
            string extension = Path.GetExtension(filePath);
            return imageExtensions.Contains(extension, StringComparer.OrdinalIgnoreCase);
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == "")
            {
                e.Node.Nodes.Clear();
                LoadNode(e.Node);
            }
        }

        private void ShowImage(string imagePath)    // hiển thị hình ảnh
        {
            try
            {
                richTextBox1.Visible = false;
                pictureBox1.Visible = true;
                Image image = Image.FromFile(imagePath);
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
                MessageBox.Show("Không thể hiển thị !", "L");
            }
        }

        private void ShowText(string filePath)  // hiển thị văn bản
        {
            try
            {
                string content = File.ReadAllText(filePath);
                richTextBox1.Text = content;
                richTextBox1.Visible = true;
                pictureBox1.Visible = false;
            }
            catch
            {
                MessageBox.Show("Không thể hiển thị !", "Lỗi");
            }
        }
    }
}
