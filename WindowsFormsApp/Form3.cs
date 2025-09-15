using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            GetStdrecord();
        }

        private void GetStdrecord()
        {
            SqlConnection con = new SqlConnection("");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void stddetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
