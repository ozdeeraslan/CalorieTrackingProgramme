namespace YoungFit.PL
{
    partial class AdminForm
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
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnResimGuncelle = new Button();
            pbSecilenYemek = new PictureBox();
            dgvBesinler = new DataGridView();
            btnBesinSil = new Button();
            btnBesinDuzenle = new Button();
            btnBesinKaydet = new Button();
            cmbOgunOlcuBirimi = new ComboBox();
            nudKalori = new NumericUpDown();
            txtBesinAdi = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSecilenYemek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBesinler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKalori).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Nature__1_;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnResimGuncelle);
            groupBox1.Controls.Add(pbSecilenYemek);
            groupBox1.Controls.Add(dgvBesinler);
            groupBox1.Controls.Add(btnBesinSil);
            groupBox1.Controls.Add(btnBesinDuzenle);
            groupBox1.Controls.Add(btnBesinKaydet);
            groupBox1.Controls.Add(cmbOgunOlcuBirimi);
            groupBox1.Controls.Add(nudKalori);
            groupBox1.Controls.Add(txtBesinAdi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(906, 623);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Besin Ekleme İşlemleri";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(793, 535);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnResimGuncelle
            // 
            btnResimGuncelle.BackColor = Color.Beige;
            btnResimGuncelle.FlatStyle = FlatStyle.Popup;
            btnResimGuncelle.Location = new Point(576, 411);
            btnResimGuncelle.Name = "btnResimGuncelle";
            btnResimGuncelle.Size = new Size(315, 53);
            btnResimGuncelle.TabIndex = 7;
            btnResimGuncelle.Text = "Resmi Ekle / Güncelle";
            btnResimGuncelle.UseVisualStyleBackColor = false;
            btnResimGuncelle.Click += btnResimGuncelle_Click;
            // 
            // pbSecilenYemek
            // 
            pbSecilenYemek.BackColor = Color.Transparent;
            pbSecilenYemek.Location = new Point(576, 171);
            pbSecilenYemek.Name = "pbSecilenYemek";
            pbSecilenYemek.Size = new Size(315, 234);
            pbSecilenYemek.TabIndex = 6;
            pbSecilenYemek.TabStop = false;
            // 
            // dgvBesinler
            // 
            dgvBesinler.AllowUserToAddRows = false;
            dgvBesinler.AllowUserToDeleteRows = false;
            dgvBesinler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBesinler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBesinler.BackgroundColor = Color.LightGoldenrodYellow;
            dgvBesinler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBesinler.Location = new Point(17, 171);
            dgvBesinler.Name = "dgvBesinler";
            dgvBesinler.ReadOnly = true;
            dgvBesinler.RowHeadersWidth = 51;
            dgvBesinler.Size = new Size(543, 293);
            dgvBesinler.TabIndex = 5;
            dgvBesinler.SelectionChanged += dgvBesinler_SelectionChanged;
            // 
            // btnBesinSil
            // 
            btnBesinSil.BackColor = Color.Beige;
            btnBesinSil.FlatStyle = FlatStyle.Popup;
            btnBesinSil.Location = new Point(790, 470);
            btnBesinSil.Name = "btnBesinSil";
            btnBesinSil.Size = new Size(101, 52);
            btnBesinSil.TabIndex = 4;
            btnBesinSil.Text = "Sil";
            btnBesinSil.UseVisualStyleBackColor = false;
            btnBesinSil.Click += btnBesinSil_Click;
            // 
            // btnBesinDuzenle
            // 
            btnBesinDuzenle.BackColor = Color.Beige;
            btnBesinDuzenle.FlatStyle = FlatStyle.Popup;
            btnBesinDuzenle.Location = new Point(683, 470);
            btnBesinDuzenle.Name = "btnBesinDuzenle";
            btnBesinDuzenle.Size = new Size(101, 52);
            btnBesinDuzenle.TabIndex = 4;
            btnBesinDuzenle.Text = "Düzenle";
            btnBesinDuzenle.UseVisualStyleBackColor = false;
            btnBesinDuzenle.Click += btnBesinDuzenle_Click;
            // 
            // btnBesinKaydet
            // 
            btnBesinKaydet.BackColor = Color.Beige;
            btnBesinKaydet.FlatStyle = FlatStyle.Popup;
            btnBesinKaydet.Location = new Point(576, 470);
            btnBesinKaydet.Name = "btnBesinKaydet";
            btnBesinKaydet.Size = new Size(101, 52);
            btnBesinKaydet.TabIndex = 4;
            btnBesinKaydet.Text = "Kaydet";
            btnBesinKaydet.UseVisualStyleBackColor = false;
            btnBesinKaydet.Click += btnBesinKaydet_Click;
            // 
            // cmbOgunOlcuBirimi
            // 
            cmbOgunOlcuBirimi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOgunOlcuBirimi.FormattingEnabled = true;
            cmbOgunOlcuBirimi.Location = new Point(194, 77);
            cmbOgunOlcuBirimi.Name = "cmbOgunOlcuBirimi";
            cmbOgunOlcuBirimi.Size = new Size(190, 36);
            cmbOgunOlcuBirimi.TabIndex = 3;
            // 
            // nudKalori
            // 
            nudKalori.Location = new Point(194, 119);
            nudKalori.Maximum = new decimal(new int[] { 2500, 0, 0, 0 });
            nudKalori.Name = "nudKalori";
            nudKalori.Size = new Size(120, 34);
            nudKalori.TabIndex = 2;
            // 
            // txtBesinAdi
            // 
            txtBesinAdi.Location = new Point(194, 37);
            txtBesinAdi.Name = "txtBesinAdi";
            txtBesinAdi.Size = new Size(190, 34);
            txtBesinAdi.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(94, 121);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 0;
            label5.Text = "Kalorisi :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(6, 85);
            label6.Name = "label6";
            label6.Size = new Size(186, 28);
            label6.TabIndex = 0;
            label6.Text = "Öğün Ölçü Birimi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(77, 43);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 0;
            label2.Text = "Öğün Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 106);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 621);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSecilenYemek).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBesinler).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKalori).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbOgunOlcuBirimi;
        private NumericUpDown nudKalori;
        private TextBox txtBesinAdi;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label1;
        private DataGridView dgvBesinler;
        private Button btnBesinSil;
        private Button btnBesinDuzenle;
        private Button btnBesinKaydet;
        private PictureBox pbSecilenYemek;
        private Button btnResimGuncelle;
        private PictureBox pictureBox1;
    }
}