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
    public partial class UyeOlForm : Form
    {
        UygulamaDbContext db = new UygulamaDbContext();
        public UyeOlForm()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnHesapOlustur_Click(object sender, EventArgs e)
        {

            string kullanicisifre = txtSifreOlustur.Text;

            var yeniKullanici = db.Kullanicilar.FirstOrDefault(x => x.Email == txtMailOlustur.Text);

            if (yeniKullanici != null)
            {
                MessageBox.Show("Bu mail Kullanımdadır!");
                return;
            }

            if (txtMailOlustur.Text == "" || txtSifreOlustur.Text == "")
                MessageBox.Show("Boş alan bırakmayınız.");
            else if (txtMailOlustur.Text.Contains("@")==false || txtMailOlustur.Text.EndsWith(".com")==false)
                MessageBox.Show("Lütfen geçerli bir mail adresi giriniz!");
            else if (txtSifreOlustur.Text.Length < 8)
                MessageBox.Show("Sifreniz en az 8 karakter olmalıdır!");
            else if (kullanicisifre.Any(char.IsUpper) == false)
                MessageBox.Show("şifreniz en az bir büyük harf içermelidir!");
            else if (kullanicisifre.Any(char.IsLower) == false)
                MessageBox.Show("şifreniz en az bir küçük harf içermelidir!");
            else if (kullanicisifre.Any(char.IsDigit) == false)
                MessageBox.Show("şifreniz en az bir rakam icermelidir!");
            else
            {
                string hashlenmisSifre = sha256_hash(kullanicisifre);

                Kullanici kullanici = new Kullanici
                {
                    Email = txtMailOlustur.Text,
                    Sifre = hashlenmisSifre
                };
                db.Kullanicilar.Add(kullanici);
                db.SaveChanges();
                MessageBox.Show("Kullanıcı kayıt işlemi başarılı bir şekilde gerçekleştirilmiştir.");
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
