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
    public partial class FAQS : Form
    {
        public FAQS()
        {
            InitializeComponent();
        }
        tbl_FAQS f = new tbl_FAQS();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.EventID = textBox1.Text;
            f.ThingsToBring = textBox2.Text;
            f.Prerequisites = textBox3.Text;
            f.FacilitiesAvailable = textBox4.Text;
            f.DressCode = textBox5.Text;

            bool success = f.Insert(f);
            if (success == true)
            {
                MessageBox.Show("Answers Added");
            }
            else
            {
                MessageBox.Show("Answers Cannot be Added");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            new AdminPage().Show();
            this.Hide();

        }
    }
}
