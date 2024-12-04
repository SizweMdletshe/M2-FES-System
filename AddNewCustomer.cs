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
    public partial class Add_New_Customer : Form
    {
        public Add_New_Customer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                customerTableAdapter1.Insert(txtName.Text, txtSurname.Text, txtEmail.Text, txtNumber.Text, txtAddress.Text, Convert.ToInt32(txtRewards.Text));
                MessageBox.Show("A New Customer has been added");
                txtName.Text = txtSurname.Text = txtEmail.Text = txtNumber.Text = txtAddress.Text = txtRewards.Text = "";

            }
            catch (Exception)
            {

                MessageBox.Show("Failer to add new Customer ");
            }
        }

        private void Add_New_Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
