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
    public partial class Accomidation : Form
    {
        public Accomidation()
        {
            InitializeComponent();
        }
        tbl_Accomidation r = new tbl_Accomidation();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            r.Name = textBox1.Text;
            r.RoomNo = comboBox1.Text;
            r.Date = textBox2.Text;
            r.Location = textBox3.Text;


            bool success = r.Insert(r);
            if (success == true)
            {
                MessageBox.Show("Room Booked Successful.The Room allotment may change depending on the Bookings");
            }
            else
            {
                MessageBox.Show("Booking UNSuccessful");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new UserAccount().Show();
            this.Hide();
        }
    }
}
