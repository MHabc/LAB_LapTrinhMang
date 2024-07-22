using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void Bai03_Load(object sender, EventArgs e)
        {

        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("input3.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            string inputFilePath = "input3.txt";
            string outputFilePath = "output3.txt";

            try
            {
                // Đọc nội dung từ file input
                string[] lines = File.ReadAllLines(inputFilePath);

                // Mở file output để ghi kết quả
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    foreach (string line in lines)
                    {
                        try
                        {
                            // Thực hiện phép tính và ghi kết quả vào file output cho từng dòng
                            string result = CalculateLine(line).ToString();
                            writer.WriteLine($"{line} = {result}");
                        }
                        catch (Exception ex)
                        {
                            // Ghi lại dòng không thể tính toán vào file output
                            writer.WriteLine($"{line} = Lỗi: {ex.Message}");
                        }
                    }
                }

                MessageBox.Show("Xử lý hoàn tất! Kết quả đã được ghi vào file output3.txt.", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalculateLine(string line)
        {
            line = line.Replace(" ", ""); // Loại bỏ các khoảng trắng

            Stack<double> numbers = new Stack<double>();
            Stack<char> operators = new Stack<char>();

            int i = 0;
            while (i < line.Length)
            {
                if (char.IsDigit(line[i]) || (line[i] == '-' && (i == 0 || line[i - 1] == '('))) 
                    // Nếu là số hoặc dấu trừ đầu biểu thức hoặc sau dấu ngoặc đơn
                {
                    StringBuilder sb = new StringBuilder();
                    while (i < line.Length && (char.IsDigit(line[i]) || line[i] == '.'))
                    {
                        sb.Append(line[i]);
                        i++;
                    }
                    double num = double.Parse(sb.ToString());
                    numbers.Push(num);
                }
                else if (line[i] == '(')
                {
                    operators.Push('(');
                    i++;
                }
                else if (line[i] == ')')
                {
                    while (operators.Peek() != '(')
                    {
                        double result = ApplyOperation(numbers.Pop(), numbers.Pop(), operators.Pop());
                        numbers.Push(result);
                    }
                    operators.Pop(); // Loại bỏ '('
                    i++;
                }
                else if (line[i] == '+' || line[i] == '-' || line[i] == '*' || line[i] == '/')
                {
                    while (operators.Count > 0 && HasPrecedence(line[i], operators.Peek()))
                    {
                        double result = ApplyOperation(numbers.Pop(), numbers.Pop(), operators.Pop());
                        numbers.Push(result);
                    }
                    operators.Push(line[i]);
                    i++;
                }
                else
                {
                    throw new ArgumentException($"Ký tự không hợp lệ: {line[i]}");
                }
            }

            while (operators.Count > 0)
            {
                double result = ApplyOperation(numbers.Pop(), numbers.Pop(), operators.Pop());
                numbers.Push(result);
            }

            return numbers.Pop();
        }

        private double ApplyOperation(double b, double a, char op)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b == 0)
                    {
                        throw new DivideByZeroException("Không thể chia cho 0.");
                    }
                    return a / b;
                default:
                    throw new ArgumentException($"Toán tử không hợp lệ: {op}");
            }
        }

        private bool HasPrecedence(char op1, char op2)
        {
            if (op2 == '(' || op2 == ')')
            {
                return false;
            }
            if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
            {
                return false;
            }
            return true;
        }

    }
}


