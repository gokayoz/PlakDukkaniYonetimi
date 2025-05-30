namespace PlakDukkaniYonetimi.UI
{
    partial class FRMGirisEkrani
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
            lblAdminGiris = new Label();
            chbSifremiGoster = new CheckBox();
            lblSifre = new Label();
            lblKullaniciAdi = new Label();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            btnKayitOl = new Button();
            btnGirisYap = new Button();
            pnlBaslik = new Panel();
            lblBaslik = new Label();
            pnlBaslik.SuspendLayout();
            SuspendLayout();
            // 
            // lblAdminGiris
            // 
            lblAdminGiris.AutoSize = true;
            lblAdminGiris.BackColor = Color.FromArgb(211, 84, 0);
            lblAdminGiris.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdminGiris.Location = new Point(299, 174);
            lblAdminGiris.Name = "lblAdminGiris";
            lblAdminGiris.Size = new Size(16, 20);
            lblAdminGiris.TabIndex = 13;
            lblAdminGiris.Text = "?";
            // 
            // chbSifremiGoster
            // 
            chbSifremiGoster.AutoSize = true;
            chbSifremiGoster.Location = new Point(121, 272);
            chbSifremiGoster.Name = "chbSifremiGoster";
            chbSifremiGoster.Size = new Size(125, 24);
            chbSifremiGoster.TabIndex = 12;
            chbSifremiGoster.Text = "Şifremi Göster";
            chbSifremiGoster.UseVisualStyleBackColor = true;
            chbSifremiGoster.CheckedChanged += chbSifremiGoster_CheckedChanged;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(73, 225);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(42, 20);
            lblSifre.TabIndex = 8;
            lblSifre.Text = "Şifre:";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(20, 174);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(95, 20);
            lblKullaniciAdi.TabIndex = 9;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(121, 222);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(163, 27);
            txtSifre.TabIndex = 7;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(121, 171);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(163, 27);
            txtKullaniciAdi.TabIndex = 6;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.FromArgb(211, 84, 0);
            btnKayitOl.FlatAppearance.BorderSize = 0;
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Location = new Point(202, 323);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(94, 29);
            btnKayitOl.TabIndex = 11;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.FromArgb(211, 84, 0);
            btnGirisYap.FlatAppearance.BorderSize = 0;
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.Location = new Point(50, 323);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(94, 29);
            btnGirisYap.TabIndex = 10;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // pnlBaslik
            // 
            pnlBaslik.BackColor = Color.FromArgb(50, 50, 50);
            pnlBaslik.Controls.Add(lblBaslik);
            pnlBaslik.Dock = DockStyle.Top;
            pnlBaslik.Location = new Point(0, 0);
            pnlBaslik.Name = "pnlBaslik";
            pnlBaslik.Size = new Size(346, 115);
            pnlBaslik.TabIndex = 14;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBaslik.Location = new Point(38, 25);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(268, 56);
            lblBaslik.TabIndex = 5;
            lblBaslik.Text = "Plak Dükkanı Yönetim Sistemi\r\n        Yönetici Giriş Ekranı";
            // 
            // FRMGirisEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 46, 46);
            ClientSize = new Size(346, 450);
            Controls.Add(pnlBaslik);
            Controls.Add(lblAdminGiris);
            Controls.Add(chbSifremiGoster);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(btnKayitOl);
            Controls.Add(btnGirisYap);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FRMGirisEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FRMGirisEkrani_Load;
            pnlBaslik.ResumeLayout(false);
            pnlBaslik.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdminGiris;
        private CheckBox chbSifremiGoster;
        private Label lblSifre;
        private Label lblKullaniciAdi;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Button btnKayitOl;
        private Button btnGirisYap;
        private Panel pnlBaslik;
        private Label lblBaslik;
    }
}
