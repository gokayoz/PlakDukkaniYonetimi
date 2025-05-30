namespace PlakDukkaniYonetimi.UI
{
    partial class FRMKayitEkrani
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
            lblSifreKriterleri = new Label();
            chbSifremiGoster = new CheckBox();
            btnKayitOl = new Button();
            lblSifreTekrar = new Label();
            txtSifreTekrar = new TextBox();
            lblSifre = new Label();
            txtSifre = new TextBox();
            lblKullaniciAdi = new Label();
            txtKullaniciAdi = new TextBox();
            pnlBaslik.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBaslik
            // 
            pnlBaslik.BackColor = Color.FromArgb(50, 50, 50);
            pnlBaslik.Controls.Add(lblBaslik);
            pnlBaslik.Dock = DockStyle.Top;
            pnlBaslik.Location = new Point(0, 0);
            pnlBaslik.Name = "pnlBaslik";
            pnlBaslik.Size = new Size(452, 92);
            pnlBaslik.TabIndex = 1;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBaslik.Location = new Point(112, 34);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(227, 28);
            lblBaslik.TabIndex = 2;
            lblBaslik.Text = "Yönetici Yeni Kayıt Ekranı";
            // 
            // lblSifreKriterleri
            // 
            lblSifreKriterleri.AutoSize = true;
            lblSifreKriterleri.Location = new Point(64, 297);
            lblSifreKriterleri.Name = "lblSifreKriterleri";
            lblSifreKriterleri.Size = new Size(103, 20);
            lblSifreKriterleri.TabIndex = 14;
            lblSifreKriterleri.Text = "Şifre Kriterleri:";
            // 
            // chbSifremiGoster
            // 
            chbSifremiGoster.AutoSize = true;
            chbSifremiGoster.Location = new Point(188, 296);
            chbSifremiGoster.Name = "chbSifremiGoster";
            chbSifremiGoster.Size = new Size(125, 24);
            chbSifremiGoster.TabIndex = 13;
            chbSifremiGoster.Text = "Şifremi Göster";
            chbSifremiGoster.UseVisualStyleBackColor = true;
            chbSifremiGoster.CheckedChanged += chbSifremiGoster_CheckedChanged;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.FromArgb(211, 84, 0);
            btnKayitOl.FlatAppearance.BorderSize = 0;
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Location = new Point(278, 367);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(94, 29);
            btnKayitOl.TabIndex = 12;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // lblSifreTekrar
            // 
            lblSifreTekrar.AutoSize = true;
            lblSifreTekrar.Location = new Point(81, 248);
            lblSifreTekrar.Name = "lblSifreTekrar";
            lblSifreTekrar.Size = new Size(86, 20);
            lblSifreTekrar.TabIndex = 8;
            lblSifreTekrar.Text = "Şifre Tekrar:";
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(188, 245);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(184, 27);
            txtSifreTekrar.TabIndex = 9;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(125, 195);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(42, 20);
            lblSifre.TabIndex = 10;
            lblSifre.Text = "Şifre:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(188, 192);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(184, 27);
            txtSifre.TabIndex = 7;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(72, 143);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(95, 20);
            lblKullaniciAdi.TabIndex = 11;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(188, 140);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(184, 27);
            txtKullaniciAdi.TabIndex = 6;
            // 
            // FRMKayitEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 46);
            ClientSize = new Size(452, 477);
            Controls.Add(lblSifreKriterleri);
            Controls.Add(chbSifremiGoster);
            Controls.Add(btnKayitOl);
            Controls.Add(lblSifreTekrar);
            Controls.Add(txtSifreTekrar);
            Controls.Add(lblSifre);
            Controls.Add(txtSifre);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(pnlBaslik);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FRMKayitEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FRMKayitEkrani_Load;
            pnlBaslik.ResumeLayout(false);
            pnlBaslik.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBaslik;
        private Label lblBaslik;
        private Label lblSifreKriterleri;
        private CheckBox chbSifremiGoster;
        private Button btnKayitOl;
        private Label lblSifreTekrar;
        private TextBox txtSifreTekrar;
        private Label lblSifre;
        private TextBox txtSifre;
        private Label lblKullaniciAdi;
        private TextBox txtKullaniciAdi;
    }
}