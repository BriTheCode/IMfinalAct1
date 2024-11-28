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
    public partial class InventoryMonitoring : Form
    {
        private string connect = "Server=localhost;Database=SalesInventory;Uid=root;Pwd=bhoszbrian123;";
        public InventoryMonitoring()
        {
            InitializeComponent();
        }

        private void btnViewInventoryMonitoring_Click(object sender, EventArgs e)
        {
            ViewInventoryMonitoring();
        }

        private void ViewInventoryMonitoring()
        {

            MySqlConnection conn = new MySqlConnection(connect);
            // Fetch books from the database and display in DataGridView
            try
            {
                conn.Open();

                // SQL query to fetch all books
                string query = "SELECT \r\n    Items.ItemId,\r\n  Items.ItemName,\r\n Items.BasePrice,\r\n  Delivery.DeliveryId,\r\n  Delivery.DeliveryDate,\r\n Delivery.DeliveryQuantity,\r\n  Inventory.InventoryId,\r\n   " +
                    " Inventory.inventoryQuantity\r\nFROM \r\n    Items\r\nINNER JOIN \r\n    Delivery ON Items.ItemId = Delivery.ItemId\r\nINNER JOIN \r\n   " +
                    " Inventory ON Items.ItemId = Inventory.ItemId;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // Fill a DataTable with the result of the query
                DataTable booksTable = new DataTable();
                adapter.Fill(booksTable);

                // Display the data in the DataGridView
                gridViewInventoryMonitoring.DataSource = booksTable;

                MessageBox.Show("Inventory Monitoring loaded successfully!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error fetching books: " + ex.Message);
            }
            finally
            {
                conn.Close();  // Ensure connection is closed
            }

        }

        private void gridViewInventoryMonitoring_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
