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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        tbl_UsersSign u = new tbl_UsersSign();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
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
                new AdminPage().Show();
                this.Hide();
            }
        }
    }
}
