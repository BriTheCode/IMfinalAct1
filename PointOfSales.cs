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
    public partial class PointOfSales : Form
    {
        private string connect = "Server=localhost;Database=SalesInventory;Uid=root;Pwd=bhoszbrian123;";
        public PointOfSales()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            Add_PointOfSales adpos = new Add_PointOfSales();
            this.Hide();
            adpos.ShowDialog();
            this.Close();
        }

        private void btnUpdateSales_Click(object sender, EventArgs e)
        {
            DeductSales ds = new DeductSales();
            this.Hide();
            ds.ShowDialog();
            this.Close();
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            ViewPointOfSales();
        }
        private void ViewPointOfSales()
        {

            MySqlConnection conn = new MySqlConnection(connect);
            // Fetch books from the database and display in DataGridView
            try
            {
                conn.Open();

                // SQL query to fetch all books
                string query = "SELECT * FROM Sales";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // Fill a DataTable with the result of the query
                DataTable booksTable = new DataTable();
                adapter.Fill(booksTable);

                // Display the data in the DataGridView
                gridViewPointOfSales.DataSource = booksTable;

                MessageBox.Show("Point Of Sales loaded successfully!");
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
