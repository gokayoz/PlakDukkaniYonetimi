using PlakDukkaniYonetimi.Core.Context;
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
    public partial class FRMAnaEkran : Form
    {
        private readonly PlakDukkaniContext _dbContext;
        public FRMAnaEkran()
        {
            InitializeComponent();
            _dbContext = new PlakDukkaniContext();
        }
        private void FRMAnaEkran_Load(object sender, EventArgs e)
        {
            TumListeleriYukle();
            FormuTemizle();
        }

        private void FormuTemizle()
        {
            txtAlbumAdi.Clear();
            txtSanatci.Clear();
            dtpCikisTarihi.Value = DateTime.Now;
            nudFiyat.Value = 0;
            nudIndirimOrani.Value = 0;
            chbSatisDevam.Checked = true;
        }

        private void TumListeleriYukle()
        {
            dgvTumAlbumler.DataSource = _dbContext.Albumler
                            .Select(a => new
                            {
                                a.Id,
                                a.AlbumAdi,
                                a.Sanatci,
                                a.CikisTarihi,
                                a.Fiyat,
                                IndirimOrani = a.IndirimOrani.HasValue ? a.IndirimOrani.Value.ToString("N2") + "%" : "-",
                                SatisDevamMi = a.SatisDevamMi ? "Evet" : "Hayır"
                            }).ToList();

            dgvSatisiDurmuslar.DataSource = _dbContext.Albumler
                .Where(a => !a.SatisDevamMi)
                .Select(a => new { a.AlbumAdi, a.Sanatci })
                .ToList();

            dgvSatisaDevamEdenler.DataSource = _dbContext.Albumler
                .Where(a => a.SatisDevamMi)
                .Select(a => new { a.AlbumAdi, a.Sanatci })
                .ToList();

            dgvSonEklenenler.DataSource = _dbContext.Albumler
                .OrderByDescending(a => a.Id)
                .Take(10)
                .Select(a => new { a.AlbumAdi, a.Sanatci })
                .ToList();

            dgvIndirimdekiler.DataSource = _dbContext.Albumler
                .Where(a => a.IndirimOrani.HasValue && a.IndirimOrani > 0)
                .OrderByDescending(a => a.IndirimOrani)
                .Select(a => new { a.AlbumAdi, a.Sanatci })
                .ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAlbumAdi.Text) || string.IsNullOrWhiteSpace(txtSanatci.Text))
            {
                MessageBox.Show("Albüm adı veya sanatçı adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var album = new Album
            {
                AlbumAdi = txtAlbumAdi.Text,
                Sanatci = txtSanatci.Text,
                CikisTarihi = dtpCikisTarihi.Value,
                Fiyat = nudFiyat.Value,
                IndirimOrani = nudIndirimOrani.Value > 0 ? nudIndirimOrani.Value : (decimal?)null,
                SatisDevamMi = chbSatisDevam.Checked
            };

            _dbContext.Albumler.Add(album);
            _dbContext.SaveChanges();

            MessageBox.Show("Albüm başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TumListeleriYukle();
            FormuTemizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvTumAlbumler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silme işlemi için bir albüm seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult onay = MessageBox.Show("Seçili albümü silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                int albumId = (int)dgvTumAlbumler.SelectedRows[0].Cells["Id"].Value;
                var album = _dbContext.Albumler.Find(albumId);

                if (album != null)
                {
                    _dbContext.Albumler.Remove(album);
                    _dbContext.SaveChanges();

                    MessageBox.Show("Albüm başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TumListeleriYukle();
                    FormuTemizle();
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvTumAlbumler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellemek için albüm seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAlbumAdi.Text) || string.IsNullOrWhiteSpace(txtSanatci.Text))
            {
                MessageBox.Show("Albüm adı veya sanatçı adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int albumId = (int)dgvTumAlbumler.SelectedRows[0].Cells["Id"].Value;
            var album = _dbContext.Albumler.Find(albumId);

            if (album != null)
            {
                album.AlbumAdi = txtAlbumAdi.Text;
                album.Sanatci = txtSanatci.Text;
                album.CikisTarihi = dtpCikisTarihi.Value;
                album.Fiyat = nudFiyat.Value;
                album.IndirimOrani = nudIndirimOrani.Value > 0 ? nudIndirimOrani.Value : (decimal?)null;
                album.SatisDevamMi = chbSatisDevam.Checked;

                _dbContext.SaveChanges();

                MessageBox.Show("Albüm başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TumListeleriYukle();
                FormuTemizle();
            }
        }

        private void dgvTumAlbumler_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvTumAlbumler.ClearSelection();
        }

        private void dgvTumAlbumler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTumAlbumler.SelectedRows.Count > 0)
            {
                int albumId = (int)dgvTumAlbumler.SelectedRows[0].Cells["Id"].Value;
                var album = _dbContext.Albumler.Find(albumId);

                if (album != null)
                {
                    txtAlbumAdi.Text = album.AlbumAdi;
                    txtSanatci.Text = album.Sanatci;
                    dtpCikisTarihi.Value = album.CikisTarihi;
                    nudFiyat.Value = album.Fiyat;
                    nudIndirimOrani.Value = album.IndirimOrani ?? 0;
                    chbSatisDevam.Checked = album.SatisDevamMi;
                }
            }
        }
    }
}
