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
using YoungFit.BL.Repository;
using YoungFit.DAL.Context;
using YoungFit.DAL.Entities;
using YoungFit.DAL.Enums;

namespace YoungFit.PL
{
	public partial class KullaniciForm : Form
	{
		private readonly UygulamaDbContext db;
		Yemek seciliYemek;
		Kullanici kullanici;
		Repository<KullaniciYemek> kullaniciYemekRepo;
		public string Isim { get; set; }
		public KullaniciForm(UygulamaDbContext db, string kullaniciEmail)
		{
			InitializeComponent();
			lblKisi.Text = kullaniciEmail;
			this.db = db;
			KullaniciBesinleriGetir();
			OgunleriGetir();
			KullanicininYemekleriniGetir();
            dgvYediklerim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
			nudMiktar.Value = 1;
        }

		private void KullanicininYemekleriniGetir()
		{
			kullanici = db.Kullanicilar
				.FirstOrDefault(k => k.Email == lblKisi.Text)!;
			dgvYediklerim.Refresh();
			dgvYediklerim.DataSource = db.KullaniciYemekler.Where(a => a.KullaniciId == kullanici.Id).ToList();
			dgvYediklerim.Columns[1].Visible = false;
			dgvYediklerim.Columns[2].Visible = false;
			dgvYediklerim.Columns[3].Visible = false;
		}

		private void OgunleriGetir()
		{
			cmbYemekZamani.Items.Clear();
			cmbYemekZamani.Items.AddRange(Enum.GetValues(typeof(Ogun)).Cast<object>().ToArray());
			cmbYemekZamani.SelectedIndex = 0;
		}

		private void KullaniciBesinleriGetir()
		{
			dgvArananYemek.Refresh();
			dgvArananYemek.DataSource = db.Yemekler.ToList();
			dgvArananYemek.Columns[4].Visible = false;
			dgvArananYemek.Columns[5].Visible = false;
			dgvArananYemek.Columns[6].Visible = false;
			dgvArananYemek.Columns[7].Visible = false;
		}

		private void dgvArananYemek_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvArananYemek.CurrentRow == null)
			{
				return;
			}

			var secili = (Yemek)dgvArananYemek.CurrentRow.DataBoundItem;

			if (secili.Resim != null)
			{
				seciliYemek = (Yemek)dgvArananYemek.CurrentRow.DataBoundItem;
				pbKullaniciResim.SizeMode = PictureBoxSizeMode.Zoom;
				pbKullaniciResim.Image = Image.FromStream(new MemoryStream(seciliYemek.Resim));
			}
			else
			{
				pbKullaniciResim.Image = null;
			}

			lblKullaniciEnum.Text = secili.OlcuBirimi.ToString();
		}

		private void btnYemekBul_Click(object sender, EventArgs e)
		{
			string arananYemek = txtAranacakYemek.Text.ToLower();

			if (arananYemek == "")
			{
				MessageBox.Show("Aranacak yemek adını giriniz");
				return;
			}

			var yemekler = db.Yemekler.Where(x => x.YemekAdi.ToLower().Contains(arananYemek)).ToList();

			if (yemekler.Count != 0)
				dgvArananYemek.DataSource = yemekler;
		}

		private void btnYenile_Click(object sender, EventArgs e)
		{
			KullaniciBesinleriGetir();
			txtAranacakYemek.Clear();
		}

		private void btnOgunEkle_Click(object sender, EventArgs e)
		{
			kullaniciYemekRepo = new Repository<KullaniciYemek>();

			kullanici = db.Kullanicilar
				.FirstOrDefault(k => k.Email == lblKisi.Text)!;

			var seciliYemek = (Yemek)dgvArananYemek.CurrentRow.DataBoundItem;
			if (seciliYemek == null)
				return;

			var kullaniciYemek = new KullaniciYemek
			{
				KullaniciId = kullanici.Id,
				YemekId = seciliYemek.Id,
				OgunZamanı = (Ogun)cmbYemekZamani.SelectedItem,
				//YemekAdı = seciliYemek.YemekAdi,
				Tarih = dtpKullaniciTarihSec.Value,
				ToplamKalori = seciliYemek.Kalori * (int)nudMiktar.Value,


			};

			//eklemenin çalışan hali
			//db.KullaniciYemekler.Add(kullaniciYemek);
			//db.SaveChanges();

			kullaniciYemekRepo.Ekle(kullaniciYemek);


			KullanicininYemekleriniGetir();
		}

		private void btnOgunGuncelle_Click(object sender, EventArgs e)
		{
			if (dgvYediklerim.CurrentRow == null)
			{
				MessageBox.Show("Lütfen güncelleyeceğiniz yemeği seçiniz!");
				return;
			}
			var yediklerim = (KullaniciYemek)dgvYediklerim.CurrentRow.DataBoundItem; //alt dgv

			var guncellenecekYemek = (Yemek)dgvArananYemek.CurrentRow.DataBoundItem; // üst dgv

			yediklerim.OgunZamanı = (Ogun)cmbYemekZamani.SelectedItem;
			yediklerim.ToplamKalori = guncellenecekYemek.Kalori * (int)nudMiktar.Value;
			yediklerim.Tarih = dtpKullaniciTarihSec.Value;
			yediklerim.YemekId = guncellenecekYemek.Id;
			//yediklerim.Yemek.YemekAdi = guncellenecekYemek.YemekAdi;

			db.SaveChanges();
			KullanicininYemekleriniGetir();
			///////////////////////////////////////////////////////////////////////////

		}


		private void btnOgunSil_Click(object sender, EventArgs e)
		{
			if (dgvYediklerim.CurrentRow == null)
			{
				MessageBox.Show("Lütfen silineceğiniz öğünü seçiniz!");
				return;
			}
            kullaniciYemekRepo = new Repository<KullaniciYemek>();
            var silinecekYemek = (KullaniciYemek)dgvYediklerim.CurrentRow.DataBoundItem;
            //db.KullaniciYemekler.Remove(silinecekYemek);
            //db.SaveChanges();
            kullaniciYemekRepo.Sil(silinecekYemek);
            KullanicininYemekleriniGetir();
		}

		private void dgvArananYemek_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndeks = e.RowIndex;
			if (rowIndeks < 0)
				return;
			if (dgvArananYemek.CurrentRow == null)
				return;
			var seciliYemek = (Yemek)dgvArananYemek.CurrentRow.DataBoundItem;

			if (seciliYemek.Resim != null)
			{
				using (MemoryStream ms = new MemoryStream(seciliYemek.Resim))
				{
					pbKullaniciResim.SizeMode = PictureBoxSizeMode.Zoom;
					pbKullaniciResim.Image = Image.FromStream(ms);
					if (seciliYemek.Resim == null)
					{
						pbKullaniciResim.Image = null;
					}
				}
			}
		}
		private void dgvYediklerim_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndeks = e.RowIndex;
			if (rowIndeks < 0)
				return;
			if (dgvYediklerim.CurrentRow == null)
				return;
			var yediklerim = (KullaniciYemek)dgvYediklerim.CurrentRow.DataBoundItem;
			if (yediklerim.Yemek.Resim != null)
			{
				using (MemoryStream ms = new MemoryStream(yediklerim.Yemek.Resim))
				{
					pbYediklerimResim.SizeMode = PictureBoxSizeMode.Zoom;
					pbYediklerimResim.Image = Image.FromStream(ms);
				}
			}
			else
				pbYediklerimResim.Image = null;



		}
		private void btnIstatistikleriGor_Click(object sender, EventArgs e)
		{
			Isim = lblKisi.Text;
			var istatistikForm = new IstatistikleriGorForm(db, Isim);
			istatistikForm.ShowDialog();
		}

		private void dgvYediklerim_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			////////////alp hocanın kodları/////////////////////
			//var seciliYemek = (KullaniciYemek)dgvYediklerim.Rows[e.RowIndex].DataBoundItem;

			//var secili = db.Yemekler.FirstOrDefault(y => y.Id == seciliYemek.YemekId);

			//foreach (DataGridViewRow row in dgvArananYemek.Rows)
			//{
			//	// Her bir satırdaki hücrelere erişim
			//	foreach (DataGridViewCell cell in row.Cells)
			//	{
			//		// Hücrenin değerine erişim
			//		object cellValue = cell.Value;
			//		var yemek = (Yemek)cellValue;
			//		if (yemek.Id == secili.Id)
			//		{
			//			dgvArananYemek.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = yemek;
			//		}
			//	}
			//}
			//////////////////////////////////////////////////////////////

            int rowIndeks = e.RowIndex;
            if (rowIndeks < 0)
                return;
            if (dgvArananYemek.CurrentRow == null)
                return;
            var seciliYemek = (KullaniciYemek)dgvYediklerim.CurrentRow.DataBoundItem;

            if (seciliYemek.Yemek.Resim != null)
            {
                using (MemoryStream ms = new MemoryStream(seciliYemek.Yemek.Resim))
                {
                    pbYediklerimResim.SizeMode = PictureBoxSizeMode.Zoom;
                    pbYediklerimResim.Image = Image.FromStream(ms);
                    if (seciliYemek.Yemek.Resim == null)
                    {
                        pbYediklerimResim.Image = null;
                    }
                }
            }
        }
	}
}
