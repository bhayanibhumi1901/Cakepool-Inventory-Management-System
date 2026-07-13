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
    public partial class AddProducts : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HOGVA2M\\SQLEXPRESS;Initial Catalog=cakepoolDB;Integrated Security=True;Pooling=False;");
        public AddProducts()
        {
            InitializeComponent();
            AllProductsData.CellClick += AllProductsData_CellClick; // CellClick event handler
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {
            LoadCategories(); // Load categories into the ComboBox when the form loads
            LoadData(); // Load data when the form loads

            // Set the CategoryBox and UnitText to empty when the form loads
            CategoryBox.SelectedIndex = -1; // This will clear the selection in the ComboBox
            UnitText.Clear(); // This will clear the unit text box
        }

        private void AddProducts_add_Click(object sender, EventArgs e)
        {
            // Validate and add employee
            if (ValidateInputFields())
            {
                AddProduct();
                ClearFields();
                LoadData();
            }
        }

        private void AddProducts_update_Click(object sender, EventArgs e)
        {
            if (AllProductsData.SelectedRows.Count > 0)
            {
                UpdateProduct();
                ClearFields();
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void AddProducts_remove_Click(object sender, EventArgs e)
        {
            if (AllProductsData.SelectedRows.Count > 0)
            {
                RemoveProduct();
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void AddProducts_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private bool ValidateInputFields()
        {
            if (ProductText.Text == "" || CategoryBox.Text == "" || QuantityText.Text == "" || PriceText.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void AddProduct()
        {
            try
            {
                conn.Open();
                String checkProduct = "SELECT * FROM Products WHERE Product = @product";
                using (SqlCommand checkPro = new SqlCommand(checkProduct, conn))
                {
                    checkPro.Parameters.AddWithValue("@product", ProductText.Text.Trim());

                    SqlDataAdapter da = new SqlDataAdapter(checkPro);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count >= 1)
                    {
                        MessageBox.Show("Product " + ProductText.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string insertData = "INSERT INTO Products (Product, Category, Unit, Quantity, Price, Date) " +
                                            "VALUES(@product, @category, @unit, @quantity, @price, @date)";
                        DateTime date = DateTime.Today;

                        using (SqlCommand cmd = new SqlCommand(insertData, conn))
                        {
                            cmd.Parameters.AddWithValue("@product", ProductText.Text.Trim());
                            cmd.Parameters.AddWithValue("@category", CategoryBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@unit", UnitText.Text.Trim());
                            cmd.Parameters.AddWithValue("@quantity", QuantityText.Text.Trim());
                            cmd.Parameters.AddWithValue("@price", PriceText.Text.Trim());
                            cmd.Parameters.AddWithValue("@date", date);

                            cmd.ExecuteNonQuery();
                            ClearFields();
                            MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private void UpdateProduct()
        {
            try
            {
                conn.Open();
                int id = Convert.ToInt32(AllProductsData.SelectedRows[0].Cells["Id"].Value);

                string updateData = "UPDATE Products SET Product=@product, Category=@category, Unit=@unit, Quantity=@quantity, Price=@price WHERE Id=@id";

                using (SqlCommand cmd = new SqlCommand(updateData, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@product", ProductText.Text.Trim());
                    cmd.Parameters.AddWithValue("@category", CategoryBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@unit", UnitText.Text.Trim());
                    cmd.Parameters.AddWithValue("@quantity", QuantityText.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", PriceText.Text.Trim());

                    cmd.ExecuteNonQuery();
                    ClearFields();
                    MessageBox.Show("Record updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private void RemoveProduct()
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to remove this product ? ", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    int id = Convert.ToInt32(AllProductsData.SelectedRows[0].Cells["Id"].Value);

                    string deleteData = "DELETE FROM Products WHERE Id=@id";

                    using (SqlCommand cmd = new SqlCommand(deleteData, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        ClearFields();
                        MessageBox.Show("Record deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private void LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Products";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                AllProductsData.DataSource = dt;
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
                AllProductsData.DataSource = dt;
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
        private void AllProductsData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AllProductsData.Rows[e.RowIndex];

                // Populate the textboxes with the values from the selected row
                ProductText.Text = row.Cells["Product"].Value.ToString();
                CategoryBox.Text = row.Cells["Category"].Value.ToString();
                UnitText.Text = row.Cells["Unit"].Value.ToString();
                QuantityText.Text = row.Cells["Quantity"].Value.ToString();
                PriceText.Text = row.Cells["Price"].Value.ToString();
            }
        }
        private void ClearFields()
        {
            ProductText.Clear();
            CategoryBox.SelectedIndex = -1;
            UnitText.Clear();
            QuantityText.Clear();
            PriceText.Clear();
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            SearchData(SearchText.Text);
        }
        private void LoadCategories()
        {
            try
            {
                conn.Open();
                string query = "SELECT Category, Unit FROM Categories";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                CategoryBox.DataSource = dt;
                CategoryBox.DisplayMember = "Category"; // Display the category name
                CategoryBox.ValueMember = "Unit"; // Store the unit as the value
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
        private void CategoryBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Fill the UnitText with the unit corresponding to the selected category
            if (CategoryBox.SelectedValue != null)
            {
                UnitText.Text = CategoryBox.SelectedValue.ToString();
            }
        }
    }
}
