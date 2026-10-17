using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Lab02
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelMouseDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(ofd.FileName);
                rtbRead.Text = text;
            }
        }

        bool flag = true;

        private void btnCal_Click(object sender, EventArgs e)
        {
            string[] lines = rtbRead.Lines;
            List<string> results = new List<string>();
            bool isValidAll = true;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                try
                {
                    double result = EvaluateExpression(line.Trim());
                    results.Add(line + " = " + result);
                }
                catch (Exception)
                {
                    results.Add(line + " = Lỗi cú pháp/tính toán");
                    isValidAll = false;
                }
            }

            rtbCal.Lines = results.ToArray();
            flag = isValidAll;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text (*.txt)|*.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(sfd.FileName, FileMode.OpenOrCreate))
                    {
                        string content = rtbCal.Text;
                        byte[] buffer = Encoding.UTF8.GetBytes(content.Trim());
                        stream.Write(buffer, 0, buffer.Length);
                        MessageBox.Show("Đã lưu kết quả thành công.");
                        rtbRead.Clear();
                        rtbCal.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu có chứa dòng không hợp lệ, vui lòng kiểm tra lại!");
            }
        }

        
        private double EvaluateExpression(string expression)
        {
            expression = expression.Replace(" ", "");
            if (expression.StartsWith("-")) expression = "0" + expression;
            expression = expression.Replace("(-", "(0-");

            char[] tokens = expression.ToCharArray();
            Stack<double> values = new Stack<double>();
            Stack<char> ops = new Stack<char>();

            for (int i = 0; i < tokens.Length; i++)
            {
                
                if (char.IsDigit(tokens[i]) || tokens[i] == '.')
                {
                    StringBuilder sbuf = new StringBuilder();
                    while (i < tokens.Length && (char.IsDigit(tokens[i]) || tokens[i] == '.'))
                    {
                        sbuf.Append(tokens[i++]);
                    }
                    values.Push(double.Parse(sbuf.ToString(), System.Globalization.CultureInfo.InvariantCulture));
                    i--; 
                }
                else if (tokens[i] == '(')
                {
                    ops.Push(tokens[i]);
                }
                else if (tokens[i] == ')')
                {
                    while (ops.Peek() != '(')
                    {
                        values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));
                    }
                    ops.Pop(); 
                }
                else if (tokens[i] == '+' || tokens[i] == '-' || tokens[i] == '*' || tokens[i] == '/')
                {
                    while (ops.Count > 0 && HasPrecedence(tokens[i], ops.Peek()))
                    {
                        values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));
                    }
                    ops.Push(tokens[i]);
                }
            }

            while (ops.Count > 0)
            {
                values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));
            }

            return values.Pop();
        }

        private bool HasPrecedence(char op1, char op2)
        {
            if (op2 == '(' || op2 == ')')
                return false;
            if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
                return false;
            return true; 
        }

        private double ApplyOp(char op, double b, double a)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/':
                    if (b == 0) throw new DivideByZeroException("Cannot divide by zero");
                    return a / b;
            }
            return 0;
        }
    }
}