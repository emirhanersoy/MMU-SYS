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
    public partial class FormAddProduct : Form
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\InventoryDB.mdf;Integrated Security=True";

        public event EventHandler RefreshDataGrid; // DataGrid'i yenilemek için referans

        public FormAddProduct()
        {
            InitializeComponent();
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
            string productID = textBoxID.Text;
            string productName = textBoxProductName.Text;
            string productPrice = textBoxPrice.Text;
            string productQuantity = textBoxQuantity.Text;
            string productCategory = comboBoxProducts.Text;

            if (string.IsNullOrWhiteSpace(productID) ||
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
                string query = "INSERT INTO ProductTable ([Ürün Kodu], [İsim], [Miktar], [Fiyat], [Kategori]) " +
                               "VALUES (@UrunKodu, @Isim, @Miktar, @Fiyat, @Kategori)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UrunKodu", productID);
                command.Parameters.AddWithValue("@Isim", productName);
                command.Parameters.AddWithValue("@Miktar", productQuantity);
                command.Parameters.AddWithValue("@Fiyat", productPrice);
                command.Parameters.AddWithValue("@Kategori", productCategory);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Veri Başarıyla Eklendi!");

                FormProducts formProducts = Application.OpenForms.OfType<FormProducts>().FirstOrDefault();
                formProducts?.RefreshDataGridView();
                RefreshDataGrid?.Invoke(this, EventArgs.Empty); // FormProducts formunda DataGrid'i yenilemek için olayı tetikle

                this.Close();
            }

        }
        public void LoadDataToDropDownList()
        {
            string query = "SELECT Kategori FROM CategoriesTable";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                comboBoxProducts.DataSource = dataTable;
                comboBoxProducts.DisplayMember = "Kategori";
                comboBoxProducts.ValueMember = "Kategori";
            }

        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'inventoryDBDataSet.CategoriesTable' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.categoriesTableTableAdapter.Fill(this.inventoryDBDataSet.CategoriesTable);

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
    }
}