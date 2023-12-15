using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoungFit.DAL.Context;
using YoungFit.DAL.Entities;

namespace YoungFit.PL
{
    public partial class IstatistikleriGorForm : Form
    {
        private readonly UygulamaDbContext db;
        Kullanici acikKullanici;
        public IstatistikleriGorForm(UygulamaDbContext db, string kullanici)
        {
            InitializeComponent();
            this.db = db;
            lblKisi.Text = kullanici;
            acikKullanici = db.Kullanicilar
                            .FirstOrDefault(k => k.Email == kullanici)!;

            SeciliTarihteAlinanKaloriyiHesapla();
            OTarihteYediklerimiGetir();
            EnCokYenilenYemegiGetir();
            ComboBoxaKisileriGetir();
            ComboBoxaYemekleriGetir();
        }

        private void ComboBoxaYemekleriGetir()
        {
            cmbTumYemekler.DataSource = db.Yemekler.ToList();
            cmbTumYemekler.DisplayMember = "YemekAdi";
        }

        private void ComboBoxaKisileriGetir()
        {
            cmbKisi1.DataSource = db.Kullanicilar.ToList();
            cmbKisi2.DataSource = db.Kullanicilar.ToList();
        }

        private void EnCokYenilenYemegiGetir()
        {
            var yediklerim = db.KullaniciYemekler
                    .Include(ky => ky.Yemek)
                    .Include(ky => ky.Kullanici)
                    .Where(ky => ky.KullaniciId == acikKullanici.Id)
                    .GroupBy(ky => ky.Yemek)
                    .ToList()  // Bu noktada veritabanından veriyi çektik.
                    .OrderByDescending(g => g.Count())
                    .SelectMany(g => g)
                    .ToList();
            if (yediklerim.Count > 0)
                lblEnÇokYenenYemek.Text = yediklerim[0].Yemek.YemekAdi;
            else
                lblEnÇokYenenYemek.Text = "Hiç yemek yok!";
        }

        private void OTarihteYediklerimiGetir()
        {
            DateTime secilenTarih = dtpIstatistiklerTarih.Value.Date;

            lstYenilenBesinler.Refresh();
            //lstYenilenBesinler.Items.Clear();

            // Veritabanından seçilen tarihte yenilen besinleri alalım
            var yediklerim = db.KullaniciYemekler
                .Include(ky => ky.Yemek)
                .Include(ky => ky.Kullanici)
                .Where(ky => ky.Tarih.Date == secilenTarih && ky.KullaniciId == acikKullanici.Id)
                .ToList();
            lstYenilenBesinler.DataSource = yediklerim;
        }

        private void SeciliTarihteAlinanKaloriyiHesapla()
        {
            var kullanicininYemekleri = db.KullaniciYemekler
                         .Where(x => x.Kullanici.Email == lblKisi.Text && x.Tarih.Date == dtpIstatistiklerTarih.Value.Date)
                         .ToList();
            int toplamKalori = kullanicininYemekleri.Sum(x => x.ToplamKalori);
            lblToplamKalori.Text = toplamKalori.ToString();
        }

        private void dtpIstatistiklerTarih_ValueChanged(object sender, EventArgs e)
        {
            OTarihteYediklerimiGetir();
            SeciliTarihteAlinanKaloriyiHesapla();
        }

        private void btnAnaSayfayaDon_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnKiyasla_Click(object sender, EventArgs e)
        {
            lstBirincininYedikleri.Items.Clear();
            lstIkincininYedikleri.Items.Clear();


            var kullanici1 = (Kullanici)cmbKisi1.SelectedItem;
            var kullanici2 = (Kullanici)cmbKisi2.SelectedItem;

            if (kullanici1 == kullanici2)
            {
                MessageBox.Show("Kişiler aynı olamaz!");
                return;
            }

            var yediklerim1 = db.KullaniciYemekler
                            .Include(ky => ky.Yemek)
                            .Include(ky => ky.Kullanici)
                            .Where(ky => ky.Kullanici.Email == kullanici1.Email)
                            .ToList();

            var yediklerim2 = db.KullaniciYemekler
                            .Include(ky => ky.Yemek)
                            .Include(ky => ky.Kullanici)
                            .Where(ky => ky.Kullanici.Email == kullanici2.Email)
                            .ToList();

            foreach (var item in yediklerim1)
            {
                lstBirincininYedikleri.Items.Add(item.Yemek.YemekAdi + " " + item.Tarih.ToShortDateString() + " " + item.OgunZamanı);
            }
            foreach (var item in yediklerim2)
            {
                lstIkincininYedikleri.Items.Add(item.Yemek.YemekAdi + " " + item.Tarih.ToShortDateString() + " " + item.OgunZamanı);
            }
        }

        private void btnYemegiYİyenleriListele_Click(object sender, EventArgs e)
        {
            var secilenYemek = (Yemek)cmbTumYemekler.SelectedItem;
           
            var tumKullanicilar = db.KullaniciYemekler
                .Include(ky => ky.Yemek)
                .Include(ky => ky.Kullanici)
                .Where(ky => ky.YemekId == secilenYemek.Id)
                .Select(ky => ky.Kullanici)
                .Distinct()
                .ToList();
            lstYemegiYiyenler.Items.Clear();
            foreach (var kullanici in tumKullanicilar)
            {
                lstYemegiYiyenler.Items.Add(kullanici.Email);
            }  
        }
    }
}
