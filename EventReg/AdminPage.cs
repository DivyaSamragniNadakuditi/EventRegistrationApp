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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ECreate().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new HallRegister().Show();
            this.Hide();
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FAQS().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Volunteers().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new SignedOut().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new ViewMessage().Show();
            this.Hide();
        }
    }
}
