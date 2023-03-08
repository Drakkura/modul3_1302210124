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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "1 + 2";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "1 +";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox2.Text = "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
