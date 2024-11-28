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
    public partial class AddSupplies : Form
    {
        private string connect = "Server=localhost;Database=SalesInventory;Uid=root;Pwd=bhoszbrian123;";
        public AddSupplies()
        {
            InitializeComponent();
        }

        private void btnAddSupplies_Click(object sender, EventArgs e)
        {
            AddingSuppliesToDatabase();
        }

        private void AddingSuppliesToDatabase()
        {
            // Retrieve the category name directly from the TextBox
            string supplyName = txtSupplyName.Text.Trim();
            string supplyAddress = txtSupplyAddress.Text.Trim();
            string suplyContact = txtSupplyContact.Text.Trim();

            if (string.IsNullOrEmpty(supplyName) || string.IsNullOrEmpty(supplyAddress) || string.IsNullOrEmpty(suplyContact))
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
                    string query = "INSERT INTO Supplier (SupplierName, Address, ContactNumber) VALUES (@SupplierName, @Address, @ContactNumber)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameter to prevent SQL injection
                        cmd.Parameters.AddWithValue("@SupplierName", supplyName);
                        cmd.Parameters.AddWithValue("@Address", supplyAddress);
                        cmd.Parameters.AddWithValue("@ContactNumber", suplyContact);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Supplies added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Maintenance m = new Maintenance();
                            this.Hide();
                            m.ShowDialog();
                            this.Close();

                            // Optionally, clear the TextBox
                            txtSupplyAddress.Clear();
                            txtSupplyContact.Clear();
                            txtSupplyName.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add Supplies.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
