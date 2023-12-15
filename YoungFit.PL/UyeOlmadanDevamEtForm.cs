using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoungFit.PL
{
	public partial class UyeOlmadanDevamEtForm : Form
	{
		public UyeOlmadanDevamEtForm()
		{
			InitializeComponent();
			nudVucutAgirligi.Value = 60;
		}

		private void btnBKIHesapla_Click(object sender, EventArgs e)
		{
			decimal kg, boy;
			if (decimal.TryParse(txtBoyCm.Text, out boy) && Convert.ToDecimal(txtBoyCm.Text) > 0)
			{
				kg = nudVucutAgirligi.Value;
				boy = Convert.ToDecimal(txtBoyCm.Text) / 100;
				string sonuc = string.Format("{0:n2}", kg / (boy * boy));
				lblBKI.Text = sonuc;

                //////////////////// gelen BKİ sonucuna göre kilo sınıflandırılması /////////////////////
                decimal bki = Convert.ToDecimal(lblBKI.Text);
                if (bki < 18.5m)
                    lblBkiSonuc.Text = "Zayıf";
                else if (bki >= 18.5m && bki < 25)
                    lblBkiSonuc.Text = "Normal kilolu";
				else if (bki >= 25 && bki < 30)
                    lblBkiSonuc.Text = "Kilolu";
                else
                    lblBkiSonuc.Text = "Obez";

            }
			else
				MessageBox.Show("Yanlış değer girdiniz");

        }

		private void btnUyeOlIptal_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
