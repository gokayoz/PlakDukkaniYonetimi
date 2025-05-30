using PlakDukkaniYonetimi.Core.Context;
using PlakDukkaniYonetimi.Core.Helpers;

namespace PlakDukkaniYonetimi.UI
{
    public partial class FRMGirisEkrani : Form
    {
        private readonly PlakDukkaniContext _dbContext;
        public FRMGirisEkrani()
        {
            InitializeComponent();
            _dbContext = new PlakDukkaniContext();
        }

        private void FRMGirisEkrani_Load(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;

            ToolTip toolTip = new();
            toolTip.SetToolTip(lblAdminGiris, "Admin giri�i i�in:\nKullan�c� Ad�: admin\n�ifre = admin\nyazman�z yeterli.");
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre alan� bo� olamaz!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hashliSifre = HashSifre.SifreHashle(txtSifre.Text);
            var yonetici = _dbContext.Yoneticiler
                .FirstOrDefault(y => y.KullaniciAdi == txtKullaniciAdi.Text && y.Sifre == hashliSifre);

            if (yonetici != null)
            {
                MessageBox.Show("Giri� ba�ar�l�.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FRMAnaEkran fRMAnaEkran = new();
                fRMAnaEkran.Show();
            }
            else
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre hatal�!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            FRMKayitEkrani fRMKayitEkrani = new();
            fRMKayitEkrani.ShowDialog();
        }

        private void chbSifremiGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = !chbSifremiGoster.Checked;
        }
    }
}