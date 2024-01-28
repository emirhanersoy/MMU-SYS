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
    public partial class FormAddCategory : Form
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\InventoryDB.mdf;Integrated Security=True";

        public event EventHandler RefreshDataGrid; // DataGrid'i yenilemek için referans
        public FormAddCategory()
        {
            InitializeComponent();
        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            textBoxAddCategory.Clear();
        }
        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            string input = textBoxAddCategory.Text;

            if (IsNumeric(input) || string.IsNullOrWhiteSpace(input))
            {
                //girdi rakamlardan oluşur ya da boştur
                MessageBox.Show("Hatalı girdi, lütfen geçerli bir giriş yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //girdi karakterlerden oluşur
                string productCategory = textBoxAddCategory.Text;

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO CategoriesTable ([Kategori]) " +
                                   "VALUES (@Kategori)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Kategori", productCategory);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Veri Başarıyla Eklendi!");

                    FormCategories formCategories = Application.OpenForms.OfType<FormCategories>().FirstOrDefault();
                    //formCategories?.RefreshDataGridView();
                    RefreshDataGrid?.Invoke(this, EventArgs.Empty); // FormProducts formunda DataGrid'i yenilemek için olayı tetikle

                    this.Close();
                }
            }
        }

        private bool IsNumeric(string input)
        {
            foreach(char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void imagecontrolClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("İşlem iptal edilsin mi?", "İptal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                textBoxAddCategory.Clear();
                this.Hide();
            }
        }
    }
}