namespace YoungFit.PL
{
    partial class KullaniciSistemeGirisForm
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
            label1 = new Label();
            txtKullaniciGirisMail = new TextBox();
            label2 = new Label();
            txtKullaniciGirisSifre = new TextBox();
            btnKullaniciSistemeGiris = new Button();
            btnAnaSayfayaDon = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(27, 37);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Email :";
            // 
            // txtKullaniciGirisMail
            // 
            txtKullaniciGirisMail.Location = new Point(196, 31);
            txtKullaniciGirisMail.Name = "txtKullaniciGirisMail";
            txtKullaniciGirisMail.Size = new Size(286, 29);
            txtKullaniciGirisMail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(123, 87);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 0;
            label2.Text = "Şifre :";
            // 
            // txtKullaniciGirisSifre
            // 
            txtKullaniciGirisSifre.Location = new Point(196, 81);
            txtKullaniciGirisSifre.Name = "txtKullaniciGirisSifre";
            txtKullaniciGirisSifre.PasswordChar = '*';
            txtKullaniciGirisSifre.Size = new Size(286, 29);
            txtKullaniciGirisSifre.TabIndex = 1;
            // 
            // btnKullaniciSistemeGiris
            // 
            btnKullaniciSistemeGiris.BackColor = Color.Beige;
            btnKullaniciSistemeGiris.FlatStyle = FlatStyle.Popup;
            btnKullaniciSistemeGiris.Location = new Point(19, 163);
            btnKullaniciSistemeGiris.Name = "btnKullaniciSistemeGiris";
            btnKullaniciSistemeGiris.Size = new Size(189, 39);
            btnKullaniciSistemeGiris.TabIndex = 2;
            btnKullaniciSistemeGiris.Text = "Sisteme Giriş Yap";
            btnKullaniciSistemeGiris.UseVisualStyleBackColor = false;
            btnKullaniciSistemeGiris.Click += btnKullaniciSistemeGiris_Click;
            // 
            // btnAnaSayfayaDon
            // 
            btnAnaSayfayaDon.BackColor = Color.Beige;
            btnAnaSayfayaDon.FlatStyle = FlatStyle.Popup;
            btnAnaSayfayaDon.Location = new Point(236, 163);
            btnAnaSayfayaDon.Name = "btnAnaSayfayaDon";
            btnAnaSayfayaDon.Size = new Size(189, 39);
            btnAnaSayfayaDon.TabIndex = 2;
            btnAnaSayfayaDon.Text = "Ana Sayfaya Dön";
            btnAnaSayfayaDon.UseVisualStyleBackColor = false;
            btnAnaSayfayaDon.Click += btnAnaSayfayaDon_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(460, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // KullaniciSistemeGirisForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Nature__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(558, 217);
            Controls.Add(pictureBox1);
            Controls.Add(btnAnaSayfayaDon);
            Controls.Add(btnKullaniciSistemeGiris);
            Controls.Add(txtKullaniciGirisSifre);
            Controls.Add(label2);
            Controls.Add(txtKullaniciGirisMail);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "KullaniciSistemeGirisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KullaniciSistemeGirisForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKullaniciGirisMail;
        private Label label2;
        private TextBox txtKullaniciGirisSifre;
        private Button btnKullaniciSistemeGiris;
        private Button btnAnaSayfayaDon;
        private PictureBox pictureBox1;
    }
}