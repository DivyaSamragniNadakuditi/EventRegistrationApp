using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventReg
{
    public partial class ECreate : Form
    {
        public ECreate()
        {
            InitializeComponent();
        }
        tbl_Events a = new tbl_Events();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.EventName = textBox2.Text;
            a.DateandTime = textBox3.Text;
            a.Location = textBox4.Text;
            a.Description = textBox5.Text;
           

            bool success = a.Insert(a);
            if (success == true)
            {
                MessageBox.Show("Event Registered Successfully");
            }
            else
            {
                MessageBox.Show("Event Registration Unsuccessful");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AdminPage().Show();
            this.Hide();
        }
    }
}
