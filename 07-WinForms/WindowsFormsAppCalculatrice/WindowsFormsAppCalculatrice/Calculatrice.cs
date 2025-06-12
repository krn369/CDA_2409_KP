using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCalculatrice
{
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0+";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2+";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3+";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4+";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5+";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6+";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7+";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8+";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9+";
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            string[] parts = textBox1.Text.Split('+');
            int sum = 0;

            foreach (string part in parts)
            {
                if(int.TryParse(part, out int number))
                {
                    sum += number;
                }
            }
            textBox1.Text += "= " + sum.ToString() + "+";
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

    }
}
