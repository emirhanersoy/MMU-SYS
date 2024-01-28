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

    public partial class FormCategories : Form
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\InventoryDB.mdf;Integrated Security=True";
        private SqlConnection connection;
        public event EventHandler RefreshDataGrid; // DataGrid'i yenilemek için referans
        public FormCategories()
        {
            InitializeComponent();
            // SqlConnection nesnesini oluştur ve bağlantı dizesini ayarla
            connection = new SqlConnection(ConnectionString);

            // DataGridView'e verileri yükle
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
            connection.Close(); // Bağlantıyı kapat
            Application.Exit(); // Uygulamayı kapat
        }
        private void imagecontrolAdd_Click(object sender, EventArgs e)
        {
            FormAddCategory formaddcategory = new FormAddCategory();
            formaddcategory.RefreshDataGrid += FormAddCategory_RefreshDataGrid; // Olaya abone ol
            formaddcategory.Show();
        }
        private void FormAddCategory_RefreshDataGrid(object sender, EventArgs e)
        {
            RefreshDataGridView(); // DataGridView'i yenile
        }
        private void RefreshDataGridView()
        {
            string query = "SELECT [Kategori] FROM CategoriesTable";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            dgvCategories.DataSource = dataTable;
        }
        private void LoadDataToDataGridView()
        {
            string query = "SELECT [Kategori] FROM CategoriesTable";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            dgvCategories.DataSource = dataTable;

        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategories.Columns[e.ColumnIndex].Name;
            if (colName == "dgvCategoryDelete")
            {
                if (MessageBox.Show("Kategoriyi silmek istediğinize emin misiniz", "Kategori Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {


                    // Seçilen satırın ürün kodunu al
                    string category = dgvCategories.Rows[e.RowIndex].Cells["dgvCategory"].Value.ToString();

                    // Ürünü veritabanından sil
                    DeleteProduct(category);



                }
            }

        }
        private void DeleteProduct(string category)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "DELETE FROM CategoriesTable WHERE [Kategori] = @Kategori";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Kategori", category);
                command.ExecuteNonQuery();
                MessageBox.Show("Kategori başarıyla silindi");
                connection.Close();

                RefreshDataGridView();


            }
        }
    }

}