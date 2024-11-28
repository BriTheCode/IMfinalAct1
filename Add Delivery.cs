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
    public partial class Add_Delivery : Form
    {
        private string connect = "Server=localhost;Database=SalesInventory;Uid=root;Pwd=bhoszbrian123;";
        public Add_Delivery()
        {
            InitializeComponent();
        }

        private void txtDeliveryItemId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeliveryQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeliveryAdd_Click(object sender, EventArgs e)
        {
            AddDeliveryToDatabase();
        }

        private void AddDeliveryToDatabase()
        {
            // Retrieve the category name directly from the TextBox
            string deliveryId = txtDeliveryItemId.Text.Trim();
            string deliveryQuantity = txtDeliveryQuantity.Text.Trim();

            if (string.IsNullOrEmpty(deliveryId) || (string.IsNullOrEmpty(deliveryQuantity)))
            {
                MessageBox.Show("Please enter a delivery Quantity or Delivery id.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connect))
                {
                    conn.Open();

                    // SQL query to insert a new Delivery
                    string query = "INSERT INTO Delivery (ItemId,DeliveryQuantity) VALUES (@deliveryId, @Quantity)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameter to prevent SQL injection
                        cmd.Parameters.AddWithValue("@deliveryId", deliveryId);
                        cmd.Parameters.AddWithValue("@Quantity", deliveryQuantity);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Delivery added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Maintenance m = new Maintenance();
                            this.Hide();
                            m.ShowDialog();
                            this.Close();

                            // Optionally, clear the TextBox
                            txtDeliveryItemId.Clear();
                            txtDeliveryQuantity.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add Delivery.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
