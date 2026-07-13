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
    public partial class AddUsers : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HOGVA2M\\SQLEXPRESS;Initial Catalog=cakepoolDB;Integrated Security=True;Pooling=False;");
        public AddUsers()
        {
            InitializeComponent();
            AllUsersData.CellClick += AllUsersData_CellClick; // CellClick event handler
        }

        private void AddUsers_Load(object sender, EventArgs e)
        {
            LoadData(); // Load data when the form loads
        }

        private void AddUsersPassVisibilityCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (AddUsersPassVisibilityCheck.Checked)
            {
                AddUsersPassText.UseSystemPasswordChar = false;
            }
            else
            {
                AddUsersPassText.UseSystemPasswordChar = true;
            }
        }

        private void AddUser_add_Click(object sender, EventArgs e)
        {
            // Validate and add employee
            if (ValidateInputFields())
            {
                AddUser();
                ClearFields();
                LoadData();
            }
        }

        private void AddUser_update_Click(object sender, EventArgs e)
        {
            if (AllUsersData.SelectedRows.Count > 0)
            {
                UpdateUser();
                ClearFields();
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void AddUser_remove_Click(object sender, EventArgs e)
        {
            if (AllUsersData.SelectedRows.Count > 0)
            { 
                RemoveUser();
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void AddUser_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private bool ValidateInputFields()
        {
            if (FullNameText.Text == "" || RoleBox.Text == "" || ContactText.Text == "" || EmailText.Text == "" || AddUsersUsernameText.Text == "" || AddUsersPassText.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(ContactText.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Contact number must be exactly 10 digits", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(EmailText.Text, @"^[^@\s]+@[a-zA-Z0-9-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Invalid email format or domain.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(AddUsersPassText.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$"))
            {
                MessageBox.Show("Password must be a combination of lowercase, uppercase, numbers, and at least one special character", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void AddUser()
        {
            try
            {
                conn.Open();
                String checkUsername = "SELECT * FROM UsersData WHERE username = @username";
                using (SqlCommand checkUser = new SqlCommand(checkUsername, conn))
                {
                    checkUser.Parameters.AddWithValue("@username", AddUsersUsernameText.Text.Trim());

                    SqlDataAdapter da = new SqlDataAdapter(checkUser);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count >= 1)
                    {
                        MessageBox.Show("Username " + AddUsersUsernameText.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string insertData = "INSERT INTO UsersData (Fullname, Role, Contact, Email, Username, Password, Date) " +
                                            "VALUES(@fullname, @role, @contact, @email, @username, @password, @date)";
                        DateTime date = DateTime.Today;

                        using (SqlCommand cmd = new SqlCommand(insertData, conn))
                        {
                            cmd.Parameters.AddWithValue("@fullname", FullNameText.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", RoleBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@contact", ContactText.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", EmailText.Text.Trim());
                            cmd.Parameters.AddWithValue("@username", AddUsersUsernameText.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", AddUsersPassText.Text.Trim());
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
        private void UpdateUser()
        {
            try
            {
                conn.Open();
                int id = Convert.ToInt32(AllUsersData.SelectedRows[0].Cells["Id"].Value);

                string updateData = "UPDATE UsersData SET Fullname=@fullname, Role=@role, Contact=@contact, " +
                                    "Email=@Email, Username=@username, Password=@password WHERE Id=@id";

                using (SqlCommand cmd = new SqlCommand(updateData, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@fullname", FullNameText.Text.Trim());
                    cmd.Parameters.AddWithValue("@role", RoleBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", ContactText.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", EmailText.Text.Trim());
                    cmd.Parameters.AddWithValue("@username", AddUsersUsernameText.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", AddUsersPassText.Text.Trim());

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
        private void RemoveUser()
        {
            try
            {
                if(MessageBox.Show("Are you sure you want to remove this user ? ", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    int id = Convert.ToInt32(AllUsersData.SelectedRows[0].Cells["Id"].Value);

                    string deleteData = "DELETE FROM UsersData WHERE Id=@id";

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
                string query = "SELECT * FROM UsersData";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                AllUsersData.DataSource = dt;
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
                string query = "SELECT * FROM UsersData WHERE Fullname LIKE @searchTerm OR Contact LIKE @searchTerm OR Username LIKE @searchTerm";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                AllUsersData.DataSource = dt;
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
        private void AllUsersData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AllUsersData.Rows[e.RowIndex];

                // Populate the textboxes with the values from the selected row
                FullNameText.Text = row.Cells["Fullname"].Value.ToString();
                RoleBox.Text = row.Cells["Role"].Value.ToString();
                ContactText.Text = row.Cells["Contact"].Value.ToString();
                EmailText.Text = row.Cells["Email"].Value.ToString();
                AddUsersUsernameText.Text = row.Cells["Username"].Value.ToString();
                AddUsersPassText.Text = row.Cells["Password"].Value.ToString();
            }
        }
        private void ClearFields()
        {
            FullNameText.Clear();
            RoleBox.SelectedIndex = -1;
            ContactText.Clear();
            EmailText.Clear();
            AddUsersUsernameText.Clear();
            AddUsersPassText.Clear();
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            SearchData(SearchText.Text);
        }
    }
}
