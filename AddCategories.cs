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
    public partial class AddCategories : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HOGVA2M\\SQLEXPRESS;Initial Catalog=cakepoolDB;Integrated Security=True;Pooling=False;");
        public AddCategories()
        {
            InitializeComponent();
            AllCategoriesData.CellClick += AllCategoriesData_CellClick; // CellClick event handler
        }

        private void AddCategories_Load(object sender, EventArgs e)
        {
            LoadData(); // Load data when the form loads
        }

        private void AddCategories_add_Click(object sender, EventArgs e)
        {
            // Validate and add employee
            if (ValidateInputFields())
            {
                AddCategory();
                ClearFields();
                LoadData();
            }
        }

        private void AddCategories_update_Click(object sender, EventArgs e)
        {
            if (AllCategoriesData.SelectedRows.Count > 0)
            {
                UpdateCategory();
                ClearFields();
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void AddCategories_remove_Click(object sender, EventArgs e)
        {
            if (AllCategoriesData.SelectedRows.Count > 0)
            {
                RemoveCategory();
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void AddCategories_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private bool ValidateInputFields()
        {
            if (CategoryText.Text == "" || UnitBox.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void AddCategory()
        {
            try
            {
                conn.Open();
                String checkCategory = "SELECT * FROM Categories WHERE category = @category";
                using (SqlCommand checkCat = new SqlCommand(checkCategory, conn))
                {
                    checkCat.Parameters.AddWithValue("@category", CategoryText.Text.Trim());

                    SqlDataAdapter da = new SqlDataAdapter(checkCat);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count >= 1)
                    {
                        MessageBox.Show("Category " + CategoryText.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string insertData = "INSERT INTO Categories (Category, Unit, Date) " +
                                            "VALUES(@category, @unit, @date)";
                        DateTime date = DateTime.Today;

                        using (SqlCommand cmd = new SqlCommand(insertData, conn))
                        {
                            cmd.Parameters.AddWithValue("@category", CategoryText.Text.Trim());
                            cmd.Parameters.AddWithValue("@unit", UnitBox.Text.Trim());
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
        private void UpdateCategory()
        {
            try
            {
                conn.Open();
                int id = Convert.ToInt32(AllCategoriesData.SelectedRows[0].Cells["Id"].Value);

                string updateData = "UPDATE Categories SET Category=@category, Unit=@unit WHERE Id=@id";

                using (SqlCommand cmd = new SqlCommand(updateData, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@category", CategoryText.Text.Trim());
                    cmd.Parameters.AddWithValue("@unit", UnitBox.Text.Trim());

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
        private void RemoveCategory()
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to remove this category ? ", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    int id = Convert.ToInt32(AllCategoriesData.SelectedRows[0].Cells["Id"].Value);

                    string deleteData = "DELETE FROM Categories WHERE Id=@id";

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
                string query = "SELECT * FROM Categories";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                AllCategoriesData.DataSource = dt;
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
                string query = "SELECT * FROM Categories WHERE Category LIKE @searchTerm";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                AllCategoriesData.DataSource = dt;
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
        private void AllCategoriesData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AllCategoriesData.Rows[e.RowIndex];

                // Populate the textboxes with the values from the selected row
                CategoryText.Text = row.Cells["Category"].Value.ToString();
                UnitBox.Text = row.Cells["Unit"].Value.ToString();
            }
        }
        private void ClearFields()
        {
            CategoryText.Clear();
            UnitBox.SelectedIndex = -1;
        }

        private void SearchText_TextChanged_1(object sender, EventArgs e)
        {
            SearchData(SearchText.Text);
        }
    }
}
