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
    public partial class HallRegister : Form
    {
        public HallRegister()
        {
            InitializeComponent();
        }
        tbl_Halls h = new tbl_Halls();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HallRegister_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            h.EventID = textBox1.Text;
            h.HallName = textBox2.Text;
            h.Capacity = textBox3.Text;
            h.Location = textBox4.Text;
            h.DateOfEvent = comboBox1.Text;


            bool success = h.Insert(h);
            if (success == true)
            {
                MessageBox.Show("Event Registered Successfully");
            }
            else
            {
                MessageBox.Show("Event Registration Unsuccessful");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AdminPage().Show();
            this.Hide();
        }
    }
}
