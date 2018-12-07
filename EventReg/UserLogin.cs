using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventReg
{
    public partial class UserLogin : Form
    {
       
        public UserLogin()
        {
            InitializeComponent();
        }
        tbl_UsersSign u = new tbl_UsersSign();
        private void button2_Click(object sender, EventArgs e)
        {
            new EventRegistry().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            u.email = textBox1.Text;
            u.password = textBox2.Text;



            if (textBox2.Text == null)
            {
                MessageBox.Show("Login UnSuccessful");

            }
            else
            {
                MessageBox.Show("Login Successful");
                new UserAccount().Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new EventRegistry().Show();
            this.Hide();
        }
    }
}
