using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Calc : Form
    {
        double firstno, secondno, ans;
        string op = " ";
        public Calc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null)
            {
                richTextBox1.Text = "0";
            }
            else
            {
                //rich
            }
        }

        private void Calc_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            op = "/";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            op = "%";
        }

        private void Square_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dot_Click(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            op = ".";
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null && richTextBox1.Text == "0")
            {
                richTextBox1.Text = "3";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "3";
            }
        }

        private void BTN0_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null&& richTextBox1.Text=="0")
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "0";
            }
        }

        private void Add_or_Sub_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            firstno=Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            op = "+";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            secondno=Convert.ToDouble(richTextBox1.Text);
            if (op == "+")
            {
                ans = firstno + secondno;
                richTextBox1.Text=ans.ToString();
            }
            else if(op == "-")
            {
                ans = firstno - secondno;
                richTextBox1.Text = ans.ToString();
            }
            else if (op == "*")
            {
                ans = firstno * secondno;
                richTextBox1.Text = ans.ToString();
            }
            else if (op == "/")
            {
                ans = firstno / secondno;
                richTextBox1.Text = ans.ToString();
            }
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null && richTextBox1.Text == "0")
            {
                richTextBox1.Text = "2";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "2";
            }
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null && richTextBox1.Text == "0")
            {
                richTextBox1.Text = "1";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "1";
            }
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            op = "-";
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null && richTextBox1.Text == "0")
            {
                richTextBox1.Text = "6";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "6";
            }
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null && richTextBox1.Text == "0")
            {
                richTextBox1.Text = "5";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "5";
            }
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null && richTextBox1.Text == "0")
            {
                richTextBox1.Text = "4";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "4";
            }
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            op = "*";
        }

        private void BTN8_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null && richTextBox1.Text == "0")
            {
                richTextBox1.Text = "8";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "8";
            }
        }

        private void BTN9_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null && richTextBox1.Text == "0")
            {
                richTextBox1.Text = "9";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "9";
            }
        }

        private void BTN7_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null && richTextBox1.Text == "0")
            {
                richTextBox1.Text = "7";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "7";
            }
        }
    }
}
