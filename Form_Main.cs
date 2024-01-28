using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototype_BM102
{
    public partial class Form_Main : Form
    {
        
        public Form_Main()
        {
            InitializeComponent();
        }

        private void imagecontrol2_Click(object sender, EventArgs e)
        {
            FormUsers formUser = new FormUsers();
            formUser.FormClosed += FormUsers_FormClosed;
            formUser.Show();
            this.Hide();
        }
        private void FormUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main mainForm = new Form_Main();  // Yeni bir Form_Main örneği oluşturun
            mainForm.Show();
        }

        private void imagecontrol1_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts();
            formProducts.FormClosed += FormProducts_FormClosed;
            formProducts.Show();
            this.Hide();
        }

        private void FormProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main formMain = new Form_Main();
            formMain.Show();
        }

        private void imagecontrol3_Click(object sender, EventArgs e)
        {
            FormCategories formCategories = new FormCategories();
            formCategories.FormClosed += FormCategories_FormClosed;
            formCategories.Show();
            this.Hide();
        }

        private void FormCategories_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void imagecontrol5_Click(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders();
            formOrders.FormClosed += FormOrders_FormClosed;
            formOrders.Show();
            this.Hide();
        }

        private void FormOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main formMain = new Form_Main();
            formMain.Show();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the date and time labels with the current date and time
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblTime.Text = DateTime.Now.ToString("HH:mm");
        }

        private void imagecontrolClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapılsın mı?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Form[] openForms = Application.OpenForms.Cast<Form>().ToArray(); // Koleksiyonun bir kopyasını oluşturur

                foreach (Form form in openForms)
                {
                    form.Close();
                }

                Application.Exit(); //Çıkış butonunun eklenmesi
            }
        }
    }
}
