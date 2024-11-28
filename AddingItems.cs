using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelaCruz_ProjectAct1
{
    public partial class AddingItems : Form
    {
        private string connect = "Server=localhost;Database=SalesInventory;Uid=root;Pwd=bhoszbrian123;";
        public AddingItems()
        {
            InitializeComponent();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            AddingItemsToDatabase();
        }
        private void AddingItemsToDatabase()
        {
            // Retrieve the category name directly from the TextBox
            string ItemName = txtItemName.Text.Trim();
            string ItemCategoryId = txtCategoryId.Text.Trim();
            string ItemBasePrice = txtItemBasePrice.Text.Trim();

            if (string.IsNullOrEmpty(ItemName) || string.IsNullOrEmpty(ItemCategoryId) || string.IsNullOrEmpty(ItemBasePrice))
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
                    string query = "INSERT INTO Items (ItemName, CategoryId, BasePrice) VALUES (@ItemName, @CategoryId, @BasePrice)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameter to prevent SQL injection
                        cmd.Parameters.AddWithValue("@ItemName", ItemName);
                        cmd.Parameters.AddWithValue("@CategoryId", ItemCategoryId);
                        cmd.Parameters.AddWithValue("@BasePrice", ItemBasePrice);

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
                            txtItemName.Clear();
                            txtItemBasePrice.Clear();
                            txtCategoryId.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add Items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
