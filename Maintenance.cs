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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DelaCruz_ProjectAct1
{
    public partial class Maintenance : Form
    {
        private string connect = "Server=localhost;Database=SalesInventory;Uid=root;Pwd= bhoszbrian123;";
        public Maintenance()
        {
            InitializeComponent();
        }

        private void gridViewMaintenance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            AddingCategories();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            AddingSupplies();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            AddingItems();
        }

        private void btnMaintenance_Click(object sender, EventArgs e){
            ViewMaintenance();
        }
        private void AddingCategories()
        {
            AddCategories ac = new AddCategories();
            this.Hide();
            ac.ShowDialog();
            this.Close();


        }
        private void AddingSupplies()
        {
            AddSupplies as1 = new AddSupplies();
            this.Hide();
            as1.ShowDialog();
            this.Close();


        }
        private void AddingItems()
        {
            AddingItems ai = new AddingItems();
            this.Hide();
            ai.ShowDialog();
            this.Close();


        }

        private void btnViewCategories_Click(object sender, EventArgs e)
        {
            ViewCategories();
        }
        private void ViewCategories()
        {

            MySqlConnection conn = new MySqlConnection(connect);
            // Fetch books from the database and display in DataGridView
            try
            {
                conn.Open();

                // SQL query to fetch all books
                string query = "SELECT * FROM ItemCategory";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // Fill a DataTable with the result of the query
                DataTable booksTable = new DataTable();
                adapter.Fill(booksTable);

                // Display the data in the DataGridView
                gridViewMaintenance.DataSource = booksTable;

                MessageBox.Show("Categories loaded successfully!");
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

        private void ViewMaintenance()
        {

            MySqlConnection conn = new MySqlConnection(connect);
            // Fetch books from the database and display in DataGridView
            try
            {
                conn.Open();

                // SQL query to fetch all Maintenance
                string query = "SELECT  i.ItemId , c.CategoryId, c.CategoryName, i.ItemName, i.CategoryId, i.BasePrice FROM Items i\r\n " +
                    "JOIN ItemCategory c ON c.CategoryId = i.CategoryId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // Fill a DataTable with the result of the query
                DataTable maintainanceTable = new DataTable();
                adapter.Fill(maintainanceTable);

                // Display the data in the DataGridView
                gridViewMaintenance.DataSource = maintainanceTable;

                MessageBox.Show("Maintenance loaded successfully!");
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

        private void lblBack_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            this.Hide();
            ds.ShowDialog();
            this.Close();
        }
    }

}


