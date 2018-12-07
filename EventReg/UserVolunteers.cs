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
    public partial class UserVolunteers : Form
    {
        public UserVolunteers()
        {
            InitializeComponent();
        }

        private void UserVolunteers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventRegDataSet7.tbl_Volunteers' table. You can move, or remove it, as needed.
            this.tbl_VolunteersTableAdapter.Fill(this.eventRegDataSet7.tbl_Volunteers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UserAccount().Show();
            this.Hide();
        }
    }
}
