using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "NumPad0":
                    button0.PerformClick();
                    break;
                case "NumPad1":
                    button1.PerformClick();
                    break;
                case "NumPad2":
                    button2.PerformClick();
                    break;
                case "NumPad3":
                    button3.PerformClick();
                    break;
                case "NumPad4":
                    button4.PerformClick();
                    break;
                case "NumPad5":
                    button5.PerformClick();
                    break;
                case "NumPad6":
                    button6.PerformClick();
                    break;
                case "NumPad7":
                    button7.PerformClick();
                    break;
                case "NumPad8":
                    button8.PerformClick();
                    break;
                case "NumPad9":
                    button9.PerformClick();
                    break;
                case "Decimal":
                    buttonCham.PerformClick();
                    break;
                case "OemPeriod":
                    buttonCham.PerformClick();
                    break;
                case "Add":
                    buttonCong.PerformClick();
                    break;
                case "Subtract":
                    buttonTru.PerformClick();
                    break;
                case "Multiply":
                    buttonNhan.PerformClick();
                    break;
                case "Divide":
                    buttonChia.PerformClick();
                    break;
                case "Return":
                    buttonBang.PerformClick();
                    break;
                case "D0":
                    button0.PerformClick();
                    break;
                case "D1":
                    button1.PerformClick();
                    break;
                case "D2":
                    button2.PerformClick();
                    break;
                case "D3":
                    button3.PerformClick();
                    break;
                case "D4":
                    button4.PerformClick();
                    break;
                case "D5":
                    button5.PerformClick();
                    break;
                case "D6":
                    button6.PerformClick();
                    break;
                case "D7":
                    button7.PerformClick();
                    break;
                case "D8":
                    if (!e.Shift) button8.PerformClick();
                    else buttonNhan.PerformClick();
                    break;
                case "D9":
                    button9.PerformClick();
                    break;
                case "Oemplus":
                    if (e.Shift)
                    buttonCong.PerformClick();
                    break;
                case "OemMinus":
                    buttonTru.PerformClick();
                    break;
                case "OemQuestion":
                    buttonChia.PerformClick();
                    break;
                case "Back":
                    buttonBack.PerformClick();
                    break;
                case "C":
                    buttonC.PerformClick();
                    break;
            }
        }

        public char GetCal(string s)
        {
            for (int i=1; i<s.Length; i++)
            {
                if (s[i] == '+' || s[i] == '-' || s[i] == 'x' || s[i] == '/') return s[i];
            }
            return '_';
        }

        public string GetBack(string s)
        {
            return s.Substring(0, s.Length - 1);
        }

        public bool CheckLast(string s)
        {
            if (s[s.Length - 1] == '+' || s[s.Length - 1] == '-' || s[s.Length - 1] == 'x' || s[s.Length - 1] == '/') return true;
            return false;
        }

        public bool CheckPoint(string s)
        {
            if (GetCal(s) == '_')
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '.') return true;
                }
                return false;
            }
            else
            {
                int i = s.IndexOf(GetCal(s));
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[j] == '.') return true;
                }
                return false;
            }
        }
        private void PerformClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text != "=" && b.Text != "C" && b.Text != "<-" && b.Text != "+" && b.Text != "-" && b.Text != "x" && b.Text != "/" && b.Text != ".")
            {
                textBox1.Text += b.Text;
            }
            else if (textBox1.Text == "" && (b.Text == "-" || b.Text == "+")) textBox1.Text += b.Text;
            else if (b.Text == ".")
            {
                if (CheckPoint(textBox1.Text) == false) textBox1.Text += b.Text;
            }
            else if (b.Text == "+" || b.Text == "-" || b.Text == "x" || b.Text == "/")
            {
                if (GetCal(textBox1.Text) == '_') textBox1.Text += b.Text;
                else if (CheckLast(textBox1.Text))
                {
                    textBox1.Text = GetBack(textBox1.Text) + b.Text;
                }
                string[] num = new string[2];

                char currentFirstCharactor = textBox1.Text[0];
                if (currentFirstCharactor == '-' || currentFirstCharactor == '+')
                {
                    string inputTemp = textBox1.Text.Substring(1, textBox1.Text.Length - 1);
                    num = textBox1.Text.Split(GetCal(inputTemp));
                } else
                {
                    num = textBox1.Text.Split(GetCal(textBox1.Text));
                }
                num[0] += currentFirstCharactor;
                double num1 = Convert.ToDouble(num[0]);
                double num2 = 0;
                if (num[1] != "")
                {
                    num2 = Convert.ToDouble(num[1]);
                }
                switch (GetCal(textBox1.Text))
                {
                    case '+':
                        textBox1.Text = (num1 + num2).ToString() + b.Text;
                        break;
                    case '-':
                        textBox1.Text = (num1 - num2).ToString() + b.Text;
                        break;
                    case 'x':
                        textBox1.Text = (num1 * num2).ToString() + b.Text;
                        break;
                    case '/':
                        textBox1.Text = (num1 / num2).ToString() + b.Text;
                        break;
                }
            }
            else if (b.Text == "=")
            {
                if (GetCal(textBox1.Text) != '_')
                {
                    string[] num = textBox1.Text.Split(GetCal(textBox1.Text));
                    double num1;
                    if (num[0] != "") num1 = Convert.ToDouble(num[0]); else num1 = 0;
                    double num2;
                    if (num[1] != "") num2 = Convert.ToDouble(num[1]); else num2 = 0;
                    switch (GetCal(textBox1.Text))
                    {
                        case '+':
                            textBox1.Text = (num1 + num2).ToString();
                            break;
                        case '-':
                            textBox1.Text = (num1 - num2).ToString();
                            break;
                        case 'x':
                            textBox1.Text = (num1 * num2).ToString();
                            break;
                        case '/':
                            textBox1.Text = (num1 / num2).ToString();
                            break;
                    }
                }
            }
            else if (b.Text == "C")
            {
                textBox1.Text = "";
            }
            else if (b.Text == "<-")
            {
                if (textBox1.Text.Length>0) textBox1.Text = GetBack(textBox1.Text);
            }
        }
    }
}
