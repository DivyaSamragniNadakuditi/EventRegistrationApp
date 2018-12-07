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
    public partial class UserFAQS : Form
    {
        private readonly object tableAdapterManager;
        private readonly object tbl_FAQSBindingSource;

        public UserFAQS()
        {
            InitializeComponent();
        }

        private void tbl_FAQSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void UserFAQS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventRegDataSet6.tbl_FAQS' table. You can move, or remove it, as needed.
            this.tbl_FAQSTableAdapter.Fill(this.eventRegDataSet6.tbl_FAQS);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UserAccount().Show();
            this.Hide();
        }
    }
}
