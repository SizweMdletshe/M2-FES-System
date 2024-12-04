using System;
using System.Windows.Forms;

namespace M2_Project
{
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g4Pmb2024DataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.g4Pmb2024DataSet.Supplier);
            // TODO: This line of code loads data into the 'g4Pmb2024DataSet1.Supplier1' table. You can move, or remove it, as needed.
            //supplierTableAdapter1.Fill(g4Pmb2024DataSet1.Supplier);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                supplierTableAdapter.UpdateSupplier(dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(), Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Successful updated the supplier");
                supplierTableAdapter.Fill(g4Pmb2024DataSet.Supplier);

            }
            catch (Exception)
            {

                MessageBox.Show("Failed to update the supplier");
            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            supplierTableAdapter.FillByName(g4Pmb2024DataSet.Supplier, textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            supplierTableAdapter.Delete(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString());
            supplierTableAdapter.Fill(g4Pmb2024DataSet.Supplier);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                supplierTableAdapter.Insert(txtName.Text, txtEmail.Text, txtAddress.Text, txtNumber.Text);
                MessageBox.Show("New Supplier Added successfully");
                supplierTableAdapter.Fill(g4Pmb2024DataSet.Supplier);
                txtAddress.Text = txtEmail.Text = txtName.Text = txtNumber.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Error in adding the supplier");
            }
        }
    }
}
