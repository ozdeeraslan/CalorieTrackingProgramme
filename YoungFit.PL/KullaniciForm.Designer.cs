namespace YoungFit.PL
{
    partial class KullaniciForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbYemekZamani = new ComboBox();
            label1 = new Label();
            dgvArananYemek = new DataGridView();
            label2 = new Label();
            txtAranacakYemek = new TextBox();
            btnYemekBul = new Button();
            label3 = new Label();
            dgvYediklerim = new DataGridView();
            lblKullaniciEnum = new Label();
            dtpKullaniciTarihSec = new DateTimePicker();
            label5 = new Label();
            btnOgunEkle = new Button();
            btnOgunGuncelle = new Button();
            btnIstatistikleriGor = new Button();
            btnOgunSil = new Button();
            lblKisi = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            pbKullaniciResim = new PictureBox();
            btnYenile = new Button();
            nudMiktar = new NumericUpDown();
            pbYediklerimResim = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvArananYemek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvYediklerim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKullaniciResim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbYediklerimResim).BeginInit();
            SuspendLayout();
            // 
            // cmbYemekZamani
            // 
            cmbYemekZamani.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYemekZamani.FormattingEnabled = true;
            cmbYemekZamani.Location = new Point(178, 368);
            cmbYemekZamani.Name = "cmbYemekZamani";
            cmbYemekZamani.Size = new Size(121, 29);
            cmbYemekZamani.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(12, 366);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 1;
            label1.Text = "Yemek Zamanı :";
            // 
            // dgvArananYemek
            // 
            dgvArananYemek.AllowUserToAddRows = false;
            dgvArananYemek.AllowUserToDeleteRows = false;
            dgvArananYemek.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArananYemek.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvArananYemek.BackgroundColor = Color.LightGoldenrodYellow;
            dgvArananYemek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArananYemek.Location = new Point(12, 80);
            dgvArananYemek.Name = "dgvArananYemek";
            dgvArananYemek.ReadOnly = true;
            dgvArananYemek.RowHeadersWidth = 51;
            dgvArananYemek.Size = new Size(653, 265);
            dgvArananYemek.TabIndex = 2;
            dgvArananYemek.CellClick += dgvArananYemek_CellClick;
            dgvArananYemek.SelectionChanged += dgvArananYemek_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(12, 22);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 3;
            label2.Text = "Aranacak Yemek :";
            // 
            // txtAranacakYemek
            // 
            txtAranacakYemek.Location = new Point(199, 19);
            txtAranacakYemek.Name = "txtAranacakYemek";
            txtAranacakYemek.Size = new Size(267, 29);
            txtAranacakYemek.TabIndex = 4;
            // 
            // btnYemekBul
            // 
            btnYemekBul.BackColor = Color.Beige;
            btnYemekBul.FlatStyle = FlatStyle.Popup;
            btnYemekBul.Location = new Point(481, 19);
            btnYemekBul.Name = "btnYemekBul";
            btnYemekBul.Size = new Size(118, 35);
            btnYemekBul.TabIndex = 5;
            btnYemekBul.Text = "BUL";
            btnYemekBul.UseVisualStyleBackColor = false;
            btnYemekBul.Click += btnYemekBul_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(66, 418);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 6;
            label3.Text = "Miktar :";
            // 
            // dgvYediklerim
            // 
            dgvYediklerim.AllowUserToAddRows = false;
            dgvYediklerim.AllowUserToDeleteRows = false;
            dgvYediklerim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvYediklerim.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvYediklerim.BackgroundColor = Color.LightGoldenrodYellow;
            dgvYediklerim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYediklerim.Location = new Point(727, 368);
            dgvYediklerim.Name = "dgvYediklerim";
            dgvYediklerim.ReadOnly = true;
            dgvYediklerim.RowHeadersWidth = 51;
            dgvYediklerim.Size = new Size(508, 268);
            dgvYediklerim.TabIndex = 8;
            dgvYediklerim.CellClick += dgvYediklerim_CellClick;
            dgvYediklerim.CellContentClick += dgvYediklerim_CellContentClick;
            // 
            // lblKullaniciEnum
            // 
            lblKullaniciEnum.AutoSize = true;
            lblKullaniciEnum.BackColor = Color.Transparent;
            lblKullaniciEnum.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblKullaniciEnum.Location = new Point(326, 418);
            lblKullaniciEnum.Name = "lblKullaniciEnum";
            lblKullaniciEnum.Size = new Size(111, 21);
            lblKullaniciEnum.TabIndex = 9;
            lblKullaniciEnum.Text = "enum gelecek";
            // 
            // dtpKullaniciTarihSec
            // 
            dtpKullaniciTarihSec.Location = new Point(178, 461);
            dtpKullaniciTarihSec.Name = "dtpKullaniciTarihSec";
            dtpKullaniciTarihSec.Size = new Size(346, 29);
            dtpKullaniciTarihSec.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(12, 467);
            label5.Name = "label5";
            label5.Size = new Size(112, 21);
            label5.TabIndex = 9;
            label5.Text = "Tarih seçiniz :";
            // 
            // btnOgunEkle
            // 
            btnOgunEkle.BackColor = Color.Beige;
            btnOgunEkle.FlatStyle = FlatStyle.Popup;
            btnOgunEkle.Location = new Point(12, 547);
            btnOgunEkle.Name = "btnOgunEkle";
            btnOgunEkle.Size = new Size(237, 48);
            btnOgunEkle.TabIndex = 11;
            btnOgunEkle.Text = "Öğün Ekle";
            btnOgunEkle.UseVisualStyleBackColor = false;
            btnOgunEkle.Click += btnOgunEkle_Click;
            // 
            // btnOgunGuncelle
            // 
            btnOgunGuncelle.BackColor = Color.Beige;
            btnOgunGuncelle.FlatStyle = FlatStyle.Popup;
            btnOgunGuncelle.Location = new Point(265, 547);
            btnOgunGuncelle.Name = "btnOgunGuncelle";
            btnOgunGuncelle.Size = new Size(239, 48);
            btnOgunGuncelle.TabIndex = 11;
            btnOgunGuncelle.Text = "Seçili Öğünü Güncelle";
            btnOgunGuncelle.UseVisualStyleBackColor = false;
            btnOgunGuncelle.Click += btnOgunGuncelle_Click;
            // 
            // btnIstatistikleriGor
            // 
            btnIstatistikleriGor.BackColor = Color.Beige;
            btnIstatistikleriGor.FlatStyle = FlatStyle.Popup;
            btnIstatistikleriGor.Location = new Point(727, 642);
            btnIstatistikleriGor.Name = "btnIstatistikleriGor";
            btnIstatistikleriGor.Size = new Size(508, 42);
            btnIstatistikleriGor.TabIndex = 12;
            btnIstatistikleriGor.Text = "İstatistikleri Gör";
            btnIstatistikleriGor.UseVisualStyleBackColor = false;
            btnIstatistikleriGor.Click += btnIstatistikleriGor_Click;
            // 
            // btnOgunSil
            // 
            btnOgunSil.BackColor = Color.Beige;
            btnOgunSil.FlatStyle = FlatStyle.Popup;
            btnOgunSil.Location = new Point(178, 611);
            btnOgunSil.Name = "btnOgunSil";
            btnOgunSil.Size = new Size(187, 48);
            btnOgunSil.TabIndex = 11;
            btnOgunSil.Text = "Seçili Öğünü Sil";
            btnOgunSil.UseVisualStyleBackColor = false;
            btnOgunSil.Click += btnOgunSil_Click;
            // 
            // lblKisi
            // 
            lblKisi.AutoSize = true;
            lblKisi.BackColor = Color.Transparent;
            lblKisi.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblKisi.Location = new Point(1019, 22);
            lblKisi.Name = "lblKisi";
            lblKisi.Size = new Size(133, 21);
            lblKisi.TabIndex = 13;
            lblKisi.Text = "kullanıcı gelecek";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(754, 25);
            label6.Name = "label6";
            label6.Size = new Size(195, 21);
            label6.TabIndex = 13;
            label6.Text = "ŞU ANKİ AÇIK OTURUM :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(1145, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pbKullaniciResim
            // 
            pbKullaniciResim.BackColor = Color.Transparent;
            pbKullaniciResim.Location = new Point(797, 80);
            pbKullaniciResim.Name = "pbKullaniciResim";
            pbKullaniciResim.Size = new Size(300, 265);
            pbKullaniciResim.TabIndex = 15;
            pbKullaniciResim.TabStop = false;
            // 
            // btnYenile
            // 
            btnYenile.BackColor = Color.Beige;
            btnYenile.FlatStyle = FlatStyle.Popup;
            btnYenile.Location = new Point(620, 19);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(105, 35);
            btnYenile.TabIndex = 16;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // nudMiktar
            // 
            nudMiktar.Location = new Point(178, 416);
            nudMiktar.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(120, 29);
            nudMiktar.TabIndex = 17;
            // 
            // pbYediklerimResim
            // 
            pbYediklerimResim.BackColor = Color.Transparent;
            pbYediklerimResim.Location = new Point(566, 368);
            pbYediklerimResim.Name = "pbYediklerimResim";
            pbYediklerimResim.Size = new Size(141, 146);
            pbYediklerimResim.TabIndex = 18;
            pbYediklerimResim.TabStop = false;
            // 
            // KullaniciForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Nature__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1257, 705);
            Controls.Add(pbYediklerimResim);
            Controls.Add(nudMiktar);
            Controls.Add(btnYenile);
            Controls.Add(pbKullaniciResim);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(lblKisi);
            Controls.Add(btnIstatistikleriGor);
            Controls.Add(btnOgunSil);
            Controls.Add(btnOgunGuncelle);
            Controls.Add(btnOgunEkle);
            Controls.Add(dtpKullaniciTarihSec);
            Controls.Add(label5);
            Controls.Add(lblKullaniciEnum);
            Controls.Add(dgvYediklerim);
            Controls.Add(label3);
            Controls.Add(btnYemekBul);
            Controls.Add(txtAranacakYemek);
            Controls.Add(label2);
            Controls.Add(dgvArananYemek);
            Controls.Add(label1);
            Controls.Add(cmbYemekZamani);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "KullaniciForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciForm";
            ((System.ComponentModel.ISupportInitialize)dgvArananYemek).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvYediklerim).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKullaniciResim).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbYediklerimResim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbYemekZamani;
        private Label label1;
        private DataGridView dgvArananYemek;
        private Label label2;
        private TextBox txtAranacakYemek;
        private Button btnYemekBul;
        private Label label3;
        private DataGridView dgvYediklerim;
        private Label lblKullaniciEnum;
        private DateTimePicker dtpKullaniciTarihSec;
        private Label label5;
        private Button btnOgunEkle;
        private Button btnOgunGuncelle;
        private Button btnIstatistikleriGor;
        private Button btnOgunSil;
        private Label lblKisi;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pbKullaniciResim;
        private Button btnYenile;
        private NumericUpDown nudMiktar;
        private PictureBox pbYediklerimResim;
    }
}