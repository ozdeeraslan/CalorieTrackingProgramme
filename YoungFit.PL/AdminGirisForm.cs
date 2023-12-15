using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoungFit.DAL.Context;

namespace YoungFit.PL
{
    public partial class AdminGirisForm : Form
    {
        UygulamaDbContext db = new UygulamaDbContext();
        public AdminGirisForm()
        {
            InitializeComponent();
        }

        private void btnAdminAnaSayfayaDon_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {

            string adminMail = txtAdminMail.Text;
            string adminSifre = txtAdminSifre.Text;
            var adminForm = new AdminForm();

            if (adminMail == "" || adminSifre == "")
            {
                MessageBox.Show("Boş alan bırakmayınız");
                return;
            }

            foreach (var item in db.Adminler)
            {
                if (item.Email == adminMail && item.Sifre == adminSifre)
                {

                    MessageBox.Show("Hoşgeldiniz");
                    this.Hide();
                    adminForm.ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Hatalı bilgi girdiniz");
        }
      
    }
}
