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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prototype_BM102
{
    public partial class FormAddOrder : Form
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\InventoryDB.mdf;Integrated Security=True";
        private SqlConnection connection;
        public event EventHandler RefreshDataGrid; // DataGrid'i yenilemek için referans
        public FormAddOrder()
        {
            InitializeComponent();
        }

        private void imagecontrolClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("İşlem iptal edilsin mi?", "İptal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                textBoxCustomer.Clear();
                textBoxQty.Clear();
                this.Hide();
            }
        }

        private void FormAddOrder_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'inventoryDBDataSet1.ProductTable' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.productTableTableAdapter.Fill(this.inventoryDBDataSet1.ProductTable);

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string input = textBoxQty.Text;

            if (IsValid(input) || string.IsNullOrWhiteSpace(input))
            {
                string productName = comboBoxName.Text; // Ürün adını ComboBox'tan alma
                string customerName = textBoxCustomer.Text; // Müşteri adını TextBox'tan alma
                int productQuantity = Convert.ToInt32(textBoxQty.Text); // Ürün miktarını TextBox'tan alma
                DateTime orderDate = DateTime.Now; // Şu anki tarih ve saat
                decimal productPrice = 0; // Ürün fiyatını saklamak için bir değişken
                string productID = ""; // ürünün id si

                // Seçili ürünü ProductTable'dan bulma

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT [Fiyat] FROM ProductTable WHERE [İsim] = @ProductName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    SqlDataReader reader = command.ExecuteReader();

                    // Ürün fiyatını alma
                    if (reader.Read())
                    {
                        productPrice = Convert.ToDecimal(reader["Fiyat"]);
                    }

                    reader.Close();
                    connection.Close();
                }

                // Toplam değeri hesaplama
                decimal totalValue = productPrice * productQuantity;
                // isimden ürün ID si çekme
                string getProductCodeQuery = "SELECT [Ürün Kodu] FROM ProductTable WHERE İsim = @ProductName";
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand getCodeCommand = new SqlCommand(getProductCodeQuery, connection);
                    getCodeCommand.Parameters.AddWithValue("@ProductName", productName);
                    SqlDataReader codeReader = getCodeCommand.ExecuteReader();
                    if (codeReader.Read())
                    {
                        productID = codeReader["Ürün Kodu"].ToString();
                    }
                    codeReader.Close();
                }
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Seçili ürünün mevcut miktarını almak için sorgu yapma
                    //string selectQuery = "SELECT [Miktar] FROM ProductTable WHERE [İsim] = @ProductName";
                    //SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                    //selectCommand.Parameters.AddWithValue("@ProductName", productName);
                    //int currentQuantity = Convert.ToInt32(selectCommand.ExecuteScalar());

                    //// Güncellenmiş miktarı hesaplama
                    //int updatedQuantity = currentQuantity - productQuantity;
                    string selectQuery = "SELECT [Miktar] FROM ProductTable WHERE [İsim] = @ProductName";
                    SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@ProductName", productName);
                    int currentQuantity = Convert.ToInt32(selectCommand.ExecuteScalar());

                    // Güncellenmiş miktarı hesaplama
                    int updatedQuantity = currentQuantity - productQuantity;

                    if (updatedQuantity < 0)
                    {
                        MessageBox.Show("Seçilen ürün için yeterli stok mevcut değil!");
                        return;
                    }

                    // Ürün miktarını güncelleme
                    string updateQuery = "UPDATE ProductTable SET [Miktar] = @UpdatedQuantity WHERE [İsim] = @ProductName";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@UpdatedQuantity", updatedQuantity);
                    updateCommand.Parameters.AddWithValue("@ProductName", productName);
                    updateCommand.ExecuteNonQuery();
                }

                // Siparişi OrdersTable tablosuna kaydetme
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO OrdersTable ([OrderDate], [CustomerName], [ID], [ProductName], [ProductQuantity], [TotalValue]) " +
                                   "VALUES (@OrderDate, @CustomerName, @ID, @ProductName, @ProductQuantity, @TotalValue)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@OrderDate", orderDate);
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@ID", productID);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@ProductQuantity", productQuantity);
                    command.Parameters.AddWithValue("@TotalValue", totalValue);
                    command.ExecuteNonQuery();
                    connection.Close();
                    FormOrders formOrders = Application.OpenForms.OfType<FormOrders>().FirstOrDefault();
                    formOrders?.RefreshDataGridView();
                    RefreshDataGrid?.Invoke(this, EventArgs.Empty); // FormProducts formunda DataGrid'i yenilemek için olayı tetikle
                }

                // İşlem tamamlandığında mesaj kutusu gösterme veya başka işlemler gerçekleştirme
                MessageBox.Show("Sipariş başarıyla kaydedildi!");

                // Formu temizleme veya başka işlemler yapma
                // ...
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı girdi, lütfen geçerli bir giriş yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValid(string input)
        {
            if(input == "0")
            {
                // miktar 0 olması durumu
                return false;
            }
            else
            {
                // girdinin karakter kontrolü
                foreach (char c in input)
                {
                    if (!char.IsDigit(c))
                        return false;
                }
                return true;
            }
        }
    }
}
