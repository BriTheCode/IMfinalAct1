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
    public partial class SalesMonitoring : Form
    {
        private string connect = "Server=localhost;Database=SalesInventory;Uid=root;Pwd= bhoszbrian123;";
        public SalesMonitoring()
        {
            InitializeComponent();
        }

        private void btnViewSalesMonitoring_Click(object sender, EventArgs e)
        {
            ViewSalesMonitoringToDatabase();
        }
        private void ViewSalesMonitoringToDatabase()
        {

            MySqlConnection conn = new MySqlConnection(connect);
            // Fetch books from the database and display in DataGridView
            try
            {
                conn.Open();

                // SQL query to fetch all books
                string query = "SELECT \r\n    Sales.ReceiptId,\r\n    Sales.ReceiptDate,\r\n   " +
                    " Items.ItemId,\r\n    Items.ItemName,\r\n    Items.CategoryId,\r\n   " +
                    " Items.BasePrice,\r\n    Sales.SalesQuantity,\r\n    Sales.TotalAmount\r\nFROM \r\n   " +
                    " Sales\r\nJOIN \r\n    Items\r\nON \r\n    Sales.ItemId = Items.ItemId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // Fill a DataTable with the result of the query
                DataTable booksTable = new DataTable();
                adapter.Fill(booksTable);

                // Display the data in the DataGridView
                gridViewSalesMonitoring.DataSource = booksTable;

                MessageBox.Show("Sales Monitoring loaded successfully!");
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
    }
}
