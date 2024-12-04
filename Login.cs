using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace M2_Project
{
    public partial class Login : Form
    {
        private string connectionString = "Data Source=146.230.177.46;Initial Catalog=G4Pmb2024;User ID=G4Pmb2024;Password=9u2eop";

        public void FormSetup(Form myForm)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();
        }
        public Login()
        {
            InitializeComponent();
        }


        private bool AuthenticateUser(string username, string password, string tableName)
        {
            string query = $"SELECT * FROM {tableName} WHERE Username = @Username AND Password = @Password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 kk = new Form4();
            this.Hide();
            FormSetup(kk);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sale kk = new Sale();
            this.Hide();
            FormSetup(kk);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (AuthenticateUser(txtUserName.Text, txtPassword.Text, "UserAccounts"))
                {
                    Menu kk = new Menu();
                    this.Hide();
                    FormSetup(kk);
                }
                else
                {
                    MessageBox.Show("Error in Login, Use correct details");
                }
            }
            else if (radioButton2.Checked)
            {
                if (AuthenticateUser(txtUserName.Text, txtPassword.Text, "Admin"))
                {
                    form2 kk = new form2();
                    this.Hide();
                    FormSetup(kk);
                }
                else
                {
                    MessageBox.Show("Error in Login, Use correct details");
                }
            }
            else
            {
                MessageBox.Show("Please Select appropriate radio button");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (AuthenticateUser(txtUserName.Text, txtPassword.Text, "UserAccounts"))
                {
                    Menu kk = new Menu();
                    this.Hide();
                    FormSetup(kk);
                }
                else
                {
                    MessageBox.Show("Error in Login, Use correct details");
                }
            }
            else if (radioButton2.Checked)
            {
                if (AuthenticateUser(txtUserName.Text, txtPassword.Text, "Admin"))
                {
                    form2 kk = new form2();
                    this.Hide();
                    FormSetup(kk);
                }
                else
                {
                    MessageBox.Show("Error in Login, Use correct details");
                }
            }
            else
            {
                MessageBox.Show("Please Select appropriate radio button");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
    
}
