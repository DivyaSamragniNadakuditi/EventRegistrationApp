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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        tbl_Reg r = new tbl_Reg();


        private void Registration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventRegDataSet.tbl_Events' table. You can move, or remove it, as needed.
            this.tbl_EventsTableAdapter.Fill(this.eventRegDataSet.tbl_Events);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            r.EventID = textBox1.Text;
            r.Food = comboBox1.Text;
            r.Shuttle = comboBox2.Text;
            r.Accomidation = comboBox3.Text;
            r.TypeOfReg = comboBox4.Text;

            bool success = r.Insert(r);
            if (success == true)
            {
                MessageBox.Show("Registration Successful");
            }
            else
            {
                MessageBox.Show("Registration UNSuccessful");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_EventsTableAdapter.FillBy(this.eventRegDataSet.tbl_Events);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error");
            }

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new UserAccount().Show();
            this.Hide();
        }
    }
}
