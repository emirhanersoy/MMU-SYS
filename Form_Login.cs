using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // SQL için eklenmeli
using prototype_BM102.Properties;

namespace prototype_BM102
{
    public partial class Form_Login : Form
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\InventoryDB.mdf;Integrated Security=True";

        private bool isChecked = false; //"Şifreyi göster" özelliği için oluşturulan boolean
        public Form_Login()
        {
            InitializeComponent();
        }

        private void label_Clear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
        } //Temizle butonunun eklenmesi

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    // Kullanıcı adı ve şifre bilgilerini sorgulamak için SQL sorgusu
                    string sqlQuery = "SELECT COUNT(*) FROM Login_auth WHERE username = @Username AND password = @Password";

                    // Sorgu için SqlCommand nesnesini oluşturma
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    // Kullanıcı adı ve şifre değerlerini belirleme
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);


                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Giriş başarılı!");
                        Form_Main form_main = new Form_Main();
                        form_main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }
        } //Giriş Butonu

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
        } //"Şifreyi göster" özelliğinin eklenmesi

        private void imagecontrol1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapılsın mı?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }//Çıkış butonunun eklenmesi
        }
    }
}