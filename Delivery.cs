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
    public partial class Delivery : Form
    {
        private string connect = "Server=localhost;Database=SalesInventory;Uid=root;Pwd=bhoszbrian123;";
        public Delivery()
        {
            InitializeComponent();
        }

        private void btnAddDelivery_Click(object sender, EventArgs e)
        {
            Add_Delivery delivery = new Add_Delivery();
            this.Hide();
            delivery.ShowDialog();
            this.Close();

        }

        private void btnViewDelivery_Click(object sender, EventArgs e)
        {
            ViewDelivery();
        }

        private void ViewDelivery()
        {

            MySqlConnection conn = new MySqlConnection(connect);
            // Fetch books from the database and display in DataGridView
            try
            {
                conn.Open();

                // SQL query to fetch all books
                string query = "SELECT * FROM Delivery";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // Fill a DataTable with the result of the query
                DataTable booksTable = new DataTable();
                adapter.Fill(booksTable);

                // Display the data in the DataGridView
                gridViewDelivery.DataSource = booksTable;

                MessageBox.Show("Delivery loaded successfully!");
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

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            Add_Inventory inventory = new Add_Inventory();
            this.Hide();
            inventory.ShowDialog();
            this.Close();
        }

        private void btnViewInventory_Click(object sender, EventArgs e)
        {
            ViewInventory();
        }

        private void ViewInventory()
        {

            MySqlConnection conn = new MySqlConnection(connect);
            // Fetch books from the database and display in DataGridView
            try
            {
                conn.Open();

                // SQL query to fetch all books
                string query = "SELECT * FROM Inventory";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // Fill a DataTable with the result of the query
                DataTable booksTable = new DataTable();
                adapter.Fill(booksTable);

                // Display the data in the DataGridView
                gridViewDelivery.DataSource = booksTable;

                MessageBox.Show("Inventory loaded successfully!");
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

        private void lblInventoryMonitoring_Click(object sender, EventArgs e)
        {
            InventoryMonitoring inventoryMonitoring = new InventoryMonitoring();
            this.Hide();
            inventoryMonitoring.ShowDialog();
            this.Close();
        }
    }
    }

