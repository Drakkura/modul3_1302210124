using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302210124
{
    public partial class Form1 : Form
    {
        int sum;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                this.textBox1.Text = "1";
                sum += 1;
            }
            else { 
                this.textBox1.Text += "1";
                sum += 1;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            this.textBox1.Text = sum.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "+";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                this.textBox1.Text = "7";
                sum += 7;
            }
            else
            {
                this.textBox1.Text += "7";
                sum += 7;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "0")
                {
                    this.textBox1.Text = "2";
                    sum += 2;
                }
                else
                {
                    this.textBox1.Text += "2";
                    sum += 2;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "0")
                {
                    this.textBox1.Text = "3";
                    sum += 3;
                }
                else
                {
                    this.textBox1.Text += "3";
                    sum += 3;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "0")
                {
                    this.textBox1.Text = "4";
                    sum += 4;
                }
                else
                {
                    this.textBox1.Text += "4";
                    sum += 4;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "0")
                {
                    this.textBox1.Text = "5";
                    sum += 5;
                }
                else
                {
                    this.textBox1.Text += "5";
                    sum += 5;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "0")
                {
                    this.textBox1.Text = "6";
                    sum += 6;
                }
                else
                {
                    this.textBox1.Text += "6";
                    sum += 6;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                this.textBox1.Text = "8";
                sum += 8;
            }
            else
            {
                this.textBox1.Text += "8";
                sum += 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                this.textBox1.Text = "9";
                sum += 9;
            }
            else
            {
                this.textBox1.Text += "9";
                sum += 9;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                this.textBox1.Text = "0";
                sum += 0;
            }
            else
            {
                this.textBox1.Text += "0";
                sum += 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
