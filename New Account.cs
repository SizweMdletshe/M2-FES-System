using System;
using System.Windows.Forms;

namespace M2_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                taUserAccount.Insert(txtName.Text, txtSurname.Text, maskedTextPassword.Text);
                MessageBox.Show("Sign Up Successful");
                taUserAccount.Fill(g4Pmb2024DataSet1.UserAccounts);
            }
            catch (Exception)
            {
                MessageBox.Show("Sign Up UnSuccessful");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login kk = new Login();
            this.Hide();
            kk.Show();
        }
    }
}
