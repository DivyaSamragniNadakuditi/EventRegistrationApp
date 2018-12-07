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
    public partial class Volunteers : Form
    {
        public Volunteers()
        {
            InitializeComponent();
        }
        tbl_Volunteers v = new tbl_Volunteers();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AdminPage().Show();
            this.Hide();
        }

        private void Volunteers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            v.EventID = textBox1.Text;
            v.ReportAt = textBox2.Text;
            v.ReportTo = textBox3.Text;
            v.ReportingDateAndTime = textBox4.Text;
            v.ThingsToBring = textBox5.Text;
            v.DressCode = textBox6.Text;

            bool success = v.Insert(v);
            if (success == true)
            {
                MessageBox.Show("Details Added");
            }
            else
            {
                MessageBox.Show("Details Cannot be Added. Try again.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
