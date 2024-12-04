using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace M2_Project
{
    public partial class Sales_Details : Form
    {
        public Sales_Details()
        {
            InitializeComponent();
            PopulateDataGridViews();
        }

        private void PopulateDataGridViews()
        {
            try
            {
                // Connection string for your SQL Server database
                string connectionString = "Data Source=146.230.177.46;Initial Catalog=G4Pmb2024;User ID=G4Pmb2024;Password=9u2eop";

                // SQL query to retrieve all data from the Sale table
                string queryStringAll = "SELECT * FROM Sale";

                // SQL query to retrieve top 5 sales by sale amount
                string queryStringTop5 = "SELECT TOP 5 * FROM Sale ORDER BY saleAmount DESC";

                // Create a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create a DataAdapter to fetch data for all sales
                    SqlDataAdapter adapterAll = new SqlDataAdapter(queryStringAll, connection);

                    // Create a DataTable to hold the data for all sales
                    DataTable dataTableAll = new DataTable();

                    // Fill the DataTable with data from the database for all sales
                    adapterAll.Fill(dataTableAll);

                    // Bind the DataTable to dataGridView1 for all sales (assuming dataGridView1 is already defined in the form designer)
                    dataGridView1.DataSource = dataTableAll;

                    // Create a DataAdapter to fetch data for top 5 sales
                    SqlDataAdapter adapterTop5 = new SqlDataAdapter(queryStringTop5, connection);

                    // Create a DataTable to hold the data for top 5 sales
                    DataTable dataTableTop5 = new DataTable();

                    // Fill the DataTable with data from the database for top 5 sales
                    adapterTop5.Fill(dataTableTop5);

                    // Bind the DataTable to dataGridView2 for top 5 sales (assuming dataGridView2 is already defined in the form designer)
                    dataGridView2.DataSource = dataTableTop5;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void summaryButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Connection string for your SQL Server database
                string connectionString = "Data Source=146.230.177.46;Initial Catalog=G4Pmb2024;User ID=G4Pmb2024;Password=9u2eop";

                // SQL query to retrieve the day with the highest sale and the number of sales on that day, including day of the week
                string queryStringHighestSalesDay = @"
            SELECT TOP 1 
                CONVERT(date, saleDate) AS SaleDate,
                COUNT(*) AS TotalSales,
                DATENAME(dw, saleDate) AS DayOfWeek
            FROM Sale
            GROUP BY CONVERT(date, saleDate), DATENAME(dw, saleDate)
            ORDER BY COUNT(*) DESC
        ";

                // SQL query to retrieve overall number of sales in the Sale table
                string queryStringOverallSales = "SELECT COUNT(*) AS OverallSales FROM Sale";

                // SQL query to retrieve the customer with the most sales
                string queryStringMostSalesCustomer = @"
            SELECT TOP 1 
                CustomerID, 
                COUNT(*) AS TotalSales 
            FROM Sale 
            GROUP BY CustomerID 
            ORDER BY COUNT(*) DESC
        ";

                // SQL query to retrieve total amount of all sales
                string queryStringTotalAmount = "SELECT SUM(saleAmount) AS TotalAmount FROM Sale";

                // Create a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Hide the DataGridViews
                    label1.Visible = false;
                    label2.Visible = false;
                    dataGridView1.Visible = false;
                    dataGridView2.Visible = false;

                    // Display the summary text at the beginning
                    richTextBox1.Visible = true;
                    richTextBox1.Clear();
                    richTextBox1.SelectionFont = new System.Drawing.Font(richTextBox1.Font, System.Drawing.FontStyle.Bold);
                    richTextBox1.SelectionColor = System.Drawing.Color.Red;
                    richTextBox1.AppendText("Summary\n");
                    richTextBox1.SelectionFont = new System.Drawing.Font(richTextBox1.Font, System.Drawing.FontStyle.Regular);
                    richTextBox1.SelectionColor = System.Drawing.Color.Black;

                    // Execute the query to get the day with the highest sale and the number of sales on that day, including day of the week
                    using (SqlCommand commandHighestSalesDay = new SqlCommand(queryStringHighestSalesDay, connection))
                    {
                        // Execute the query and retrieve the results
                        SqlDataReader readerHighestSalesDay = commandHighestSalesDay.ExecuteReader();

                        // Check if there are any rows returned
                        if (readerHighestSalesDay.Read())
                        {
                            // Retrieve values from the query results
                            DateTime saleDate = Convert.ToDateTime(readerHighestSalesDay["SaleDate"]);
                            int totalSales = Convert.ToInt32(readerHighestSalesDay["TotalSales"]);
                            string dayOfWeek = readerHighestSalesDay["DayOfWeek"].ToString();

                            // Append the information to the RichTextBox
                            richTextBox1.AppendText($"\nDay with Highest Sales:\n");
                            richTextBox1.AppendText($"Date: {saleDate.ToShortDateString()} ({dayOfWeek})\n");
                            richTextBox1.AppendText($"Total Sales: {totalSales}\n");
                        }
                        else
                        {
                            richTextBox1.AppendText("No sales data found.\n");
                        }

                        // Close the reader
                        readerHighestSalesDay.Close();
                    }

                    // Execute the query to get the overall number of sales
                    using (SqlCommand commandOverallSales = new SqlCommand(queryStringOverallSales, connection))
                    {
                        // Execute the query and retrieve the result
                        object overallSalesObject = commandOverallSales.ExecuteScalar();

                        // Check if the result is not null
                        if (overallSalesObject != DBNull.Value)
                        {
                            // Convert the result to integer
                            int overallSales = Convert.ToInt32(overallSalesObject);

                            // Append the overall number of sales to the RichTextBox
                            richTextBox1.AppendText($"\nOverall Number of Sales: {overallSales}\n");
                        }
                    }

                    // Execute the query to get the customer with the most sales
                    using (SqlCommand commandMostSalesCustomer = new SqlCommand(queryStringMostSalesCustomer, connection))
                    {
                        // Execute the query and retrieve the results
                        SqlDataReader readerMostSalesCustomer = commandMostSalesCustomer.ExecuteReader();

                        // Check if there are any rows returned
                        if (readerMostSalesCustomer.Read())
                        {
                            // Retrieve the values from the query results
                            int customerId = Convert.ToInt32(readerMostSalesCustomer["CustomerID"]);
                            int mostSales = Convert.ToInt32(readerMostSalesCustomer["TotalSales"]);

                            // Append the information about the customer with the most sales to the RichTextBox
                            richTextBox1.AppendText($"\nCustomer with Most Sales (CustomerID: {customerId}): {mostSales} sales\n");
                        }
                        else
                        {
                            richTextBox1.AppendText("\nNo customer with sales found.\n");
                        }

                        // Close the reader
                        readerMostSalesCustomer.Close();
                    }

                    // Execute the query to get the total amount of all sales
                    using (SqlCommand commandTotalAmount = new SqlCommand(queryStringTotalAmount, connection))
                    {
                        // Execute the query and retrieve the result
                        object totalAmountObject = commandTotalAmount.ExecuteScalar();

                        // Check if the result is not null
                        if (totalAmountObject != DBNull.Value)
                        {
                            // Convert the result to decimal
                            decimal totalAmount = Convert.ToDecimal(totalAmountObject);

                            // Append the total amount of all sales to the RichTextBox
                            richTextBox1.AppendText($"\nTotal Amount of All Sales: R {totalAmount}\n");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
