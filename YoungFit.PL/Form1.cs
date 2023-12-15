namespace YoungFit.PL
{
	public partial class Form1 : Form
	{
		// formlar�n butonlara par�alanmas� ve uygulama ana ekran�n�n gizlenmesi
		public Form1()
		{
			InitializeComponent();
		}
		private void btnUyeOlmadanDevamEt_Click(object sender, EventArgs e)
		{
			var uyeOlmadanDevamEtForm = new UyeOlmadanDevamEtForm();
			uyeOlmadanDevamEtForm.ShowDialog();
		}

		private void btnAdminGirisi_Click(object sender, EventArgs e)
		{
			var adminGirisFormu = new AdminGirisForm();
			adminGirisFormu.ShowDialog();
        }

		private void btnUyeOl_Click(object sender, EventArgs e)
		{
			var uyeOlFormu = new UyeOlForm();
			uyeOlFormu.ShowDialog();
		}

		private void btnKullaniciGirisi_Click(object sender, EventArgs e)
		{
			var kullaniciSistemeGirisForm=new KullaniciSistemeGirisForm();
			kullaniciSistemeGirisForm.ShowDialog();
        }
    }
}
