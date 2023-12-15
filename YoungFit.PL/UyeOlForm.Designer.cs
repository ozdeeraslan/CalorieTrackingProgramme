namespace YoungFit.PL
{
    partial class UyeOlForm
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
            txtMailOlustur = new TextBox();
            label2 = new Label();
            txtSifreOlustur = new TextBox();
            btnHesapOlustur = new Button();
            btnGeriDon = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 0;
            label1.Text = "Mail Adresi Giriniz :";
            // 
            // txtMailOlustur
            // 
            txtMailOlustur.Location = new Point(224, 19);
            txtMailOlustur.Name = "txtMailOlustur";
            txtMailOlustur.Size = new Size(330, 29);
            txtMailOlustur.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(66, 68);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 0;
            label2.Text = "Şifre Oluştur :";
            // 
            // txtSifreOlustur
            // 
            txtSifreOlustur.Location = new Point(224, 68);
            txtSifreOlustur.Name = "txtSifreOlustur";
            txtSifreOlustur.Size = new Size(330, 29);
            txtSifreOlustur.TabIndex = 1;
            // 
            // btnHesapOlustur
            // 
            btnHesapOlustur.BackColor = Color.Beige;
            btnHesapOlustur.FlatAppearance.BorderSize = 3;
            btnHesapOlustur.FlatStyle = FlatStyle.Popup;
            btnHesapOlustur.Location = new Point(12, 167);
            btnHesapOlustur.Name = "btnHesapOlustur";
            btnHesapOlustur.Size = new Size(200, 35);
            btnHesapOlustur.TabIndex = 3;
            btnHesapOlustur.Text = "Hesap Oluştur";
            btnHesapOlustur.UseVisualStyleBackColor = false;
            btnHesapOlustur.Click += btnHesapOlustur_Click;
            // 
            // btnGeriDon
            // 
            btnGeriDon.BackColor = Color.Beige;
            btnGeriDon.FlatStyle = FlatStyle.Popup;
            btnGeriDon.Location = new Point(224, 167);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(210, 35);
            btnGeriDon.TabIndex = 4;
            btnGeriDon.Text = "Ana Sayfaya Dön";
            btnGeriDon.UseVisualStyleBackColor = false;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            label3.Location = new Point(224, 105);
            label3.Name = "label3";
            label3.Size = new Size(330, 45);
            label3.TabIndex = 2;
            label3.Text = "şifre en az 8 karakterden oluşmalidir ve en az bir adet büyük harf, kücük harf, rakam icermelidir.";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(468, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // UyeOlForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Nature__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(568, 225);
            Controls.Add(pictureBox1);
            Controls.Add(btnGeriDon);
            Controls.Add(btnHesapOlustur);
            Controls.Add(label3);
            Controls.Add(txtSifreOlustur);
            Controls.Add(label2);
            Controls.Add(txtMailOlustur);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "UyeOlForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UyeOlForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMailOlustur;
        private Label label2;
        private TextBox txtSifreOlustur;
        private Button btnHesapOlustur;
        private Button btnGeriDon;
        private Label label3;
        private PictureBox pictureBox1;
    }
}