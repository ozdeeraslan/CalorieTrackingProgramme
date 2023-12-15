using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoungFit.BL.Repository;
using YoungFit.DAL.Context;
using YoungFit.DAL.Entities;
using YoungFit.DAL.Enums;

namespace YoungFit.PL
{
    public partial class AdminForm : Form
    {
        UygulamaDbContext db = new UygulamaDbContext();

        Repository<Yemek> yemekRepo;

        Yemek seciliYemek;
        public AdminForm()
        {
            InitializeComponent();
            cmbOgunOlcuBirimi.DataSource = Enum.GetValues(typeof(OlcuBirimi));

            BesinleriGetir();
        }

        private void BesinleriGetir()
        {
            dgvBesinler.DataSource = db.Yemekler.ToList();
            dgvBesinler.Columns[4].Visible = false;
            dgvBesinler.Columns[5].Visible = false;
            dgvBesinler.Columns[6].Visible = false;
            dgvBesinler.Columns[7].Visible = false;
            db.SaveChanges();
        }

        private void btnBesinKaydet_Click(object sender, EventArgs e)
        {
            Yemek yemek = new Yemek();
            yemekRepo = new Repository<Yemek>();

            if (string.IsNullOrEmpty(txtBesinAdi.Text))
            {
                MessageBox.Show("Lütfen besin adını giriniz");
                return;
            }
            var bulunanYemek = db.Yemekler.FirstOrDefault(x => x.YemekAdi == txtBesinAdi.Text);
            if (bulunanYemek != null)
            {
                MessageBox.Show("Bu besin zaten kayıtlı");
                return;
            }

            yemek.YemekAdi = txtBesinAdi.Text;
            yemek.Kalori = Convert.ToInt32(nudKalori.Value);
            yemek.OlcuBirimi = (OlcuBirimi)cmbOgunOlcuBirimi.SelectedItem!;
            yemekRepo.Ekle(yemek);

            MessageBox.Show($"{yemek.YemekAdi}  kaydedilmiştir.");
            BesinleriGetir();

            // eklenen besini dgv ' de seçili hale getirme
            int sonSatirIndex = dgvBesinler.Rows.Count - 1;
            dgvBesinler.CurrentCell = dgvBesinler.Rows[sonSatirIndex].Cells[0];
            pbSecilenYemek.Image = null;

            // eklenen besini tekrar textlere yazdırma
            txtBesinAdi.Text = yemek.YemekAdi;
            nudKalori.Value = yemek.Kalori;
            cmbOgunOlcuBirimi.SelectedItem = yemek.OlcuBirimi;
        }

        private void btnBesinDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvBesinler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir besin seçiniz");
                return;
            }
            var bulunanYemek = db.Yemekler.FirstOrDefault(x => x.YemekAdi == txtBesinAdi.Text);
            if (bulunanYemek != null)
            {
                MessageBox.Show("Bu besin zaten kayıtlı");
                return;
            }

            seciliYemek = (Yemek)dgvBesinler.CurrentRow.DataBoundItem;
            seciliYemek.YemekAdi = txtBesinAdi.Text;
            seciliYemek.Kalori = Convert.ToInt32(nudKalori.Value);
            seciliYemek.OlcuBirimi = (OlcuBirimi)cmbOgunOlcuBirimi.SelectedItem!;

            yemekRepo.Guncelle();

            MessageBox.Show("Seçilen Besin Güncellendi");
            BesinleriGetir();

            // düzenlenen besini tekrar textlere yazdırma
            txtBesinAdi.Text = seciliYemek.YemekAdi;
            nudKalori.Value = seciliYemek.Kalori;
            cmbOgunOlcuBirimi.SelectedItem = seciliYemek.OlcuBirimi;

        }

        private void btnResimGuncelle_Click(object sender, EventArgs e)
        {
            yemekRepo = new Repository<Yemek>();
            if (dgvBesinler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir besin seçiniz");
                return;
            }

            seciliYemek = (Yemek)dgvBesinler.CurrentRow.DataBoundItem;

            using (OpenFileDialog resimPenceresi = new OpenFileDialog())
            {
                if (resimPenceresi.ShowDialog() == DialogResult.OK)
                {
                    seciliYemek.Resim = File.ReadAllBytes(resimPenceresi.FileName);
                }
            }

            if (seciliYemek.Resim != null)
            {
                using (MemoryStream ms = new MemoryStream(seciliYemek.Resim))
                {
                    pbSecilenYemek.SizeMode = PictureBoxSizeMode.Zoom;
                    pbSecilenYemek.Image = Image.FromStream(ms);
                }
            }
            yemekRepo.Guncelle();
            MessageBox.Show("Resim Güncellendi");
            BesinleriGetir();
        }

        private void dgvBesinler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBesinler.CurrentRow == null)
            {
                return;
            }
            var secili = (Yemek)dgvBesinler.CurrentRow.DataBoundItem;
            if (secili.Resim != null)
            {
                seciliYemek = (Yemek)dgvBesinler.CurrentRow.DataBoundItem;
                pbSecilenYemek.SizeMode = PictureBoxSizeMode.Zoom;
                pbSecilenYemek.Image = Image.FromStream(new MemoryStream(seciliYemek.Resim));
            }
            else
            {
                pbSecilenYemek.Image = null;
            }
            txtBesinAdi.Text = secili.YemekAdi;
            nudKalori.Value = secili.Kalori;
            cmbOgunOlcuBirimi.SelectedItem = secili.OlcuBirimi;
        }

        private void btnBesinSil_Click(object sender, EventArgs e)
        {
            if (dgvBesinler.CurrentRow == null)
            {
                MessageBox.Show("lütfen silinecek bir besin seçiniz!");
                return;
            }

            var silinecekYemek = (Yemek)dgvBesinler.CurrentRow.DataBoundItem;
            yemekRepo = new Repository<Yemek>();

            DialogResult dialogResult = MessageBox.Show($"'{silinecekYemek.YemekAdi}' isimli besin silinecek, emin misiniz?", "Besin Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                yemekRepo.Sil(silinecekYemek);
                BesinleriGetir();
            }
        }
    }
}
