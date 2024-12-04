using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace M2_Project
{
    public partial class dashBoard : Form
    {
        public dashBoard()
        {
            InitializeComponent();
        }

        private void dashBoard_Load(object sender, EventArgs e)
        {
            // Call the method to load the number of customers
            LoadNumberOfCustomers();
            LoadTotalNumberOfSales();
            LoadTotalAmountOfSales();
            LoadNumberOfProductsLowQuantity();
            LoadTop3CustomersWithHighestSales();
        }

        private void LoadNumberOfCustomers()
        {
            try
            {
                // Connection string for your SQL Server database
                string connectionString = "Data Source=146.230.177.46;Initial Catalog=G4Pmb2024;User ID=G4Pmb2024;Password=9u2eop";

                // SQL query to retrieve the number of customers
                string queryString = "SELECT COUNT(*) AS NumberOfCustomers FROM Customer";

                // Create a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Create a command to execute the query
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        // Execute the query and retrieve the results
                        SqlDataReader reader = command.ExecuteReader();

                        // Check if there are any rows returned
                        if (reader.Read())
                        {
                            // Retrieve the number of customers from the query results
                            int numberOfCustomers = Convert.ToInt32(reader["NumberOfCustomers"]);

                            // Display the number of customers in a label
                            label1.Text = $" {numberOfCustomers}";
                        }
                        else
                        {
                            // If no rows are returned, display a message
                            MessageBox.Show("No customers found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadTotalNumberOfSales()
        {
            try
            {
                // Connection string for your SQL Server database
                string connectionString = "Data Source=146.230.177.46;Initial Catalog=G4Pmb2024;User ID=G4Pmb2024;Password=9u2eop";

                // SQL query to retrieve the total number of sales
                string queryString = "SELECT COUNT(*) AS TotalNumberOfSales FROM Sale";

                // Create a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Create a command to execute the query
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        // Execute the query and retrieve the results
                        SqlDataReader reader = command.ExecuteReader();

                        // Check if there are any rows returned
                        if (reader.Read())
                        {
                            // Retrieve the total number of sales from the query results
                            int totalNumberOfSales = Convert.ToInt32(reader["TotalNumberOfSales"]);

                            // Display the total number of sales in a label
                            label3.Text = $" {totalNumberOfSales}";
                        }
                        else
                        {
                            // If no rows are returned, display a message
                            MessageBox.Show("No sales found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadTotalAmountOfSales()
        {
            try
            {
                // Connection string for your SQL Server database
                string connectionString = "Data Source=146.230.177.46;Initial Catalog=G4Pmb2024;User ID=G4Pmb2024;Password=9u2eop";

                // SQL query to retrieve the total amount of sales
                string queryString = "SELECT SUM(saleAmount) AS TotalAmount FROM Sale";

                // Create a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Create a command to execute the query
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        // Execute the query and retrieve the results
                        object totalAmountObject = command.ExecuteScalar();

                        // Check if the result is not null
                        if (totalAmountObject != DBNull.Value)
                        {
                            // Convert the result to decimal
                            decimal totalAmount = Convert.ToDecimal(totalAmountObject);

                            // Display the total amount of sales in a label
                            label5.Text = $"R{totalAmount}";
                        }
                        else
                        {
                            // If the result is null, display a message
                            MessageBox.Show("No sales found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadNumberOfProductsLowQuantity()
        {
            try
            {
                // Connection string for your SQL Server database
                string connectionString = "Data Source=146.230.177.46;Initial Catalog=G4Pmb2024;User ID=G4Pmb2024;Password=9u2eop";

                // SQL query to retrieve the number of products with low quantity
                string queryString = "SELECT COUNT(*) AS NumberOfProductsLowQuantity FROM Inventory WHERE QuantityLevels < 20";

                // Create a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Create a command to execute the query
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        // Execute the query and retrieve the results
                        SqlDataReader reader = command.ExecuteReader();

                        // Check if there are any rows returned
                        if (reader.Read())
                        {
                            // Retrieve the number of products with low quantity from the query results
                            int numberOfProductsLowQuantity = Convert.ToInt32(reader["NumberOfProductsLowQuantity"]);

                            // Display the number of products with low quantity in a label
                            label7.Text = $" {numberOfProductsLowQuantity} Products on Low Stock";
                        }
                        else
                        {
                            // If no rows are returned, display a message
                            MessageBox.Show("No products with low quantity found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadTop3CustomersWithHighestSales()
        {
            try
            {
                // Connection string for your SQL Server database
                string connectionString = "Data Source=146.230.177.46;Initial Catalog=G4Pmb2024;User ID=G4Pmb2024;Password=9u2eop";

                // SQL query to retrieve the top 3 customers with the highest sales amount
                string queryString = @"
            SELECT TOP 3 
                c.FirstName,
                SUM(s.saleAmount) AS TotalSaleAmount
            FROM 
                Customer c
            INNER JOIN 
                Sale s ON c.CustomerID = s.CustomerID
            GROUP BY 
                c.FirstName
            ORDER BY 
                TotalSaleAmount DESC";

                // Create a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Create a command to execute the query
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        // Execute the query and retrieve the results
                        SqlDataReader reader = command.ExecuteReader();

                        // Initialize variables to store customer information
                        string topCustomerInfo = "";
                        string secondTopCustomerInfo = "";
                        string thirdTopCustomerInfo = "";

                        // Retrieve top 3 customers with highest sales
                        int count = 1;
                        while (reader.Read())
                        {
                            // Retrieve customer information
                            string firstName = reader["FirstName"].ToString();
                            decimal totalSaleAmount = Convert.ToDecimal(reader["TotalSaleAmount"]);

                            // Format the customer information
                            string customerInfoFormatted = $"{count}. {firstName},\n Total Sale Amount: R {totalSaleAmount}";

                            // Assign customer information to corresponding variables based on count
                            if (count == 1)
                                topCustomerInfo = customerInfoFormatted;
                            else if (count == 2)
                                secondTopCustomerInfo = customerInfoFormatted;
                            else if (count == 3)
                                thirdTopCustomerInfo = customerInfoFormatted;

                            // Increment the count
                            count++;
                        }

                        // Display the customer information in the labels
                        label9.Text = topCustomerInfo;
                        label10.Text = secondTopCustomerInfo;
                        label11.Text = thirdTopCustomerInfo;
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
