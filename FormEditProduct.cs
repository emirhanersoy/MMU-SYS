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
using System.Xml.Linq;

namespace prototype_BM102
{
    public partial class FormEditProduct : Form
    {
        //constructor için değişken tanımı
        private string productID;
        private string productName;
        private string productQuantity;
        private string productPrice;
        private string productCategory;

        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\InventoryDB.mdf;Integrated Security=True";
        public event EventHandler RefreshDataGrid; // DataGrid'i yenilemek için referans

        //edit tuşuna basıldığında bilgi çekmek için gereken consturctor
        public FormEditProduct(string id, string name, string quantity, string price, string category)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FormEditProduct_Load);// forma verileri yükleme

            // Değişkenleri atama
            productID = id;
            productName = name;
            productQuantity = quantity;
            productPrice = price;
            productCategory = category;
            
        }
        public void FormEditProduct_Load(object sender, EventArgs e)
        {
            // Verileri TextBox'lara aktar
            textBoxID.Text = productID;
            textBoxProductName.Text = productName;
            textBoxQuantity.Text = productQuantity;
            textBoxPrice.Text = productPrice;
            comboBoxProducts.Text = productCategory;
        }

        private void imagecontrolClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("İşlem iptal edilsin mi?", "İptal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                textBoxID.Clear();
                textBoxProductName.Clear();
                textBoxPrice.Clear();
                textBoxQuantity.Clear();
                this.Hide();
            }
        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxProductName.Clear();
            textBoxPrice.Clear();
            textBoxQuantity.Clear();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string yeniProductID = textBoxID.Text;
            string productName = textBoxProductName.Text;
            string productPrice = textBoxPrice.Text;
            string productQuantity = textBoxQuantity.Text;
            string productCategory = comboBoxProducts.Text;

            if (string.IsNullOrWhiteSpace(yeniProductID) ||
               string.IsNullOrWhiteSpace(productName) ||
               string.IsNullOrWhiteSpace(productPrice) ||
               string.IsNullOrWhiteSpace(productQuantity))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.", "Hatalı girdi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long Price;

            if (!long.TryParse(productPrice, out Price))
            {
                MessageBox.Show("Fiyat bir sayı olmalıdır, lütfen geçerli bir giriş yapınız.", "Hatalı girdi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long Quantity;

            if (!long.TryParse(productQuantity, out Quantity))
            {
                MessageBox.Show("Miktar bir sayı olmalıdır, lütfen geçerli bir giriş yapınız.", "Hatalı girdi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (productQuantity == "0")
            {
                MessageBox.Show("Lütfen geçerli bir miktar giriniz", "Hatalı girdi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                //string query = "UPDATE ProductTable SET [İsim] = @Isim, [Miktar] = @Miktar, [Fiyat] = @Fiyat, [Kategori] = @Kategori WHERE [Ürün Kodu] = @UrunKodu";

                //SqlCommand command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@Isim", productName);
                //command.Parameters.AddWithValue("@Miktar", productQuantity);
                //command.Parameters.AddWithValue("@Fiyat", productPrice);
                //command.Parameters.AddWithValue("@Kategori", productCategory);
                //command.Parameters.AddWithValue("@UrunKodu", productID);
                string query = "UPDATE ProductTable SET [İsim] = @Isim, [Miktar] = @Miktar, [Fiyat] = @Fiyat, [Kategori] = @Kategori, [Ürün Kodu] = @YeniUrunKodu WHERE [Ürün Kodu] = @EskiUrunKodu";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Isim", productName);
                command.Parameters.AddWithValue("@Miktar", productQuantity);
                command.Parameters.AddWithValue("@Fiyat", productPrice);
                command.Parameters.AddWithValue("@Kategori", productCategory);
                command.Parameters.AddWithValue("@YeniUrunKodu", yeniProductID); // Yeni ID değeri
                command.Parameters.AddWithValue("@EskiUrunKodu", productID); //varolan ID değeri

                command.ExecuteNonQuery();

                connection.Close();
                
            }
            MessageBox.Show("Veri başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormProducts formProducts = Application.OpenForms.OfType<FormProducts>().FirstOrDefault();
            formProducts?.RefreshDataGridView();

            this.Close();
        }

        private void FormEditProduct_Load_1(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'inventoryDBDataSet.CategoriesTable' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.categoriesTableTableAdapter.Fill(this.inventoryDBDataSet.CategoriesTable);

        }
    }
}    
