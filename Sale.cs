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
    public partial class Sale : Form
    {
        public static double total_amount_save = 0;
        public static double total_amount = 0;
        public static int customerId = -1;
        public static int points;
        public static double pointsAmount = 0;
        public static double change;
        public static string customerName;
        public static string customerLastname;
        public static int items;
        public static string date;
        public static int employeeid;
        public static int salesid;
        public static bool isRedeemed = false;
        private object MainClass;

        public Sale()
        {
            InitializeComponent();
            label13.Text = "R 0.00";
            label14.Text = "R 0.00";
            label15.Text = "R 0.00";
            label19.Text = "";
            label17.Text = "1";
            label18.Text = "1";
        }

        private void Sale_Load(object sender, EventArgs e)
        {

            customerTableAdapter.Fill(g4Pmb2024DataSet.Customer);


            // TODO: This line of code loads data into the 'g4Pmb2024DataSet.OrderedItem' table. You can move, or remove it, as needed.
            this.orderedItemTableAdapter.Fill(this.g4Pmb2024DataSet.OrderedItem);
     
            // TODO: This line of code loads data into the 'g4Pmb2024DataSet21.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.g4Pmb2024DataSet1.Inventory);
            // TODO: This line of code loads data into the 'g4Pmb2024DataSet1.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.g4Pmb2024DataSet1.Inventory);
            // TODO: This line of code loads data into the 'g4Pmb2024DataSet.Sale' table. You can move, or remove it, as needed.
            this.saleTableAdapter.Fill(this.g4Pmb2024DataSet.Sale);
            //customerTableAdapter.Fill(g4Pmb2024DataSet.Customer);
            saleTableAdapter.Fill(g4Pmb2024DataSet.Sale);

            //form
            date = DateTime.Now.ToString("dd/MM/yyyy,hh:mm");
            label9.Text = DateTime.Now.ToString("dddd,dd MMM yyyy,hh:mm");
            label12.Text = "R 0.00";
            //label17.Text = label18.Text = MainClass.ToString();
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            // customerTableAdapter.FillBySurname(g4Pmb2024DataSet.Customer, txtSurname.Text);
            customerTableAdapter.FillBySurname(g4Pmb2024DataSet.Customer, txtSurname.Text);

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            customerId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            customerName = (string)dataGridView1.CurrentRow.Cells[1].Value;
            customerLastname = (string)dataGridView1.CurrentRow.Cells[2].Value;
            points = (int)dataGridView1.CurrentRow.Cells[5].Value;
            saleTableAdapter.FillBy(g4Pmb2024DataSet.Sale, (int)dataGridView1.CurrentRow.Cells[0].Value);
            pointsAmount = 0.15 * points;
            label14.Text = "R " + pointsAmount.ToString();
            g4Pmb2024DataSet.OrderDetails.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            inventoryTableAdapter.FillByDescription(g4Pmb2024DataSet1.Inventory, textBox1.Text);
        }
        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            if (txtCash.Text.TrimStart() != "")
            {
                try
                {
                    double cash = double.Parse(txtCash.Text);
                    change = cash - total_amount;
                }
                catch
                {
                    MessageBox.Show("Please enter correct amout of cash");
                }
                label13.Text = "R" + change.ToString();
            }
            else
            {
                label13.Text = "R 0.00";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (pointsAmount == 0) return;

            isRedeemed = true;
            total_amount = total_amount - pointsAmount;
            label12.Text = "R " + total_amount;
            pointsAmount = 0;

            if (txtCash.Text.TrimStart() != "")
            {
                double cash = double.Parse(txtCash.Text);
                change = cash - total_amount;
                label13.Text = "R " + change.ToString();
            }
            else
            {
                label13.Text = "R 0.00";
            }
            label15.Text = "R " + total_amount * 0.14;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (total_amount <= 0)
            {
                MessageBox.Show("No Products has been selected");
                return;

            }
            int cash;
            bool valid = int.TryParse(txtCash.Text.ToString(), out cash);
            if (!valid)
            {
                MessageBox.Show("Enter a correct money amount");
                return;
            }
            if (txtCash.Text.TrimStart() != "" && cash >= total_amount)
            {
                DialogResult dialogResult;
                if (customerId != -1)
                    dialogResult = MessageBox.Show("Confirm Order to " + customerName.Trim() + " " + customerLastname.Trim() + " for an amount of R" + total_amount, "Order Confirmation", MessageBoxButtons.YesNo);

                else
                    dialogResult = MessageBox.Show("Confirm Order for an amount of R" + total_amount, " Order Confirmation", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    //Update all affected tables in the database
                    label12.Text = "R 0.00";//total_amount
                    label13.Text = "R 0.00";
                    label15.Text = "R 0.00";
                    label19.Text = "";
                    txtCash.Text = "";
                    label14.Text = "R 0.00";

                    //4
                    if (customerId != -1)
                        saleTableAdapter.Insert(customerId, 1, Convert.ToDecimal(total_amount), dataGridView1.CurrentRow.Cells[5].Value.ToString(), items, DateTime.Now);
                    else
                        saleTableAdapter.Insert((int)dataGridView1.CurrentRow.Cells[0].Value, 5, Convert.ToDecimal(total_amount), dataGridView1.CurrentRow.Cells[5].Value.ToString(), 0, DateTime.Now);

                    //Inserting into the Ordered items table using the invoice datagridview
                    int lastID = int.Parse(saleTableAdapter.ScalarQuery().ToString());
                    for (int i = 0; i < g4Pmb2024DataSet.Invoice.Rows.Count; i++)
                    {
                        // MessageBox.Show(lastID+"---"+ groupPmb3DataSet.Invoice.Rows[i][0].ToString()+"---"+ groupPmb3DataSet.Invoice.Rows[i][3].ToString()+"---"+ groupPmb3DataSet.Invoice.Rows[i][2].ToString());
                      orderedItemTableAdapter.Insert(lastID, Convert.ToInt32(g4Pmb2024DataSet.Invoice.Rows[i][0]), Convert.ToInt32(g4Pmb2024DataSet.Invoice.Rows[i][3]), Convert.ToDecimal(Convert.ToDecimal(g4Pmb2024DataSet.Invoice.Rows[i][2].ToString()) * int.Parse(g4Pmb2024DataSet.Invoice.Rows[i][3].ToString())));

                    }
                    //clear the invoice datagridview
                    g4Pmb2024DataSet.Invoice.Clear();
                    //fill the orders table
                    saleTableAdapter.FillBySaleID(g4Pmb2024DataSet.Sale, int.Parse(saleTableAdapter.ScalarQuery().ToString()));
                    orderDetailsTableAdapter.Fill(g4Pmb2024DataSet.OrderDetails, int.Parse(saleTableAdapter.ScalarQuery().ToString()));
           
                    //manage the points
                    if (isRedeemed)
                    {
                        label14.Text = "R 0.00";
                        customerTableAdapter.UpdateQuery(items, Convert.ToInt32(customerId), Convert.ToInt32(customerId));
                    }
                    else
                    {
                        if (points + items > 120)
                            customerTableAdapter.UpdateQuery(Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value), Convert.ToInt32(customerId), Convert.ToInt32(customerId));

                        else
                            customerTableAdapter.UpdateQuery(Convert.ToInt32(points + items), Convert.ToInt32(customerId), Convert.ToInt32(customerId));
                    }
                    total_amount_save = total_amount;
                    total_amount = 0;
                    items = 0;
                    customerId = -1;
                    //
                }
            }
            else
            {
                MessageBox.Show("Please enter correct cash amount");
            }
            btnReceipt.Enabled = true;
        }
        private void dataGridView3_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // ingredientTableAdapter1.Fill(g4Pmb2024DataSet.Ingredient, int.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString()));
            double current_price = double.Parse(dataGridView3.CurrentRow.Cells[2].Value.ToString());
            total_amount = total_amount + current_price;
            label12.Text = "R " + total_amount.ToString("0.00"); // Displaying total_amount with 2 decimal places
            label15.Text = "R " + (total_amount * 0.14).ToString("0.00"); // Displaying 14% of total_amount with 2 decimal places
            items = items + 1;
            label19.Text = (int.Parse(saleTableAdapter.ScalarQuery().ToString()) + 1).ToString();

            DataRow dr;
            dr = g4Pmb2024DataSet.Invoice.NewRow();
            int temp = int.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            dr[0] = dataGridView3.CurrentRow.Cells[0].Value;
            dr[1] = dataGridView3.CurrentRow.Cells[1].Value;
            dr[2] = dataGridView3.CurrentRow.Cells[2].Value;

            // Since there's no ingredient-related table, removing the code that interacts with it
            inventoryTableAdapter.Decrease(Convert.ToInt32(dr[0]));
            this.inventoryTableAdapter1.Fill(this.g4Pmb2024DataSet2.Inventory);
            bool contains = false;
            int index = 0;
            for (int i = 0; i < g4Pmb2024DataSet.Ingredient.Rows.Count; i++)
            {
                int stockID = int.Parse(g4Pmb2024DataSet.Ingredient.Rows[i][1].ToString());
                stockTableAdapter.UpdateQuery(int.Parse(g4Pmb2024DataSet.Ingredient.Rows[i][2].ToString()), stockID);
            }
            for (int i = 0; i < g4Pmb2024DataSet.Invoice.Rows.Count; i++)
            {
                if (g4Pmb2024DataSet.Invoice.Rows[i][0].ToString().Equals(dr[0].ToString()))
                {
                    contains = true;
                    index = i;
                    break;
                }
            }
            if (contains)
                g4Pmb2024DataSet.Invoice.Rows[index][3] = int.Parse(g4Pmb2024DataSet.Invoice.Rows[index][3].ToString()) + 1;
            else
            {
                dr[3] = 1;
                g4Pmb2024DataSet.Invoice.Rows.Add(dr);
            }
            inventoryTableAdapter1.FillBy(g4Pmb2024DataSet2.Inventory);
            //  productTableAdapter.FillBy(groupPmb3DataSet11.Product);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCash.Clear();
            total_amount = 0;
            label12.Text = "R 0.00";
            label13.Text = "R 0.00";
            label15.Text = "R 0.00";
            label19.Text = "";
            /* for (int i = 0; i < g4Pmb2024DataSet2.Inventory.Rows.Count; i++)
             {
                 //ingredientTableAdapter.Fill(g4Pmb2024DataSet.Ingredient, (g4Pmb2024DataSet1.Inventory.Rows[i][0].ToString()));
                 if (g4Pmb2024DataSet.Ingredient.Rows.Count != 0)
                 {
                     for (int j = 0; j < g4Pmb2024DataSet.Ingredient.Rows.Count; j++)
                     {
                         int stockID = int.Parse(g4Pmb2024DataSet.Ingredient.Rows[j][1].ToString());
                         stockTableAdapter.Increase(int.Parse(g4Pmb2024DataSet.Ingredient.Rows[j][2].ToString()) * int.Parse(g4Pmb2024DataSet2.Inventory.Rows[i][3].ToString()), stockID);
                     }

                 }
                 inventoryTableAdapter2.UpdateQuery(g4Pmb2024DataSet2.Inventory.Rows[i][3].ToString(), Convert.ToInt32(g4Pmb2024DataSet1.Inventory.Rows[i][0]));
             }*/
            g4Pmb2024DataSet.Invoice.Clear();
            inventoryTableAdapter.Fill(g4Pmb2024DataSet1.Inventory);
            items = 0;
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Suit Detail", 400, 500);
            printPreviewDialog1.ShowDialog();
            button3.Enabled = false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int v = 0;
            double total = total_amount_save;
            string x = DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString();
            e.Graphics.DrawString("SAM'S Liquor", new Font("Arial", 15, FontStyle.Bold), Brushes.DarkBlue, new Point(10, 30));
            e.Graphics.DrawString("Scottville, 107 King Edward Avenue", new Font("Arial", 12, FontStyle.Italic), Brushes.DarkBlue, new Point(10, 60)); // Adjusted Y coordinate
            e.Graphics.DrawString("Order No:" + int.Parse(saleTableAdapter.ScalarQuery().ToString()) + "      " + x, new Font("Arial", 12), Brushes.Black, new Point(10, 90)); // Adjusted Y coordinate
            for (int i = 0; i < g4Pmb2024DataSet.OrderDetails.Rows.Count; i++)
            {
                e.Graphics.DrawString(g4Pmb2024DataSet.OrderDetails.Rows[i][0].ToString() + "    x     " + g4Pmb2024DataSet.OrderDetails.Rows[i][2].ToString() + "      R" + g4Pmb2024DataSet.OrderDetails.Rows[i][1].ToString(), new Font("Arial", 10), Brushes.Black, new Point(10, 120 + v));
                v += 20;
            }
            e.Graphics.DrawString("Total Order Amount : R" + total_amount_save + "", new Font("Arial", 12), Brushes.Green, new Point(10, v + 140));
            e.Graphics.DrawString("Paid : R" + (change + total_amount_save) + "", new Font("Arial", 12), Brushes.Blue, new Point(10, v + 160));
            e.Graphics.DrawString("Change : R" + change + "", new Font("Arial", 12), Brushes.Red, new Point(10, v + 180));
            // Adding "Don't drink and drive" with smaller font and different color
            v += 200; // Incrementing v to create space between previous text and this one
            e.Graphics.DrawString("Don't drink and drive", new Font("Arial", 8), Brushes.Gray, new Point(10, v));

            //e.Graphics.DrawString("Order By :" + MainClass.ToString(), new Font("Arial", 12), Brushes.Black, new Point(10, v + 160));
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            customerId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            customerName = (string)dataGridView1.CurrentRow.Cells[1].Value;
            customerLastname = (string)dataGridView1.CurrentRow.Cells[2].Value;
            points = (int)dataGridView1.CurrentRow.Cells[6].Value;
            saleTableAdapter.FillBy(g4Pmb2024DataSet.Sale, (int)dataGridView1.CurrentRow.Cells[0].Value);
            pointsAmount = 0.15 * points;
            label14.Text = "R " + pointsAmount.ToString();
            g4Pmb2024DataSet.OrderDetails.Clear();

        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            orderDetailsTableAdapter.Fill(g4Pmb2024DataSet.OrderDetails, id);

        }

        private void dataGridView4_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
           // ingredientTableAdapter1.Fill(g4Pmb2024DataSet.Ingredient, int.Parse(dataGridView4.CurrentRow.Cells[0].Value.ToString()));
            int id = int.Parse(dataGridView4.CurrentRow.Cells[0].Value.ToString());
            int remove = (int)MessageBox.Show("Remove item from the list?", "Remove", MessageBoxButtons.YesNo);
            if (remove == 6)
            {
                for (int i = 0; i < g4Pmb2024DataSet.Ingredient.Rows.Count; i++)
                {
                    int stockID = int.Parse(g4Pmb2024DataSet.Ingredient.Rows[i][1].ToString());
                    stockTableAdapter.Increase(int.Parse(g4Pmb2024DataSet.Ingredient.Rows[i][2].ToString()), stockID);
                }
                int rowIndex = dataGridView4.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView4.Rows[rowIndex];
                object rowData = selectedRow.DataBoundItem;
                total_amount = total_amount - Convert.ToDouble(dataGridView4.CurrentRow.Cells[2].Value.ToString());

                if (int.Parse(dataGridView4.CurrentRow.Cells[3].Value.ToString()) == 1)
                    dataGridView4.Rows.RemoveAt(rowIndex);
                else
                    dataGridView4.CurrentRow.Cells[3].Value = int.Parse(dataGridView4.CurrentRow.Cells[3].Value.ToString()) - 1;
                dataGridView4.Refresh();
                label12.Text = total_amount + "";
                label15.Text = "R " + total_amount * 0.14;
                //inventoryTableAdapter2.UpdateQuery(1.ToString(), id);
                inventoryTableAdapter2.Fill(g4Pmb2024DataSet.Inventory);
            }

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.CurrentCell.Equals(dataGridView4.CurrentRow.Cells[4]) && dataGridView4.CurrentRow.Cells[0].Value.ToString().Length != 0)
            {
               // ingredientTableAdapter1.Fill(g4Pmb2024DataSet.Ingredient, int.Parse(dataGridView4.CurrentRow.Cells[0].Value.ToString()));
                for (int i = 0; i < g4Pmb2024DataSet.Ingredient.Rows.Count; i++)
                {
                    int stockID = int.Parse(g4Pmb2024DataSet.Ingredient.Rows[i][1].ToString());
                    stockTableAdapter.Increase(int.Parse(g4Pmb2024DataSet.Ingredient.Rows[i][2].ToString()) * int.Parse(dataGridView4.CurrentRow.Cells[3].Value.ToString()), stockID);
                }
                items -= int.Parse(dataGridView4.CurrentRow.Cells[3].Value.ToString());
                total_amount -= Convert.ToDouble(dataGridView4.CurrentRow.Cells[3].Value.ToString()) * Convert.ToDouble(dataGridView4.CurrentRow.Cells[2].Value.ToString());
               // inventoryTableAdapter2.UpdateQuery((dataGridView4.CurrentRow.Cells[3].Value.ToString()), Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value));
                dataGridView4.Rows.RemoveAt(dataGridView4.SelectedCells[0].RowIndex);
                inventoryTableAdapter2.Fill(g4Pmb2024DataSet.Inventory);
                label12.Text = total_amount + "";
                txtCash_TextChanged(sender, e);
                label15.Text = "R " + (total_amount * 0.14).ToString();
            }

        }
    }

}
