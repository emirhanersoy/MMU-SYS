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
    public partial class FormUsers : Form
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\InventoryDB.mdf;Integrated Security=True";
        private SqlConnection connection;
        public FormUsers()
        {
            InitializeComponent();
            // SqlConnection nesnesini oluştur ve bağlantı dizesini ayarla
            connection = new SqlConnection(ConnectionString);

            // DataGridView'e verileri yükle
           
            RefreshDataGridView();
        }

        private void imagecontrolReturn_Click(object sender, EventArgs e)
        {
            Form_Main formMain = new Form_Main();
            formMain.FormClosed += FormMain_FormClosed;
            formMain.Show();
            this.Hide();
        }

        private void imagecontrolAdd_Click(object sender, EventArgs e)
        {
            FormAddUser formadduser = new FormAddUser();
            formadduser.Show();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Uygulamayı kapat
        }

        //veri ekleyince datagrid yenileme
        public void RefreshDataGridView()
        {
            string query = "SELECT [username], name, password, phone FROM Login_auth";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            dgvUsers.DataSource = dataTable;
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUsers.Columns[e.ColumnIndex].Name;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;

                if (colName == "dgvDelete")
                {
                    if (MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz", "Kullanıcı Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {


                        // Seçilen satırın kullanıcı adını al
                        string productCode = dgvUsers.Rows[e.RowIndex].Cells["dgvUsername"].Value.ToString();

                        // Ürünü veritabanından sil
                        DeleteProduct(productCode);
                    }
                }
                else if (colName == "dgvPencil")
                {
                    // Seçilen satırın verilerini al
                    string username = dgvUsers.Rows[e.RowIndex].Cells["dgvUsername"].Value?.ToString();
                    string name = dgvUsers.Rows[e.RowIndex].Cells["dgvFullname"].Value?.ToString();
                    string password = dgvUsers.Rows[e.RowIndex].Cells["dgvPassword"].Value?.ToString();
                    string phone = dgvUsers.Rows[e.RowIndex].Cells["dgvPhone"].Value?.ToString();


                    // FormEditProduct formunu aç
                    FormEditUser formEditUser = new FormEditUser(username, name, password, phone);
                    //formEditProduct.Load += FormEditProduct_Load; // Yüklenme olayına abone ol
                    formEditUser.ShowDialog();
                }
            }
        }
        //ürün silme sql
        private void DeleteProduct(string productCode) 
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "DELETE FROM Login_Auth WHERE [username] = @username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", productCode);
                command.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı başarıyla silindi!");

                RefreshDataGridView();


            }
        }
    }
}
