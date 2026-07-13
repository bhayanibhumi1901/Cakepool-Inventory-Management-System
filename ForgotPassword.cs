using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cakepool_Inventory_System
{
    public partial class ForgotPassword : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HOGVA2M\\SQLEXPRESS;Initial Catalog=cakepoolDB;Integrated Security=True;Pooling=False;");
        string randomCode;
        public static string to;

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (randomCode == VerifyCode.Text.Trim())
            {
                to = ForgotPassEmail.Text.Trim();
                ChangePassword cp = new ChangePassword(to);
                cp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Code. Please try again.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendCode_Click(object sender, EventArgs e)
        {
            string email = ForgotPassEmail.Text.Trim();

            // Validate email format
            if (!Regex.IsMatch(email, @"^[^@\s]+@[a-zA-Z0-9-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Invalid email format or domain.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if email exists in the database
            try
            {
                conn.Open();
                string query = "SELECT COUNT(1) FROM dbo.UsersData WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
               

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    SendVerificationCode(email);
                }
                else
                {
                    MessageBox.Show("Email not found in the database.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking email: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void SendVerificationCode(string email)
        {
            string from = "jwalant.dobaria@gmail.com";
            string pass = "zust ziok vrqw rbgk";
            string messageBody;

            Random rand = new Random();
            randomCode = rand.Next(100000, 999999).ToString(); // Generates a 6-digit code
            messageBody = "Here is your one-time password reset code for Cakepool Admin Dashboard: " + randomCode;

            MailMessage message = new MailMessage();
            message.To.Add(email);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password Resetting Code";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                // Demo Mode (GitHub Version)
                MessageBox.Show(
                    "Verification code generated successfully!\n\nOTP: " + randomCode,
                    "Forgot Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
