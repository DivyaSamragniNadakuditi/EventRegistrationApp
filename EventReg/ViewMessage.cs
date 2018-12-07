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
    public partial class ViewMessage : Form
    {
        public ViewMessage()
        {
            InitializeComponent();
        }

        private void tbl_MessengerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_MessengerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eventRegDataSet8);

        }

        private void ViewMessage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventRegDataSet10.tbl_Messenger' table. You can move, or remove it, as needed.
            this.tbl_MessengerTableAdapter2.Fill(this.eventRegDataSet10.tbl_Messenger);
            // TODO: This line of code loads data into the 'eventRegDataSet9.tbl_Messenger' table. You can move, or remove it, as needed.
            this.tbl_MessengerTableAdapter1.Fill(this.eventRegDataSet9.tbl_Messenger);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdminPage().Show();
            this.Hide();
        }
    }
}
