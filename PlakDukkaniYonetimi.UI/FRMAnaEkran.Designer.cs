namespace PlakDukkaniYonetimi.UI
{
    partial class FRMAnaEkran
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
            pnlBaslik = new Panel();
            lblBaslik = new Label();
            tbcAnaEkran = new TabControl();
            tpTumAlbumler = new TabPage();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            chbSatisDevam = new CheckBox();
            nudIndirimOrani = new NumericUpDown();
            nudFiyat = new NumericUpDown();
            dtpCikisTarihi = new DateTimePicker();
            lblCikisTarihi = new Label();
            lblIndirimOrani = new Label();
            lblFiyat = new Label();
            lblSanatci = new Label();
            txtSanatci = new TextBox();
            lblAlbumAdi = new Label();
            txtAlbumAdi = new TextBox();
            dgvTumAlbumler = new DataGridView();
            tpSatisiDurmus = new TabPage();
            dgvSatisiDurmuslar = new DataGridView();
            tpSatisaDevam = new TabPage();
            dgvSatisaDevamEdenler = new DataGridView();
            tpSonEklenen = new TabPage();
            dgvSonEklenenler = new DataGridView();
            tpIndirim = new TabPage();
            dgvIndirimdekiler = new DataGridView();
            pnlBaslik.SuspendLayout();
            tbcAnaEkran.SuspendLayout();
            tpTumAlbumler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIndirimOrani).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTumAlbumler).BeginInit();
            tpSatisiDurmus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSatisiDurmuslar).BeginInit();
            tpSatisaDevam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSatisaDevamEdenler).BeginInit();
            tpSonEklenen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSonEklenenler).BeginInit();
            tpIndirim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIndirimdekiler).BeginInit();
            SuspendLayout();
            // 
            // pnlBaslik
            // 
            pnlBaslik.BackColor = Color.FromArgb(50, 50, 50);
            pnlBaslik.Controls.Add(lblBaslik);
            pnlBaslik.Dock = DockStyle.Top;
            pnlBaslik.Location = new Point(0, 0);
            pnlBaslik.Name = "pnlBaslik";
            pnlBaslik.Size = new Size(902, 73);
            pnlBaslik.TabIndex = 2;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = Color.WhiteSmoke;
            lblBaslik.Location = new Point(263, 18);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(366, 28);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Albümler ve Bilgilendirme Listeleri Ekranı";
            // 
            // tbcAnaEkran
            // 
            tbcAnaEkran.Controls.Add(tpTumAlbumler);
            tbcAnaEkran.Controls.Add(tpSatisiDurmus);
            tbcAnaEkran.Controls.Add(tpSatisaDevam);
            tbcAnaEkran.Controls.Add(tpSonEklenen);
            tbcAnaEkran.Controls.Add(tpIndirim);
            tbcAnaEkran.Dock = DockStyle.Bottom;
            tbcAnaEkran.Location = new Point(0, 75);
            tbcAnaEkran.Name = "tbcAnaEkran";
            tbcAnaEkran.SelectedIndex = 0;
            tbcAnaEkran.Size = new Size(902, 586);
            tbcAnaEkran.TabIndex = 3;
            // 
            // tpTumAlbumler
            // 
            tpTumAlbumler.BackColor = Color.FromArgb(46, 46, 46);
            tpTumAlbumler.Controls.Add(btnGuncelle);
            tpTumAlbumler.Controls.Add(btnSil);
            tpTumAlbumler.Controls.Add(btnEkle);
            tpTumAlbumler.Controls.Add(chbSatisDevam);
            tpTumAlbumler.Controls.Add(nudIndirimOrani);
            tpTumAlbumler.Controls.Add(nudFiyat);
            tpTumAlbumler.Controls.Add(dtpCikisTarihi);
            tpTumAlbumler.Controls.Add(lblCikisTarihi);
            tpTumAlbumler.Controls.Add(lblIndirimOrani);
            tpTumAlbumler.Controls.Add(lblFiyat);
            tpTumAlbumler.Controls.Add(lblSanatci);
            tpTumAlbumler.Controls.Add(txtSanatci);
            tpTumAlbumler.Controls.Add(lblAlbumAdi);
            tpTumAlbumler.Controls.Add(txtAlbumAdi);
            tpTumAlbumler.Controls.Add(dgvTumAlbumler);
            tpTumAlbumler.Location = new Point(4, 29);
            tpTumAlbumler.Name = "tpTumAlbumler";
            tpTumAlbumler.Padding = new Padding(3);
            tpTumAlbumler.Size = new Size(894, 553);
            tpTumAlbumler.TabIndex = 0;
            tpTumAlbumler.Text = "Tümü";
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(211, 84, 0);
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.ForeColor = Color.WhiteSmoke;
            btnGuncelle.Location = new Point(535, 145);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(211, 84, 0);
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ForeColor = Color.WhiteSmoke;
            btnSil.Location = new Point(392, 145);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(211, 84, 0);
            btnEkle.FlatAppearance.BorderSize = 0;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.ForeColor = Color.WhiteSmoke;
            btnEkle.Location = new Point(251, 145);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // chbSatisDevam
            // 
            chbSatisDevam.AutoSize = true;
            chbSatisDevam.ForeColor = Color.WhiteSmoke;
            chbSatisDevam.Location = new Point(658, 81);
            chbSatisDevam.Name = "chbSatisDevam";
            chbSatisDevam.Size = new Size(159, 24);
            chbSatisDevam.TabIndex = 5;
            chbSatisDevam.Text = "Satış Devam Ediyor";
            chbSatisDevam.UseVisualStyleBackColor = true;
            // 
            // nudIndirimOrani
            // 
            nudIndirimOrani.Location = new Point(356, 79);
            nudIndirimOrani.Name = "nudIndirimOrani";
            nudIndirimOrani.Size = new Size(145, 27);
            nudIndirimOrani.TabIndex = 4;
            // 
            // nudFiyat
            // 
            nudFiyat.Location = new Point(356, 32);
            nudFiyat.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudFiyat.Name = "nudFiyat";
            nudFiyat.Size = new Size(145, 27);
            nudFiyat.TabIndex = 4;
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(613, 30);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(250, 27);
            dtpCikisTarihi.TabIndex = 3;
            // 
            // lblCikisTarihi
            // 
            lblCikisTarihi.AutoSize = true;
            lblCikisTarihi.ForeColor = Color.WhiteSmoke;
            lblCikisTarihi.Location = new Point(529, 36);
            lblCikisTarihi.Name = "lblCikisTarihi";
            lblCikisTarihi.Size = new Size(81, 20);
            lblCikisTarihi.TabIndex = 2;
            lblCikisTarihi.Text = "Çıkış Tarihi:";
            // 
            // lblIndirimOrani
            // 
            lblIndirimOrani.AutoSize = true;
            lblIndirimOrani.ForeColor = Color.WhiteSmoke;
            lblIndirimOrani.Location = new Point(254, 89);
            lblIndirimOrani.Name = "lblIndirimOrani";
            lblIndirimOrani.Size = new Size(99, 20);
            lblIndirimOrani.TabIndex = 2;
            lblIndirimOrani.Text = "İndirim Oranı:";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.ForeColor = Color.WhiteSmoke;
            lblFiyat.Location = new Point(289, 42);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(43, 20);
            lblFiyat.TabIndex = 2;
            lblFiyat.Text = "Fiyat:";
            // 
            // lblSanatci
            // 
            lblSanatci.AutoSize = true;
            lblSanatci.ForeColor = Color.WhiteSmoke;
            lblSanatci.Location = new Point(36, 85);
            lblSanatci.Name = "lblSanatci";
            lblSanatci.Size = new Size(60, 20);
            lblSanatci.TabIndex = 2;
            lblSanatci.Text = "Sanatçı:";
            // 
            // txtSanatci
            // 
            txtSanatci.Location = new Point(99, 79);
            txtSanatci.Name = "txtSanatci";
            txtSanatci.Size = new Size(146, 27);
            txtSanatci.TabIndex = 1;
            // 
            // lblAlbumAdi
            // 
            lblAlbumAdi.AutoSize = true;
            lblAlbumAdi.ForeColor = Color.WhiteSmoke;
            lblAlbumAdi.Location = new Point(13, 39);
            lblAlbumAdi.Name = "lblAlbumAdi";
            lblAlbumAdi.Size = new Size(83, 20);
            lblAlbumAdi.TabIndex = 2;
            lblAlbumAdi.Text = "Albüm Adı:";
            // 
            // txtAlbumAdi
            // 
            txtAlbumAdi.Location = new Point(99, 32);
            txtAlbumAdi.Name = "txtAlbumAdi";
            txtAlbumAdi.Size = new Size(146, 27);
            txtAlbumAdi.TabIndex = 1;
            // 
            // dgvTumAlbumler
            // 
            dgvTumAlbumler.AllowUserToAddRows = false;
            dgvTumAlbumler.AllowUserToDeleteRows = false;
            dgvTumAlbumler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTumAlbumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTumAlbumler.Location = new Point(8, 190);
            dgvTumAlbumler.Name = "dgvTumAlbumler";
            dgvTumAlbumler.ReadOnly = true;
            dgvTumAlbumler.RowHeadersWidth = 51;
            dgvTumAlbumler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTumAlbumler.Size = new Size(878, 355);
            dgvTumAlbumler.TabIndex = 0;
            dgvTumAlbumler.DataBindingComplete += dgvTumAlbumler_DataBindingComplete;
            dgvTumAlbumler.SelectionChanged += dgvTumAlbumler_SelectionChanged;
            // 
            // tpSatisiDurmus
            // 
            tpSatisiDurmus.BackColor = Color.FromArgb(46, 46, 46);
            tpSatisiDurmus.Controls.Add(dgvSatisiDurmuslar);
            tpSatisiDurmus.Location = new Point(4, 29);
            tpSatisiDurmus.Name = "tpSatisiDurmus";
            tpSatisiDurmus.Padding = new Padding(3);
            tpSatisiDurmus.Size = new Size(894, 553);
            tpSatisiDurmus.TabIndex = 1;
            tpSatisiDurmus.Text = "Satışı Durdurulmuş";
            // 
            // dgvSatisiDurmuslar
            // 
            dgvSatisiDurmuslar.AllowUserToAddRows = false;
            dgvSatisiDurmuslar.AllowUserToDeleteRows = false;
            dgvSatisiDurmuslar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSatisiDurmuslar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSatisiDurmuslar.Location = new Point(31, 43);
            dgvSatisiDurmuslar.Name = "dgvSatisiDurmuslar";
            dgvSatisiDurmuslar.ReadOnly = true;
            dgvSatisiDurmuslar.RowHeadersWidth = 51;
            dgvSatisiDurmuslar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSatisiDurmuslar.Size = new Size(822, 480);
            dgvSatisiDurmuslar.TabIndex = 0;
            // 
            // tpSatisaDevam
            // 
            tpSatisaDevam.BackColor = Color.FromArgb(46, 46, 46);
            tpSatisaDevam.Controls.Add(dgvSatisaDevamEdenler);
            tpSatisaDevam.Location = new Point(4, 29);
            tpSatisaDevam.Name = "tpSatisaDevam";
            tpSatisaDevam.Padding = new Padding(3);
            tpSatisaDevam.Size = new Size(894, 553);
            tpSatisaDevam.TabIndex = 2;
            tpSatisaDevam.Text = "Satışa Devam Edenler";
            // 
            // dgvSatisaDevamEdenler
            // 
            dgvSatisaDevamEdenler.AllowUserToAddRows = false;
            dgvSatisaDevamEdenler.AllowUserToDeleteRows = false;
            dgvSatisaDevamEdenler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSatisaDevamEdenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSatisaDevamEdenler.Location = new Point(31, 43);
            dgvSatisaDevamEdenler.Name = "dgvSatisaDevamEdenler";
            dgvSatisaDevamEdenler.ReadOnly = true;
            dgvSatisaDevamEdenler.RowHeadersWidth = 51;
            dgvSatisaDevamEdenler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSatisaDevamEdenler.Size = new Size(822, 480);
            dgvSatisaDevamEdenler.TabIndex = 0;
            // 
            // tpSonEklenen
            // 
            tpSonEklenen.BackColor = Color.FromArgb(46, 46, 46);
            tpSonEklenen.Controls.Add(dgvSonEklenenler);
            tpSonEklenen.Location = new Point(4, 29);
            tpSonEklenen.Name = "tpSonEklenen";
            tpSonEklenen.Padding = new Padding(3);
            tpSonEklenen.Size = new Size(894, 553);
            tpSonEklenen.TabIndex = 3;
            tpSonEklenen.Text = "Son Eklenen 10";
            // 
            // dgvSonEklenenler
            // 
            dgvSonEklenenler.AllowUserToAddRows = false;
            dgvSonEklenenler.AllowUserToDeleteRows = false;
            dgvSonEklenenler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSonEklenenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSonEklenenler.Location = new Point(31, 43);
            dgvSonEklenenler.Name = "dgvSonEklenenler";
            dgvSonEklenenler.ReadOnly = true;
            dgvSonEklenenler.RowHeadersWidth = 51;
            dgvSonEklenenler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSonEklenenler.Size = new Size(822, 480);
            dgvSonEklenenler.TabIndex = 0;
            // 
            // tpIndirim
            // 
            tpIndirim.BackColor = Color.FromArgb(46, 46, 46);
            tpIndirim.Controls.Add(dgvIndirimdekiler);
            tpIndirim.Location = new Point(4, 29);
            tpIndirim.Name = "tpIndirim";
            tpIndirim.Padding = new Padding(3);
            tpIndirim.Size = new Size(894, 553);
            tpIndirim.TabIndex = 4;
            tpIndirim.Text = "İndirimdekiler";
            // 
            // dgvIndirimdekiler
            // 
            dgvIndirimdekiler.AllowUserToAddRows = false;
            dgvIndirimdekiler.AllowUserToDeleteRows = false;
            dgvIndirimdekiler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIndirimdekiler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIndirimdekiler.Location = new Point(31, 43);
            dgvIndirimdekiler.Name = "dgvIndirimdekiler";
            dgvIndirimdekiler.ReadOnly = true;
            dgvIndirimdekiler.RowHeadersWidth = 51;
            dgvIndirimdekiler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIndirimdekiler.Size = new Size(822, 480);
            dgvIndirimdekiler.TabIndex = 0;
            // 
            // FRMAnaEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 46);
            CausesValidation = false;
            ClientSize = new Size(902, 661);
            Controls.Add(tbcAnaEkran);
            Controls.Add(pnlBaslik);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FRMAnaEkran";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FRMAnaEkran_Load;
            pnlBaslik.ResumeLayout(false);
            pnlBaslik.PerformLayout();
            tbcAnaEkran.ResumeLayout(false);
            tpTumAlbumler.ResumeLayout(false);
            tpTumAlbumler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudIndirimOrani).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTumAlbumler).EndInit();
            tpSatisiDurmus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSatisiDurmuslar).EndInit();
            tpSatisaDevam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSatisaDevamEdenler).EndInit();
            tpSonEklenen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSonEklenenler).EndInit();
            tpIndirim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIndirimdekiler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBaslik;
        private Label lblBaslik;
        private TabControl tbcAnaEkran;
        private TabPage tpTumAlbumler;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private CheckBox chbSatisDevam;
        private NumericUpDown nudIndirimOrani;
        private NumericUpDown nudFiyat;
        private DateTimePicker dtpCikisTarihi;
        private Label lblCikisTarihi;
        private Label lblIndirimOrani;
        private Label lblFiyat;
        private Label lblSanatci;
        private TextBox txtSanatci;
        private Label lblAlbumAdi;
        private TextBox txtAlbumAdi;
        private DataGridView dgvTumAlbumler;
        private TabPage tpSatisiDurmus;
        private DataGridView dgvSatisiDurmuslar;
        private TabPage tpSatisaDevam;
        private DataGridView dgvSatisaDevamEdenler;
        private TabPage tpSonEklenen;
        private DataGridView dgvSonEklenenler;
        private TabPage tpIndirim;
        private DataGridView dgvIndirimdekiler;
    }
}