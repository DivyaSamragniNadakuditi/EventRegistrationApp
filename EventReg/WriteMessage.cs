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
    public partial class WriteMessage : Form
    {
        public WriteMessage()
        {
            InitializeComponent();
        }
        tbl_Messenger r = new tbl_Messenger();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void WriteMessage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventRegDataSet.tbl_Events' table. You can move, or remove it, as needed.
            this.tbl_EventsTableAdapter.Fill(this.eventRegDataSet.tbl_Events);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            r.SenderName = textBox1.Text;
            r.EventID = textBox2.Text;
            r.Message = textBox3.Text;

            bool success = r.Insert(r);
            if (success == true)
            {
                MessageBox.Show("Message Sent");
            }
            else
            {
                MessageBox.Show("Message Sending Failed");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
