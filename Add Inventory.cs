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
    public partial class Add_Inventory : Form
    {
        private string connect = "Server=localhost;Database=SalesInventory;Uid=root;Pwd=bhoszbrian123;";
        public Add_Inventory()
        {
            InitializeComponent();
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            AddInventoryToDatabase();
        }
        private void AddInventoryToDatabase()
        {
            // Retrieve the inventory quantity directly from the TextBox
            string inventoryQuantity = txtInventoryQuantity.Text.Trim();
            string inventoryID = txtInventoryID.Text.Trim();

            // Validate that the input is numeric and not empty
            if (string.IsNullOrEmpty(inventoryQuantity) || (string.IsNullOrEmpty(inventoryID)))
            {
                MessageBox.Show("Please enter a valid numeric Inventory Quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connect))
                {
                    conn.Open();

                    // SQL query to insert a new inventory record
                    string query = "INSERT INTO Inventory (ItemId, inventoryQuantity) VALUES (@itemId, @quantity)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameter to prevent SQL injection
                        cmd.Parameters.AddWithValue("@quantity", inventoryQuantity);
                        cmd.Parameters.AddWithValue("@itemId", inventoryID);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Inventory Quantity added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Navigate to the Maintenance form
                            Maintenance m = new Maintenance();
                            this.Hide();
                            m.ShowDialog();
                            this.Close();

                            // Clear the TextBox
                            txtInventoryQuantity.Clear();
                            txtInventoryID.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add Quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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













