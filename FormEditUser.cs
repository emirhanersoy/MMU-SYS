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
    public partial class FormEditUser : Form

    {
        private string oldUsername;
        private string oldName;
        private string oldPassword;
        private string oldPhone;
        private const string watermarkText = "Kullanıcı adı düzenlenemez";


        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\InventoryDB.mdf;Integrated Security=True";
        private SqlConnection connection;

        public event EventHandler RefreshDataGrid; // DataGrid'i yenilemek için referans

        private bool isChecked = false;
        //edit tuşuna basıldığında bilgi çekmek için gereken consturctor
        public FormEditUser(string username, string name, string password, string phone)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FormEditUser_Load);// forma verileri yükleme

            // Değişkenleri atama
            oldUsername = username;
            oldName = name;
            oldPassword = password;
            oldPhone = phone;
            

        }

        private void pictureBoxHidePw_Click_1(object sender, EventArgs e)
        {
            isChecked = !isChecked;

            if (!isChecked)
            {
                pictureBoxHidePw.Image = Properties.Resources.hide;
                textBoxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                pictureBoxHidePw.Image = Properties.Resources.view;
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }
        public void FormEditUser_Load(object sender, EventArgs e)
        {
            // Verileri TextBox'lara ve ComboBox'a aktar
            
            textBoxUsername.Text = watermarkText;
            textBoxUsername.ForeColor = Color.Gray;
            textBoxUsername.ReadOnly = true;
            textBoxUsername.Text = oldUsername;
            textBoxFullname.Text = oldName;
            textBoxPassword.Text = oldPassword;
            textBoxPhone.Text = oldPhone;
            
        }
        private void imagecontrolClose_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("İşlem iptal edilsin mi?", "İptal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                textBoxPassword.Clear();
                textBoxPhone.Clear();
                textBoxFullname.Clear();
                textBoxUsername.Clear();
                this.Hide();
            }
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            string newUsername = textBoxUsername.Text; //boş olmamalı
            string newName = textBoxFullname.Text; //boş olmamalı
            string newPassword = textBoxPassword.Text; //boş olmamalı
            string newPhone = textBoxPhone.Text; //boş olmamalı, sayı olmalı

            if (string.IsNullOrWhiteSpace(newUsername) ||
                string.IsNullOrWhiteSpace(newName) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(newPhone))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.", "Hatalı girdi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long phoneNumber;

            if (!long.TryParse(textBoxPhone.Text, out phoneNumber))
            {
                MessageBox.Show("Telefon numarası sayılardan oluşmalıdır.", "Hatalı girdi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //sql

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "UPDATE Login_auth SET  [name] = @newName, [password] = @newPassword, [phone] = @newPhone " +
                               "WHERE [username] = @oldUsername";

                SqlCommand command = new SqlCommand(query, connection);
               
                command.Parameters.AddWithValue("@newName", newName);
                command.Parameters.AddWithValue("@newPassword", newPassword);
                command.Parameters.AddWithValue("@newPhone", newPhone);
                command.Parameters.AddWithValue("@oldUsername", oldUsername);

                command.ExecuteNonQuery();

                connection.Close();
            }

            MessageBox.Show("Veri Başarıyla Eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormUsers formUsers = Application.OpenForms.OfType<FormUsers>().FirstOrDefault();
            formUsers?.RefreshDataGridView();

            this.Close();

            

        }

        private void labelClear_Click_1(object sender, EventArgs e)
        {
            textBoxPassword.Clear();
            textBoxPhone.Clear();
            textBoxFullname.Clear();
            textBoxUsername.Clear();
        }
    }
}
