using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace M2_Project
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            PopulateComboBox();

            // Check low stock on form load
            //CheckLowStock();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            taInventory.Fill(g4Pmb2024DataSet.Inventory);
        }

        private void PopulateComboBox()
        {
            for (int i = 1; i <= 100; i++)
            {
                comboQuantity.Items.Add(i);
                comboUpdateQ.Items.Add(i);
            }
        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Confirm?", "Add Product Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                taInventory.Insert(txtDescription.Text, Convert.ToDecimal(txtPrice.Text), comboQuantity.SelectedItem.ToString(), Convert.ToDecimal(txtVat.Text));
                MessageBox.Show("A New Product has been Added");
                taInventory.Fill(g4Pmb2024DataSet.Inventory);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("New Product has NOT been Added");
            }
            else
            {
                MessageBox.Show("Addition of Product has been Cancelled");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            taInventory.UpdateInventory(Convert.ToDecimal(txtUpdatePrice.Text), comboUpdateQ.SelectedItem.ToString(), (int)dgInventory.CurrentRow.Cells[0].Value, (int)dgInventory.CurrentRow.Cells[0].Value);
            taInventory.Fill(g4Pmb2024DataSet.Inventory);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu kk = new Menu();
            this.Hide();
            kk.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            taInventory.Delete((int)dgInventory.CurrentRow.Cells[0].Value, dgInventory.CurrentRow.Cells[1].Value.ToString(), Convert.ToDecimal(dgInventory.CurrentRow.Cells[2].Value), dgInventory.CurrentRow.Cells[3].Value.ToString(), Convert.ToDecimal(dgInventory.CurrentRow.Cells[4].Value));
            taInventory.Fill(g4Pmb2024DataSet.Inventory);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CheckLowStock();
        }

        protected void CheckLowStock()
        {
            string connectionString = "Data Source=146.230.177.46;Initial Catalog=G4Pmb2024;User ID=G4Pmb2024;Password=9u2eop"; // Replace with your actual connection string
            string query = "SELECT InventoryID, ProdDescription, ProdPrice, QuantityLevels, ProdCharge_VAT FROM Inventory WHERE QuantityLevels < 20";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgInventory.DataSource = dt;
                }
                else
                {
                    // No low stock products found
                    MessageBox.Show("No Products that has a low stock");
                }

                reader.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox2.Hide(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            taInventory.FillBy1(g4Pmb2024DataSet.Inventory, textBox1.Text);
        }
    }
}
