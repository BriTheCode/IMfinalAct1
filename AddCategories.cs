using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DelaCruz_ProjectAct1
{
    public partial class AddCategories : Form
    {
        private string connect = "Server=localhost;Database=SalesInventory;Uid=root;Pwd=bhoszbrian123;";

        public AddCategories()
        {
            InitializeComponent();
        }

        private void btnAdding_Click(object sender, EventArgs e)
        {
            AddCategoryToDatabase(); // Call the method without parameters
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCategoryToDatabase()
        {
            // Retrieve the category name directly from the TextBox
            string categoryName = txtCategory.Text.Trim();

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please enter a category name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connect))
                {
                    conn.Open();

                    // SQL query to insert a new category
                    string query = "INSERT INTO ItemCategory (CategoryName) VALUES (@CategoryName)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameter to prevent SQL injection
                        cmd.Parameters.AddWithValue("@CategoryName", categoryName);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Maintenance m = new Maintenance();
                            this.Hide();
                            m.ShowDialog();
                            this.Close();

                            // Optionally, clear the TextBox
                            txtCategory.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
