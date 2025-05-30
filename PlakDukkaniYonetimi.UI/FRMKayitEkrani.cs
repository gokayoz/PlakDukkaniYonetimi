using Microsoft.EntityFrameworkCore;
using PlakDukkaniYonetimi.Core.Context;
using PlakDukkaniYonetimi.Core.Helpers;
using PlakDukkaniYonetimi.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkaniYonetimi.UI
{
    public partial class FRMKayitEkrani : Form
    {
        private readonly PlakDukkaniContext _dbContext;
        public FRMKayitEkrani()
        {
            InitializeComponent();
            _dbContext = new PlakDukkaniContext();
        }
        private void FRMKayitEkrani_Load(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
            txtSifreTekrar.UseSystemPasswordChar = true;

            ToolTip toolTip = new();
            toolTip.SetToolTip(lblSifreKriterleri, "- En az 8 karakter\n- En az 2 büyük harf\n- En az 3 küçük harf\n- !, :, +, *karakterlerinden en az 2 tane");
        }

        private bool SifreGecerliMi(string sifre)
        {
            if (sifre.Length < 8) return false;

            int buyukHarfSayisi = sifre.Count(char.IsUpper);
            int kucukHarfSayisi = sifre.Count(char.IsLower);
            int ozelKarakterSayisi = sifre.Count(c => c == '!' || c == ':' || c == '+' || c == '*');

            return buyukHarfSayisi >= 2 && kucukHarfSayisi >= 3 && ozelKarakterSayisi >= 2;
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text) || string.IsNullOrWhiteSpace(txtSifreTekrar.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreleriniz uyuşmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!SifreGecerliMi(txtSifre.Text))
            {
                MessageBox.Show("Şifre belirtilen kriterlere uymuyor lütfen şifre kriterlerini inceleyin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_dbContext.Yoneticiler.Any(y => y.KullaniciAdi == txtKullaniciAdi.Text))
            {
                MessageBox.Show("Bu kullanıcı adı zaten kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var yonetici = new Yonetici
            {
                KullaniciAdi = txtKullaniciAdi.Text,
                Sifre = HashSifre.SifreHashle(txtSifre.Text)
            };

            _dbContext.Yoneticiler.Add(yonetici);
            _dbContext.SaveChanges();

            MessageBox.Show("Kayıt başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void chbSifremiGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = !chbSifremiGoster.Checked;
            txtSifreTekrar.UseSystemPasswordChar = !chbSifremiGoster.Checked;
        }
    }
}
