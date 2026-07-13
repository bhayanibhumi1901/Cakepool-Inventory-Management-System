using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cakepool_Inventory_System
{
    public partial class Orders : UserControl
    {
        DataTable CartTable = new DataTable();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HOGVA2M\\SQLEXPRESS;Initial Catalog=cakepoolDB;Integrated Security=True;Pooling=False;");
        decimal unitPrice = 0; // To store the unit price of the selected product
        public Orders()
        {
            InitializeComponent();
            InitializeCartTable();
            CategoryBox.SelectedIndexChanged += new EventHandler(CategoryBox_SelectedIndexChanged);
            ProductBox.SelectedIndexChanged += new EventHandler(ProductBox_SelectedIndexChanged);
            QuantityUpDown.ValueChanged += new EventHandler(QuantityUpDown_ValueChanged); // Event for quantity change
            ProductBox.DropDown += new EventHandler(ProductBox_DropDown); // Event when ProductBox is opened
            AmountText.TextChanged += new EventHandler(AmountText_TextChanged);
        }
        private void InitializeCartTable()
        {
            CartTable.Columns.Add("Id", typeof(int));
            CartTable.Columns.Add("Product", typeof(string));
            CartTable.Columns.Add("Category", typeof(string));
            CartTable.Columns.Add("UnitPrice", typeof(decimal));
            CartTable.Columns.Add("Quantity", typeof(int));
            CartTable.Columns.Add("TotalPrice", typeof(decimal));
        }
        private void Orders_Load(object sender, EventArgs e)
        {
            LoadCategories(); // Load categories into the ComboBox when the form loads
            LoadAllProducts(); // Load data when the form loads
            CategoryBox.SelectedIndex = -1; // This will clear the selection in the ComboBox
        }
        private string GetCategoryByProduct(string product)
        {
            string category = string.Empty;
            try
            {
                conn.Open();
                string query = "SELECT Category FROM Products WHERE Product = @Product";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Product", product);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    category = reader["Category"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching category: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return category;
        }


        private void Orders_add_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields())
            {
                string selectedProduct = ProductBox.SelectedItem.ToString();
                string category = GetCategoryByProduct(selectedProduct); // Fetch category from database

                DataRow row = CartTable.NewRow();
                row["Id"] = CartTable.Rows.Count + 1;
                row["Product"] = selectedProduct;
                row["Category"] = category; // Use fetched category
                row["UnitPrice"] = unitPrice;
                row["Quantity"] = (int)QuantityUpDown.Value;
                row["TotalPrice"] = unitPrice * (int)QuantityUpDown.Value; // Calculate total price

                CartTable.Rows.Add(row);

                // Set the DataSource directly without manual column setup
                ProductCart.DataSource = CartTable;

                // Update the Total Price textbox
                UpdateTotalPriceTextBox();
            }
        }

        private void Orders_remove_Click(object sender, EventArgs e)
        {

        }

        private void Orders_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private bool ValidateInputFields()
        {
            if (CustomerNameText.Text == "" || MobileText.Text == "" || CategoryBox.Text == "" || ProductBox.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void LoadAllProducts()
        {
            try
            {
                conn.Open();
                string query = "SELECT Product, Category, Unit, Quantity, Price FROM Products";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                AvailableProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadCategories()
        {
            try
            {
                conn.Open();
                string query = "SELECT Category FROM Categories";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                CategoryBox.DataSource = dt;
                CategoryBox.DisplayMember = "Category"; // Display the category name
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the ProductBox items when the category changes
            ProductBox.Items.Clear();
            ProductBox.Text = "";  // Ensure the selected text in the ProductBox is also cleared
            ProductBox.SelectedIndex = -1; // Ensure no product is selected after clearing

            // Clear the Quantity and Price fields
            QuantityUpDown.Value = 0; // Reset quantity to 0
            PriceText.Text = "0.00"; // Reset price to 0.00

            if (CategoryBox.SelectedIndex == -1)
            {
                LoadAllProducts(); // Load all products if no category is selected
            }
            else
            {
                string selectedCategory = CategoryBox.Text;
                PopulateProductsComboBox(selectedCategory);
                PopulateAvailableProductsGrid(selectedCategory);
            }
        }

        private void PopulateProductsComboBox(string category)
        {
            try
            {
                conn.Open();
                string query = string.IsNullOrEmpty(category) ? "SELECT Product FROM Products" : "SELECT Product FROM Products WHERE Category = @Category";
                SqlCommand command = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(category))
                {
                    command.Parameters.AddWithValue("@Category", category);
                }

                SqlDataReader reader = command.ExecuteReader();
                ProductBox.Items.Clear();

                // Add the products to the ComboBox
                while (reader.Read())
                {
                    ProductBox.Items.Add(reader["Product"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void PopulateAvailableProductsGrid(string category)
        {
            try
            {
                conn.Open();
                string query = "SELECT Product, Category, Unit, Quantity, Price FROM Products WHERE Category = @Category";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Category", category);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                AvailableProducts.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading available products: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Display error if category is not selected when trying to open the ProductBox
        private void ProductBox_DropDown(object sender, EventArgs e)
        {
            if (CategoryBox.SelectedIndex == -1) // Check if category is selected
            {
                MessageBox.Show("Please select a category first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ProductBox.DroppedDown = false; // Close the drop-down to prevent selection
            }
        }
        private void ProductBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductBox.SelectedIndex != -1)
            {
                string selectedProduct = ProductBox.Text;
                LoadProductPrice(selectedProduct); // Load price for the selected product
            }
        }
        // Load price for the selected product
        private void LoadProductPrice(string product)
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Price FROM Products WHERE Product = @Product";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Product", product);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        unitPrice = Convert.ToDecimal(reader["Price"]); // Get unit price from database
                        UpdatePriceTextBox(); // Update the price based on quantity
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading product price: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void QuantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdatePriceTextBox();
        }
        private void UpdatePriceTextBox()
        {
            decimal quantity = QuantityUpDown.Value; // Get selected quantity
            decimal totalPrice = unitPrice * quantity; // Calculate total price
            PriceText.Text = totalPrice.ToString("F2"); // Display total price in TextBox (read-only)
        }
        private void UpdateTotalPriceTextBox()
        {
            decimal totalPrice = 0;
            foreach (DataRow row in CartTable.Rows)
            {
                totalPrice += Convert.ToDecimal(row["TotalPrice"]);
            }
            TotalPriceText.Text = totalPrice.ToString("F2");
        }
        private void ClearFields()
        {
            CustomerNameText.Clear();
            MobileText.Clear();
            ProductBox.SelectedIndex = -1;
            CategoryBox.SelectedIndex = -1;
            QuantityUpDown.Value = 0;
            PriceText.Clear();
            TotalPriceText.Clear();
            AmountText.Clear();
            ChangeText.Clear();
        }
        private void SearchData(string searchTerm)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Products WHERE Product LIKE @searchTerm OR Category LIKE @searchTerm";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                AvailableProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching data: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            SearchData(SearchText.Text);
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                DateTime date = DateTime.Today;

                foreach (DataRow row in CartTable.Rows)
                {
                    string product = row["Product"].ToString();
                    string category = row["Category"].ToString();
                    decimal unitPrice = Convert.ToDecimal(row["UnitPrice"]);
                    int quantity = Convert.ToInt32(row["Quantity"]);
                    decimal totalPrice = Convert.ToDecimal(row["TotalPrice"]);

                    // Check if the record for the same product exists for the current date
                    string checkQuery = "SELECT Quantity FROM Sales WHERE Product = @Product AND Date = @Date";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Product", product);
                    checkCmd.Parameters.AddWithValue("@Date", date);

                    object result = checkCmd.ExecuteScalar();

                    if (result != null)
                    {
                        // If record exists, update it
                        int existingQuantity = Convert.ToInt32(result);
                        string updateQuery = "UPDATE Sales SET Quantity = @Quantity, TotalPrice = @TotalPrice WHERE Product = @Product AND Date = @Date";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@Product", product);
                        updateCmd.Parameters.AddWithValue("@Quantity", existingQuantity + quantity);
                        updateCmd.Parameters.AddWithValue("@TotalPrice", (existingQuantity + quantity) * unitPrice);
                        updateCmd.Parameters.AddWithValue("@Date", date);

                        updateCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        // If record does not exist, insert new record
                        string insertQuery = "INSERT INTO Sales (Product, Category, UnitPrice, Quantity, TotalPrice, Date) " +
                                              "VALUES (@Product, @Category, @UnitPrice, @Quantity, @TotalPrice, @Date)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@Product", product);
                        insertCmd.Parameters.AddWithValue("@Category", category);
                        insertCmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                        insertCmd.Parameters.AddWithValue("@Quantity", quantity);
                        insertCmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        insertCmd.Parameters.AddWithValue("@Date", date);

                        insertCmd.ExecuteNonQuery();
                    }

                    // *** Additional Code to Update the Product Quantity in the Products Table ***
                    string updateProductQuery = "UPDATE Products SET Quantity = Quantity - @Quantity WHERE Product = @Product";
                    SqlCommand updateProductCmd = new SqlCommand(updateProductQuery, conn);
                    updateProductCmd.Parameters.AddWithValue("@Quantity", quantity);
                    updateProductCmd.Parameters.AddWithValue("@Product", product);

                    // Execute the update query for the Products table
                    updateProductCmd.ExecuteNonQuery();
                }

                // Store Customer Info
                string customerQuery = "INSERT INTO Customers (Customer, Mobile, TotalPrice, Date) VALUES (@Customer, @Mobile, @TotalPrice ,@Date)";
                SqlCommand customerCmd = new SqlCommand(customerQuery, conn);
                customerCmd.Parameters.AddWithValue("@Customer", CustomerNameText.Text);
                customerCmd.Parameters.AddWithValue("@Mobile", MobileText.Text);
                customerCmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDecimal(TotalPriceText.Text));
                customerCmd.Parameters.AddWithValue("@Date", date);
                customerCmd.ExecuteNonQuery();

                MessageBox.Show("Order successfully placed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CartTable.Clear(); // Clear the order table after checkout
                ProductCart.DataSource = null; // Clear the cart UI

                // Clear the input fields for new orders
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during checkout: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void AmountText_TextChanged(object sender, EventArgs e)
        {
            decimal totalPrice = 0;
            decimal amountGiven = 0;

            // Get the total price from TotalPriceText
            if (!decimal.TryParse(TotalPriceText.Text, out totalPrice))
            {
                totalPrice = 0;
            }

            // Get the amount given from AmountText
            if (decimal.TryParse(AmountText.Text, out amountGiven))
            {
                decimal change = amountGiven - totalPrice;
                ChangeText.Text = change >= 0 ? change.ToString("F2") : "0.00"; // Display the change if amount given is greater than total price
            }
            else
            {
                ChangeText.Text = "0.00"; // Display "0.00" if amount given is invalid
            }
        }
    }
}
