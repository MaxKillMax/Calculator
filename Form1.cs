using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        int ClearCount = 0;
        int ConvCount = 0;
        Char Op;

        bool now = false;
        double Memory = 0;

        public void Converter1(string a, char op)
        {
            ConvCount++;

            if (ConvCount == 1) 
            { 
                Memory = Convert.ToDouble(a);
                if (op == '$')
                {
                    textBox1.Text = (1 / Memory).ToString();
                    Memory = 1 / Memory;
                    ConvCount = 1;
                    op = '=';
                }
            }

            if (ConvCount >= 2) 
            {
                switch (Op)
                {
                    case '+': 
                        Memory += Convert.ToDouble(a);
                        break;
                    case '-':
                        Memory -= Convert.ToDouble(a);
                        break;
                    case '*':
                        Memory *= Convert.ToDouble(a);
                        break;
                    case '/':
                        Memory /= Convert.ToDouble(a);
                        break;
                    case '%':
                        Memory %= Convert.ToDouble(a);
                        break;
                    case '$':
                        Memory = 1 / (Memory + Convert.ToDouble(a));
                        break;
                    case '=':
                        break;
                }
                if (op == '=')
                {
                    textBox1.Text = Memory.ToString();
                    ConvCount = 1;
                }
            }

            Op = op;
            ClearCount = 0;
            now = true;
        }

        public void AdText(string a)
        {
            if (now)
            {
                now = false;
                textBox1.Text = "";
            }

            if (textBox1.Text.Length < 20)
            {
                if (textBox1.Text.Length == 0)
                {
                    switch (a)
                    {
                        case "0":
                            textBox1.Text = textBox1.Text + "0,";
                            break;
                        case ",":
                            textBox1.Text = textBox1.Text + "0,";
                            break;
                        default:
                            textBox1.Text = textBox1.Text + a;
                            break;
                    }
                }
                else if (textBox1.Text.Length == 1 && textBox1.Text.IndexOf("-") == 0)
                {
                    switch (a)
                    {
                        case "0":
                            textBox1.Text = textBox1.Text + "0,";
                            break;
                        case ",":
                            textBox1.Text = textBox1.Text + "0,";
                            break;
                        default:
                            textBox1.Text = textBox1.Text + a;
                            break;
                    }
                }
                else textBox1.Text = textBox1.Text + a;
                ClearCount = 0;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdText("0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdText(",");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.Length == 1 && textBox1.Text.IndexOf("-") != 0)
                    Converter1(textBox1.Text, '=');

                else if (textBox1.Text.Length > 1)
                    Converter1(textBox1.Text, '=');
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.Length == 1 && textBox1.Text.IndexOf("-") != 0)
                    Converter1(textBox1.Text, '+');

                else if (textBox1.Text.Length > 1)
                    Converter1(textBox1.Text, '+');
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.Length == 1 && textBox1.Text.IndexOf("-") != 0)
                    Converter1(textBox1.Text, '-');

                else if (textBox1.Text.Length > 1)
                    Converter1(textBox1.Text, '-');
            }
            else
            {
                AdText("-");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdText("1");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdText("2");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdText("3");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.Length == 1 && textBox1.Text.IndexOf("-") != 0)
                    Converter1(textBox1.Text, '*');

                else if (textBox1.Text.Length > 1)
                    Converter1(textBox1.Text, '*');
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.Length == 1 && textBox1.Text.IndexOf("-") != 0)
                    Converter1(textBox1.Text, '/');

                else if (textBox1.Text.Length > 1)
                    Converter1(textBox1.Text, '/');
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AdText("4");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AdText("5");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AdText("6");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.Length == 1 && textBox1.Text.IndexOf("-") != 0)
                    Converter1(textBox1.Text, '$');

                else if (textBox1.Text.Length > 1)
                    Converter1(textBox1.Text, '$');
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.Length == 1 && textBox1.Text.IndexOf("-") != 0)
                    Converter1(textBox1.Text, '%');

                else if (textBox1.Text.Length > 1)
                    Converter1(textBox1.Text, '%');
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AdText("7");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AdText("8");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            AdText("9");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            else
            {
                Memory = 0;
                ConvCount = 0;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ClearCount++;
            if (ClearCount == 1)
            {
                Memory = 0;
                ConvCount = 0;

                textBox1.Text = "";
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (now && Op != '=')
            {
                now = false;
                Converter1(textBox2.Text, '=');
            }
            else
            {
                textBox2.Text = textBox1.Text;
            }
        }
    }
}
