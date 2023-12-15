namespace YoungFit.PL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btnAdminGirisi = new Button();
            btnUyeOlmadanDevamEt = new Button();
            btnKullaniciGirisi = new Button();
            label2 = new Label();
            btnUyeOl = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(26, 200);
            label1.Name = "label1";
            label1.Size = new Size(495, 68);
            label1.TabIndex = 0;
            label1.Text = "YOUNGFIT Kalori Takip Programı Ile Yapabilecekleriniz;";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAdminGirisi
            // 
            btnAdminGirisi.BackColor = Color.Beige;
            btnAdminGirisi.FlatStyle = FlatStyle.Popup;
            btnAdminGirisi.Location = new Point(884, 12);
            btnAdminGirisi.Name = "btnAdminGirisi";
            btnAdminGirisi.Size = new Size(168, 37);
            btnAdminGirisi.TabIndex = 1;
            btnAdminGirisi.Text = "Admin Girişi";
            btnAdminGirisi.UseVisualStyleBackColor = false;
            btnAdminGirisi.Click += btnAdminGirisi_Click;
            // 
            // btnUyeOlmadanDevamEt
            // 
            btnUyeOlmadanDevamEt.BackColor = Color.Beige;
            btnUyeOlmadanDevamEt.FlatStyle = FlatStyle.Popup;
            btnUyeOlmadanDevamEt.Location = new Point(527, 403);
            btnUyeOlmadanDevamEt.Name = "btnUyeOlmadanDevamEt";
            btnUyeOlmadanDevamEt.Size = new Size(345, 64);
            btnUyeOlmadanDevamEt.TabIndex = 1;
            btnUyeOlmadanDevamEt.Text = "Üye Olmadan Devam Et\r\n";
            btnUyeOlmadanDevamEt.TextAlign = ContentAlignment.TopCenter;
            btnUyeOlmadanDevamEt.UseVisualStyleBackColor = false;
            btnUyeOlmadanDevamEt.Click += btnUyeOlmadanDevamEt_Click;
            // 
            // btnKullaniciGirisi
            // 
            btnKullaniciGirisi.BackColor = Color.Beige;
            btnKullaniciGirisi.FlatStyle = FlatStyle.Popup;
            btnKullaniciGirisi.Location = new Point(527, 208);
            btnKullaniciGirisi.Name = "btnKullaniciGirisi";
            btnKullaniciGirisi.Size = new Size(345, 60);
            btnKullaniciGirisi.TabIndex = 1;
            btnKullaniciGirisi.Text = "Kullanıcı Girişi";
            btnKullaniciGirisi.UseVisualStyleBackColor = false;
            btnKullaniciGirisi.Click += btnKullaniciGirisi_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Beige;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(544, 440);
            label2.Name = "label2";
            label2.Size = new Size(319, 16);
            label2.TabIndex = 2;
            label2.Text = "(Bu kısımda sadece BKİ hesaplanacaktır.)\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUyeOl
            // 
            btnUyeOl.BackColor = Color.Beige;
            btnUyeOl.FlatStyle = FlatStyle.Popup;
            btnUyeOl.Location = new Point(527, 307);
            btnUyeOl.Name = "btnUyeOl";
            btnUyeOl.Size = new Size(345, 61);
            btnUyeOl.TabIndex = 3;
            btnUyeOl.Text = "Üye Ol";
            btnUyeOl.UseVisualStyleBackColor = false;
            btnUyeOl.Click += btnUyeOl_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 268);
            label3.Name = "label3";
            label3.Size = new Size(444, 346);
            label3.TabIndex = 4;
            label3.Text = resources.GetString("label3.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(155, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1060, 630);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnUyeOl);
            Controls.Add(label2);
            Controls.Add(btnKullaniciGirisi);
            Controls.Add(btnUyeOlmadanDevamEt);
            Controls.Add(btnAdminGirisi);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAdminGirisi;
        private Button btnUyeOlmadanDevamEt;
        private Button btnKullaniciGirisi;
        private Label label2;
        private Button btnUyeOl;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
