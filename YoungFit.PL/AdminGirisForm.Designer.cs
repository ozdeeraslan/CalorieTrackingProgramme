namespace YoungFit.PL
{
    partial class AdminGirisForm
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
            txtAdminMail = new TextBox();
            label2 = new Label();
            txtAdminSifre = new TextBox();
            btnAdminGiris = new Button();
            btnAdminAnaSayfayaDon = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(159, 21);
            label1.TabIndex = 0;
            label1.Text = "Admin Mail Adresi :";
            // 
            // txtAdminMail
            // 
            txtAdminMail.Location = new Point(233, 26);
            txtAdminMail.Name = "txtAdminMail";
            txtAdminMail.Size = new Size(286, 29);
            txtAdminMail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(65, 81);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 0;
            label2.Text = "Admin Şifresi :";
            // 
            // txtAdminSifre
            // 
            txtAdminSifre.Location = new Point(233, 75);
            txtAdminSifre.Name = "txtAdminSifre";
            txtAdminSifre.PasswordChar = '*';
            txtAdminSifre.Size = new Size(286, 29);
            txtAdminSifre.TabIndex = 1;
            // 
            // btnAdminGiris
            // 
            btnAdminGiris.BackColor = Color.Beige;
            btnAdminGiris.FlatStyle = FlatStyle.Popup;
            btnAdminGiris.Location = new Point(22, 134);
            btnAdminGiris.Name = "btnAdminGiris";
            btnAdminGiris.Size = new Size(237, 43);
            btnAdminGiris.TabIndex = 2;
            btnAdminGiris.Text = "Sisteme Giriş Yap";
            btnAdminGiris.UseVisualStyleBackColor = false;
            btnAdminGiris.Click += btnAdminGiris_Click;
            // 
            // btnAdminAnaSayfayaDon
            // 
            btnAdminAnaSayfayaDon.BackColor = Color.Beige;
            btnAdminAnaSayfayaDon.FlatStyle = FlatStyle.Popup;
            btnAdminAnaSayfayaDon.Location = new Point(285, 134);
            btnAdminAnaSayfayaDon.Name = "btnAdminAnaSayfayaDon";
            btnAdminAnaSayfayaDon.Size = new Size(234, 43);
            btnAdminAnaSayfayaDon.TabIndex = 2;
            btnAdminAnaSayfayaDon.Text = "Ana Sayfaya Dön";
            btnAdminAnaSayfayaDon.UseVisualStyleBackColor = false;
            btnAdminAnaSayfayaDon.Click += btnAdminAnaSayfayaDon_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(460, 196);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // AdminGirisForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Nature__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(558, 277);
            Controls.Add(pictureBox1);
            Controls.Add(btnAdminAnaSayfayaDon);
            Controls.Add(btnAdminGiris);
            Controls.Add(txtAdminSifre);
            Controls.Add(label2);
            Controls.Add(txtAdminMail);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "AdminGirisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminGirisForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAdminMail;
        private Label label2;
        private TextBox txtAdminSifre;
        private Button btnAdminGiris;
        private Button btnAdminAnaSayfayaDon;
        private PictureBox pictureBox1;
    }
}