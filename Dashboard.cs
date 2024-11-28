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
    public partial class Dashboard : Form
    {
        private string connect = "Server=localhost;Database=SalesInventory;Uid=root;Pwd= bhoszbrian123;";
        public Dashboard()
        {
            InitializeComponent();
        }



        private void lblDashBoard_Click(object sender, EventArgs e)
        {

        }

        private void btnViewAccounts_Click(object sender, EventArgs e)
        {

            ViewAccount();

        }

        private void gridViewAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewAccount()
        {

            MySqlConnection conn = new MySqlConnection(connect);
            // Fetch books from the database and display in DataGridView
            try
            {
                conn.Open();

                // SQL query to fetch all books
                string query = "SELECT * FROM users";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // Fill a DataTable with the result of the query
                DataTable booksTable = new DataTable();
                adapter.Fill(booksTable);

                // Display the data in the DataGridView
                gridViewAccounts.DataSource = booksTable;

                MessageBox.Show("Books loaded successfully!");
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

        private void lblMaintenance_Click(object sender, EventArgs e)
        {
            Maintenance mn = new Maintenance();
            this.Hide();
            mn.ShowDialog();
            this.Close();
        }

        private void lblDelivery_Click(object sender, EventArgs e)
        {
            Delivery d = new Delivery();
            this.Hide();
            d.ShowDialog();
            this.Close();
        }

        private void lblInventoryMonitoring_Click(object sender, EventArgs e)
        {
            InventoryMonitoring inventoryMonitoring = new InventoryMonitoring();
            this.Hide();
            inventoryMonitoring.ShowDialog();
            this.Close();
        }

        private void lblPointOfSales_Click(object sender, EventArgs e)
        {
            PointOfSales pos = new PointOfSales();
            this.Hide();
            pos.ShowDialog();
            this.Close();
        }

        private void lblSalesMonitoring_Click(object sender, EventArgs e)
        {
            SalesMonitoring sm = new SalesMonitoring();
            this.Hide();
            sm.ShowDialog();
            this.Close();
        }
    }
}

