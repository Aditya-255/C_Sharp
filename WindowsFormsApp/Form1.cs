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
    public partial class Label : Form
    {
        public Label()
        {
            InitializeComponent();
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void num02_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void A_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(A.Text);
            int b = int.Parse(B.Text);
            //MessageBox.Show($"The sum of {a} and {b} is {a + b}", "Sum Result");
            ans.Text = "Sum of two number is : " + (a + b);
            ans.Visible = true;

        }

        private void B_TextChanged(object sender, EventArgs e)
        {

        }

        private void ans_Click(object sender, EventArgs e)
        {

        }
    }
}
