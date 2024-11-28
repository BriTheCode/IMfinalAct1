using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DelaCruz_ProjectAct1
{
    public partial class Registration : Form
    {
        private string connect = "Server=localhost;Database=SalesInventory;Uid=root;Pwd= bhoszbrian123;";

        public Registration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string pass = txtPass2.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please fill in all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connect))
                {
                    conn.Open();

                    // Check if the username already exists
                    string checkUserQuery = "SELECT COUNT(*) FROM users WHERE username = @user";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkUserQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@user", username);
                        int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (userExists > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert new user into the database
                    string insertQuery = "INSERT INTO users (username, email, pass) VALUES (@username, @Email, @Pass)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Pass", pass);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optional: Automatically navigate to login form
                        LoginPage login = new LoginPage();
                        this.Hide();
                        login.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            // Navigate to the login form
            LoginPage login = new LoginPage();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
