using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace prototype_BM102
{
    public partial class FormAddUser : Form
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\InventoryDB.mdf;Integrated Security=True";
        private bool isChecked = false;
        public FormAddUser()
        {
            InitializeComponent();
        }
        private void labelClear_Click(object sender, EventArgs e)
        {
            textBoxPassword.Clear();
            textBoxPhone.Clear();
            textBoxFullname.Clear();
            textBoxUsername.Clear();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text; //boş olmamalı
            string name = textBoxFullname.Text; //boş olmamalı
            string password = textBoxPassword.Text; //boş olmamalı
            string phone = textBoxPhone.Text; //boş olmamalı, sayı olmalı

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(phone))
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

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "INSERT INTO Login_auth ([username], [name], [password], [phone]) " +
                               "VALUES (@username, @name, @password, @phone)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@phone", phone);

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Veri Başarıyla Eklendi!");

                FormUsers formUsers = Application.OpenForms.OfType<FormUsers>().FirstOrDefault();
                formUsers?.RefreshDataGridView();
                

                this.Close();
            }
        }

        private void pictureBoxHidePw_Click(object sender, EventArgs e)
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

        private void imagecontrolClose_Click(object sender, EventArgs e)
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
    }
}
