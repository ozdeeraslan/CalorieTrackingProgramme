namespace YoungFit.PL
{
    partial class IstatistikleriGorForm
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
            dtpIstatistiklerTarih = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblToplamKalori = new Label();
            lblEnÇokYenenYemek = new Label();
            lstYenilenBesinler = new ListBox();
            label12 = new Label();
            btnAnaSayfayaDon = new Button();
            groupBox2 = new GroupBox();
            btnKiyasla = new Button();
            lstBirincininYedikleri = new ListBox();
            cmbKisi2 = new ComboBox();
            lstIkincininYedikleri = new ListBox();
            cmbKisi1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            cmbTumYemekler = new ComboBox();
            label9 = new Label();
            lstYemegiYiyenler = new ListBox();
            btnYemegiYİyenleriListele = new Button();
            label10 = new Label();
            lblKisi = new Label();
            pictureBox3 = new PictureBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dtpIstatistiklerTarih
            // 
            dtpIstatistiklerTarih.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dtpIstatistiklerTarih.Location = new Point(152, 16);
            dtpIstatistiklerTarih.Name = "dtpIstatistiklerTarih";
            dtpIstatistiklerTarih.Size = new Size(356, 29);
            dtpIstatistiklerTarih.TabIndex = 0;
            dtpIstatistiklerTarih.ValueChanged += dtpIstatistiklerTarih_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 1;
            label1.Text = "Tarih Seçiniz :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(12, 481);
            label2.Name = "label2";
            label2.Size = new Size(305, 21);
            label2.TabIndex = 1;
            label2.Text = "Tüm zamanlarda en çok yenen yemek :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(12, 412);
            label3.Name = "label3";
            label3.Size = new Size(219, 21);
            label3.TabIndex = 1;
            label3.Text = "Seçili Tarihte Alınan Kalori :";
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.AutoSize = true;
            lblToplamKalori.BackColor = Color.Transparent;
            lblToplamKalori.Location = new Point(247, 412);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(132, 21);
            lblToplamKalori.TabIndex = 2;
            lblToplamKalori.Text = "lblToplamKalori";
            // 
            // lblEnÇokYenenYemek
            // 
            lblEnÇokYenenYemek.AutoSize = true;
            lblEnÇokYenenYemek.BackColor = Color.Transparent;
            lblEnÇokYenenYemek.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblEnÇokYenenYemek.Location = new Point(323, 481);
            lblEnÇokYenenYemek.Name = "lblEnÇokYenenYemek";
            lblEnÇokYenenYemek.Size = new Size(66, 21);
            lblEnÇokYenenYemek.TabIndex = 2;
            lblEnÇokYenenYemek.Text = "_yemek";
            // 
            // lstYenilenBesinler
            // 
            lstYenilenBesinler.DisplayMember = "YemekAdi";
            lstYenilenBesinler.FormattingEnabled = true;
            lstYenilenBesinler.ItemHeight = 21;
            lstYenilenBesinler.Location = new Point(21, 116);
            lstYenilenBesinler.Name = "lstYenilenBesinler";
            lstYenilenBesinler.Size = new Size(390, 277);
            lstYenilenBesinler.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(21, 66);
            label12.Name = "label12";
            label12.Size = new Size(268, 21);
            label12.TabIndex = 3;
            label12.Text = "Seçilen tarihte yediğiniz besinler :";
            // 
            // btnAnaSayfayaDon
            // 
            btnAnaSayfayaDon.BackColor = Color.Beige;
            btnAnaSayfayaDon.FlatStyle = FlatStyle.Popup;
            btnAnaSayfayaDon.Location = new Point(825, 23);
            btnAnaSayfayaDon.Name = "btnAnaSayfayaDon";
            btnAnaSayfayaDon.Size = new Size(230, 40);
            btnAnaSayfayaDon.TabIndex = 5;
            btnAnaSayfayaDon.Text = "Ana Sayfaya Dön";
            btnAnaSayfayaDon.UseVisualStyleBackColor = false;
            btnAnaSayfayaDon.Click += btnAnaSayfayaDon_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnKiyasla);
            groupBox2.Controls.Add(lstBirincininYedikleri);
            groupBox2.Controls.Add(cmbKisi2);
            groupBox2.Controls.Add(lstIkincininYedikleri);
            groupBox2.Controls.Add(cmbKisi1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(21, 554);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(958, 351);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kıyaslama Raporu";
            // 
            // btnKiyasla
            // 
            btnKiyasla.BackColor = Color.Beige;
            btnKiyasla.FlatStyle = FlatStyle.Popup;
            btnKiyasla.Location = new Point(763, 290);
            btnKiyasla.Name = "btnKiyasla";
            btnKiyasla.Size = new Size(168, 34);
            btnKiyasla.TabIndex = 5;
            btnKiyasla.Text = "KIYASLA";
            btnKiyasla.UseVisualStyleBackColor = false;
            btnKiyasla.Click += btnKiyasla_Click;
            // 
            // lstBirincininYedikleri
            // 
            lstBirincininYedikleri.FormattingEnabled = true;
            lstBirincininYedikleri.ItemHeight = 21;
            lstBirincininYedikleri.Location = new Point(38, 131);
            lstBirincininYedikleri.Name = "lstBirincininYedikleri";
            lstBirincininYedikleri.Size = new Size(320, 193);
            lstBirincininYedikleri.TabIndex = 4;
            // 
            // cmbKisi2
            // 
            cmbKisi2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKisi2.FormattingEnabled = true;
            cmbKisi2.Location = new Point(388, 62);
            cmbKisi2.Name = "cmbKisi2";
            cmbKisi2.Size = new Size(319, 29);
            cmbKisi2.TabIndex = 0;
            // 
            // lstIkincininYedikleri
            // 
            lstIkincininYedikleri.FormattingEnabled = true;
            lstIkincininYedikleri.ItemHeight = 21;
            lstIkincininYedikleri.Location = new Point(388, 131);
            lstIkincininYedikleri.Name = "lstIkincininYedikleri";
            lstIkincininYedikleri.Size = new Size(319, 193);
            lstIkincininYedikleri.TabIndex = 4;
            // 
            // cmbKisi1
            // 
            cmbKisi1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKisi1.FormattingEnabled = true;
            cmbKisi1.Location = new Point(38, 62);
            cmbKisi1.Name = "cmbKisi1";
            cmbKisi1.Size = new Size(320, 29);
            cmbKisi1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(477, 30);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 3;
            label5.Text = "2. Kişi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 30);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 3;
            label4.Text = "1. Kişi :";
            // 
            // cmbTumYemekler
            // 
            cmbTumYemekler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTumYemekler.FormattingEnabled = true;
            cmbTumYemekler.Location = new Point(508, 76);
            cmbTumYemekler.Name = "cmbTumYemekler";
            cmbTumYemekler.Size = new Size(311, 29);
            cmbTumYemekler.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(597, 35);
            label9.Name = "label9";
            label9.Size = new Size(98, 21);
            label9.TabIndex = 13;
            label9.Text = "YEMEKLER :";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // lstYemegiYiyenler
            // 
            lstYemegiYiyenler.FormattingEnabled = true;
            lstYemegiYiyenler.ItemHeight = 21;
            lstYemegiYiyenler.Location = new Point(508, 205);
            lstYemegiYiyenler.Name = "lstYemegiYiyenler";
            lstYemegiYiyenler.Size = new Size(311, 277);
            lstYemegiYiyenler.TabIndex = 4;
            // 
            // btnYemegiYİyenleriListele
            // 
            btnYemegiYİyenleriListele.BackColor = Color.Beige;
            btnYemegiYİyenleriListele.FlatStyle = FlatStyle.Popup;
            btnYemegiYİyenleriListele.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnYemegiYİyenleriListele.Location = new Point(508, 128);
            btnYemegiYİyenleriListele.Name = "btnYemegiYİyenleriListele";
            btnYemegiYİyenleriListele.Size = new Size(311, 50);
            btnYemegiYİyenleriListele.TabIndex = 14;
            btnYemegiYİyenleriListele.Text = "Secilen yemeği yiyen kişileri listele";
            btnYemegiYİyenleriListele.UseVisualStyleBackColor = false;
            btnYemegiYİyenleriListele.Click += btnYemegiYİyenleriListele_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.Location = new Point(825, 66);
            label10.Name = "label10";
            label10.Size = new Size(104, 19);
            label10.TabIndex = 15;
            label10.Text = "Aktif Oturum :";
            // 
            // lblKisi
            // 
            lblKisi.AutoSize = true;
            lblKisi.BackColor = Color.Transparent;
            lblKisi.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            lblKisi.Location = new Point(951, 66);
            lblKisi.Name = "lblKisi";
            lblKisi.Size = new Size(56, 19);
            lblKisi.TabIndex = 16;
            lblKisi.Text = "label11";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = Properties.Resources.logo;
            pictureBox3.Location = new Point(1045, 810);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(107, 95);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // IstatistikleriGorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Nature__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1164, 910);
            Controls.Add(lblKisi);
            Controls.Add(label10);
            Controls.Add(btnYemegiYİyenleriListele);
            Controls.Add(lstYemegiYiyenler);
            Controls.Add(label9);
            Controls.Add(cmbTumYemekler);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox3);
            Controls.Add(btnAnaSayfayaDon);
            Controls.Add(lstYenilenBesinler);
            Controls.Add(label12);
            Controls.Add(lblEnÇokYenenYemek);
            Controls.Add(lblToplamKalori);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpIstatistiklerTarih);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "IstatistikleriGorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IstatistikleriGorForm";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpIstatistiklerTarih;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblToplamKalori;
        private Label lblEnÇokYenenYemek;
        private ListBox lstYenilenBesinler;
        private Label label12;
        private Button btnAnaSayfayaDon;
        private GroupBox groupBox2;
        private ComboBox cmbKisi1;
        private ComboBox cmbKisi2;
        private Label label5;
        private Label label4;
        private ListBox lstIkincininYedikleri;
        private ListBox lstBirincininYedikleri;
        private ComboBox cmbTumYemekler;
        private Label label9;
        private ListBox lstYemegiYiyenler;
        private Button btnYemegiYİyenleriListele;
        private Label label10;
        private Label lblKisi;
        private PictureBox pictureBox3;
        private Button btnKiyasla;
    }
}