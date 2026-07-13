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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cakepool_Inventory_System
{
    public partial class ChangePassword : Form
    {
        
        public string sendergmail;
        string Username = ForgotPassword.to;
        public ChangePassword(string gmail)
        {
            InitializeComponent();
            this.sendergmail = gmail;
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                ResetPassword.UseSystemPasswordChar = false;
                ConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                ResetPassword.UseSystemPasswordChar = true;
                ConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (ResetPassword.Text == ConfirmPassword.Text)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HOGVA2M\\SQLEXPRESS;Initial Catalog=cakepoolDB;Integrated Security=True;Pooling=False;"))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("UPDATE UsersData SET Password = @Password WHERE EMAIL = @EMAIL;", conn))
                        {
                            cmd.Parameters.AddWithValue("@Password", ConfirmPassword.Text);
                            cmd.Parameters.AddWithValue("@EMAIL", sendergmail);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Password has been changed successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 f1 = new Form1();
                    this.Hide();
                    f1.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
