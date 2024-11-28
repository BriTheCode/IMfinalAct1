using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DelaCruz_ProjectAct1
{
    public partial class DeductSales : Form
    {
        private string connect = "Server=localhost;Database=SalesInventory;Uid=root;Pwd=bhoszbrian123;";

        public DeductSales()
        {
            InitializeComponent();
        }

        private void txtPosItemID_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add real-time validation if needed
        }

        private void txtDeductSalesQuantity_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add real-time validation if needed
        }

        private void btnAddPos_Click(object sender, EventArgs e)
        {
            DeductBasePrice();
        }

        private void DeductBasePrice()
        {
            // Retrieve inputs
            int itemId;
            decimal deductionAmount;

            if (!int.TryParse(txtPosItemID.Text.Trim(), out itemId))
            {
                MessageBox.Show("Please enter a valid Item ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtDeductSalesQuantity.Text.Trim(), out deductionAmount))
            {
                MessageBox.Show("Please enter a valid deduction amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connect))
                {
                    conn.Open();

                    // SQL query to deduct from BasePrice
                    string query = @"
                        UPDATE Items
                        SET BasePrice = BasePrice - @DeductionAmount
                        WHERE ItemId = @ItemId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@ItemId", itemId);
                        cmd.Parameters.AddWithValue("@DeductionAmount", deductionAmount);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Base price deducted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Transition to the PointOfSales form
                            PointOfSales ps = new PointOfSales();
                            this.Hide();
                            ps.ShowDialog();
                            this.Close(); // Close DeductSales after transitioning
                        }
                        else
                        {
                            MessageBox.Show("No matching Item ID found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
