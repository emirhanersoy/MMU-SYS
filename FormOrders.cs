using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototype_BM102
{
    public partial class FormOrders : Form
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\InventoryDB.mdf;Integrated Security=True";
        private SqlConnection connection;
        public FormOrders()
        {
            InitializeComponent();
            LoadDataToDataGridView();
        }

        private void imagecontrolReturn_Click(object sender, EventArgs e)
        {
            Form_Main formMain = new Form_Main();
            formMain.FormClosed += FormMain_FormClosed;
            formMain.Show();
            this.Hide();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // connection.Close();
            Application.Exit();
        }

        private void imagecontrolAdd_Click(object sender, EventArgs e)
        {
            FormAddOrder formAddOrder = new FormAddOrder();
            formAddOrder.RefreshDataGrid += FormAddOrders_RefreshDataGrid; // Olaya abone ol
            formAddOrder.Show();
        }






        private void FormAddOrders_RefreshDataGrid(object sender, EventArgs e)
        {
            RefreshDataGridView(); // DataGridView'i yenile
        }

        public void RefreshDataGridView()
        {
            
            string query = "SELECT [OrderDate], [CustomerName], [ID], [ProductName], [ProductQuantity], [TotalValue] FROM OrdersTable";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dgvOrders.DataSource = dataTable;
                connection.Close();
            }

        }

        private void LoadDataToDataGridView()
        {
            
            string query = "SELECT [OrderDate], [CustomerName], [ID], [ProductName], [ProductQuantity], [TotalValue] FROM OrdersTable";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dgvOrders.DataSource = dataTable;
                connection.Close();
            }

        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }
    }
}
