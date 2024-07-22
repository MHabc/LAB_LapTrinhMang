using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        [Serializable]
        class Student
        {
            public string Name { get; set; }
            public int MSSV { get; set; }
            public string Phone { get; set; }
            public float Course1 { get; set; }
            public float Course2 { get; set; }
            public float Course3 { get; set; }
            public float Average { get; set; }
        }
        List<Student> students = new List<Student>();
        List<int> pagenumbers = new List<int>();

        private void btnRead_Click(object sender, EventArgs e)
        {
            Serialized();
            Deserialized();
            Setup();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fsout = new FileStream("output4.txt", FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fsout);
            writer.Write(txtFileContent.Text);
            writer.Close();
            fsout.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int currentpagenumber = Convert.ToInt32(lbPageNumber.Text);
            if (currentpagenumber == pagenumbers.Count) //If in the last object
            {
                ShowObject(0); //Go to first object
            }
            else
            {
                ShowObject(currentpagenumber); //Go to next object
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int currentpagenumber = Convert.ToInt32(lbPageNumber.Text);
            if (currentpagenumber == 1) //If in the first object
            {
                ShowObject(pagenumbers.Count - 1); //Back to last object
            }
            else
            {
                ShowObject(currentpagenumber - 2); //Back to previous object
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckProperty() == true)
            {
                Student student = new Student();
                student.Name = txtWriteName.Text;
                student.MSSV = Convert.ToInt32(txtWriteID.Text);
                student.Phone = txtWritePhone.Text;
                student.Course1 = Convert.ToSingle(txtWriteCourse1.Text);
                student.Course2 = Convert.ToSingle(txtWriteCourse2.Text);
                student.Course3 = Convert.ToSingle(txtWriteCourse3.Text);
                student.Average = (student.Course1 + student.Course2 + student.Course3) / 3;
                student.Average = (float)Math.Round(student.Average, 2);
                txtFileContent.Text += student.Name + "\r\n"
                                  + student.MSSV + "\r\n"
                                  + student.Phone + "\r\n"
                                  + student.Course1 + "\r\n"
                                  + student.Course2 + "\r\n"
                                  + student.Course3 + "\r\n"
                                  + student.Average + "\r\n"
                                  + "\r\n";
                students.Add(student);
                pagenumbers.Add(pagenumbers.Count + 1);
                btnWrite_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Invalid Input.", "Notice");
                txtWriteName.Text = "";
                txtWriteID.Text = "";
                txtWritePhone.Text = "";
                txtWriteCourse1.Text = "";
                txtWriteCourse2.Text = "";
                txtWriteCourse3.Text = "";
            }
        }

        void Setup()
        {
            for (int index = 0; index < students.Count; index++)
            {
                pagenumbers.Add(index + 1);
                txtFileContent.Text += students[index].Name + "\r\n"
                              + students[index].MSSV + "\r\n"
                              + students[index].Phone + "\r\n"
                              + students[index].Course1 + "\r\n"
                              + students[index].Course2 + "\r\n"
                              + students[index].Course3 + "\r\n"
                              + students[index].Average + "\r\n"
                              + "\r\n";
            }
            ShowObject(0);
        }

        void ShowObject(int pagenumber)
        {
            txtReadName.Text = students[pagenumber].Name;
            txtReadID.Text = Convert.ToString(students[pagenumber].MSSV);
            txtReadPhone.Text = students[pagenumber].Phone;
            txtReadCourse1.Text = Convert.ToString(students[pagenumber].Course1);
            txtReadCourse2.Text = Convert.ToString(students[pagenumber].Course2);
            txtReadCourse3.Text = Convert.ToString(students[pagenumber].Course3);
            txtAverage.Text = Convert.ToString(students[pagenumber].Average);
            lbPageNumber.Text = Convert.ToString(pagenumbers[pagenumber]);
        }

        bool CheckProperty()
        {
            if ((Convert.ToInt32(txtWriteID.Text) < 10000000) || (Convert.ToInt64(txtWriteID.Text) > 99999999))
            {
                return false;
            }
            else if ((Convert.ToSingle(txtWriteCourse1.Text) < 0) || (Convert.ToSingle(txtWriteCourse1.Text) > 10))
            {
                return false;
            }
            else if ((Convert.ToSingle(txtWriteCourse2.Text) < 0) || (Convert.ToSingle(txtWriteCourse2.Text) > 10))
            {
                return false;
            }
            else if ((Convert.ToSingle(txtWriteCourse2.Text) < 0) || (Convert.ToSingle(txtWriteCourse2.Text) > 10))
            {
                return false;
            }
            else if ((txtWritePhone.Text.Length != 10) || (txtWritePhone.Text[0] != '0'))
            {
                char a = txtWritePhone.Text[0];
                return false;
            }
            else
            {
                return true;
            }
        }

        void Serialized()
        {
            FileStream fsinput = new FileStream("input4.txt", FileMode.Open, FileAccess.Read);
            FileStream fsmid = new FileStream("midput4.txt", FileMode.Open, FileAccess.Write);
            StreamReader reader = new StreamReader(fsinput);
            Student student = new Student();
            BinaryFormatter bf = new BinaryFormatter();
            while (reader.Peek() != -1)
            {
                student.Name = reader.ReadLine();
                student.MSSV = Convert.ToInt32(reader.ReadLine());
                student.Phone = reader.ReadLine();
                student.Course1 = Convert.ToSingle(reader.ReadLine());
                student.Course2 = Convert.ToSingle(reader.ReadLine());
                student.Course3 = Convert.ToSingle(reader.ReadLine());
                student.Average = (student.Course1 + student.Course2 + student.Course3) / 3;
                student.Average = (float)Math.Round(student.Average, 2);
                bf.Serialize(fsmid, student);
            }
            reader.Close();
            fsinput.Close();
            fsmid.Close();
        }

        void Deserialized()
        {
            FileStream fsmid = new FileStream("midput4.txt", FileMode.OpenOrCreate, FileAccess.Read);
            Student student = new Student();
            BinaryFormatter bf = new BinaryFormatter();
            while (fsmid.Position < fsmid.Length)
            {
                student = (Student)bf.Deserialize(fsmid);
                students.Add(student);
            }
            fsmid.Close();
        }

        
    }
}