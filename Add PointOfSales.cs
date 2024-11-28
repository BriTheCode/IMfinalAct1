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
    public partial class Add_PointOfSales : Form
    {
        private string connect = "Server=localhost;Database=SalesInventory;Uid=root;Pwd=bhoszbrian123;";
        public Add_PointOfSales()
        {
            InitializeComponent();
        }

        private void btnAddingPos_Click(object sender, EventArgs e)
        {
            AddPosToDatabase();
        }
        private void AddPosToDatabase()
        {
            // Retrieve the inventory quantity directly from the TextBox
            string posId = txtPosID.Text.Trim();
            string posSalesQuantity = txtPosSalesQuantity.Text.Trim();
            string posTotalAmmount = txtPosTotalAmount.Text.Trim();

            // Validate that the input is numeric and not empty
            if (string.IsNullOrEmpty(posId) || (string.IsNullOrEmpty(posSalesQuantity) || (string.IsNullOrEmpty(posTotalAmmount))))
            {
                MessageBox.Show("Please enter a valid numeric Pos Quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connect))
                {
                    conn.Open();

                    // SQL query to insert a new inventory record
                    string query = "INSERT INTO Sales (ItemId, SalesQuantity, TotalAmount) VALUES (@itemId, @SalesQuantity, @TotalAmount)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameter to prevent SQL injection
                        cmd.Parameters.AddWithValue("@itemId", posId);
                        cmd.Parameters.AddWithValue("@SalesQuantity", posSalesQuantity);
                        cmd.Parameters.AddWithValue("@TotalAmount", posTotalAmmount);

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
                            txtPosID.Clear();
                            txtPosSalesQuantity.Clear();
                            txtPosTotalAmount.Clear();
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
