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
using YoungFit.DAL.Entities;

namespace YoungFit.PL
{
    public partial class KullaniciSistemeGirisForm : Form
    {
        UygulamaDbContext db = new UygulamaDbContext();
        public string KullaniciIsim { get; set; }
        public KullaniciSistemeGirisForm()
        {
            InitializeComponent();
        }

        private void btnAnaSayfayaDon_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnKullaniciSistemeGiris_Click(object sender, EventArgs e)
        {
            string hashliSifre = sha256_hash(txtKullaniciGirisSifre.Text);
            var kullanici = db.Kullanicilar.FirstOrDefault(x => x.Email == txtKullaniciGirisMail.Text && x.Sifre == hashliSifre);

            if (kullanici != null)
            {
                KullaniciIsim = kullanici.Email;
                var kullaniciForm = new KullaniciForm(db, KullaniciIsim);
                this.Hide();
                kullaniciForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı!");
            }

        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
    }
}
