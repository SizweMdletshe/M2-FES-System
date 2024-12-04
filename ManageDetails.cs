using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2_Project
{
    public partial class ManageDetails : Form
    {
        public ManageDetails()
        {
            InitializeComponent();
        }

        private void ManageDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g4Pmb2024DataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.g4Pmb2024DataSet.Admin);



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {  
            adminTableAdapter.UpdateQuery(txtUserName.Text, txtPassword.Text, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            this.adminTableAdapter.Fill(this.g4Pmb2024DataSet.Admin);
        }
    }
}
