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
    public partial class FormProducts : Form
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\InventoryDB.mdf;Integrated Security=True";
        private SqlConnection connection;

        public event EventHandler RefreshDataGrid; // DataGrid'i yenilemek için referans

        public FormProducts()
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
            FormAddProduct formaddproduct = new FormAddProduct();
            formaddproduct.RefreshDataGrid += FormAddProduct_RefreshDataGrid; // Olaya abone ol
            formaddproduct.Show();

        }
        private void FormAddProduct_RefreshDataGrid(object sender, EventArgs e)
        {
            RefreshDataGridView(); // DataGridView'i yenile
        }

        //veri ekleyince datagrid yenileme
        public void RefreshDataGridView()
        {
            string query = "SELECT [Ürün Kodu], İsim, Miktar, Fiyat , Kategori FROM ProductTable";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            dgvProducts.DataSource = dataTable;
            FormAddProduct formaddproduct = new FormAddProduct();
            formaddproduct.LoadDataToDropDownList();
        }
        //datagride veri çekme
        private void LoadDataToDataGridView()
        {
            string query = "SELECT [Ürün Kodu], İsim, Miktar, Fiyat , Kategori FROM ProductTable";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            //dgvProducts.AutoGenerateColumns = false;

            dgvProducts.DataSource = dataTable;
            //miktarı 0 olanları kırmızı göster

        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProducts.Columns[e.ColumnIndex].Name;

            if (colName == "dgvDelete")
            {
                if (MessageBox.Show("Ürünü silmek istediğinize emin misiniz", "Ürün Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {


                    // Seçilen satırın ürün kodunu al
                    string productCode = dgvProducts.Rows[e.RowIndex].Cells["dgvID"].Value.ToString();

                    // Ürünü veritabanından sil
                    DeleteProduct(productCode);



                }
            }
            else if (colName == "dgvPencil")
            {
                // Seçilen satırın verilerini al
                string productID = dgvProducts.Rows[e.RowIndex].Cells["dgvID"].Value?.ToString();
                string productName = dgvProducts.Rows[e.RowIndex].Cells["dgvName"].Value?.ToString();
                string productQuantity = dgvProducts.Rows[e.RowIndex].Cells["dgvQty"].Value?.ToString();
                string productPrice = dgvProducts.Rows[e.RowIndex].Cells["dgvPrice"].Value?.ToString();
                string productCategory = dgvProducts.Rows[e.RowIndex].Cells["dgvCategory"].Value?.ToString();

                
                FormEditProduct formEditProduct = new FormEditProduct(productID, productName, productQuantity, productPrice, productCategory);
                
                formEditProduct.ShowDialog();
                

            }
        }
        private void DeleteProduct(string productCode)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "DELETE FROM ProductTable WHERE [Ürün Kodu] = @UrunKodu";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UrunKodu", productCode);
                command.ExecuteNonQuery();
                MessageBox.Show("Ürün başarıyla silindi!");
                connection.Close();
                RefreshDataGridView();


            }
        }
        
    }
}