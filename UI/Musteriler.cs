using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using veritabaniProje.BL;

namespace veritabaniProje.UI
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriSil(ID);
                if (b)
                {
                    DataSet ds = BLogic.MusteriHepsi(" ");
                    if (ds != null)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }

                }

            }
        }
        private void musteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteri frmMusteri = new FrmMusteri()
            {
                Text = "Müşteri Ekle",
                Musteri = new MUSTERILER() { musteriID = Guid.NewGuid() },
            };
        tekrar:
            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriEkle(frmMusteri.Musteri);
                if (b)
                {
                    DataSet ds = BLogic.MusteriHepsi(" ");
                    if (ds != null)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        goto tekrar;
                    }
                }
                else
                {
                    goto tekrar;
                }
            }
        }
        private void musteriHepsi_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MusteriHepsi(musteriHepsi.Text);
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];

            }
        }

        private void musteriDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FrmMusteri frmMusteri = new FrmMusteri()
            {
                Text = "Müşteri Güncelle",
                Guncelle = true,
                Musteri = new MUSTERILER()
                {
                    musteriID = Guid.Parse(row.Cells[0].Value.ToString()),
                    musteriAd = row.Cells[1].Value.ToString(),
                    musteriSoyad = row.Cells[2].Value.ToString(),
                    musteriMail = row.Cells[3].Value.ToString(),
                    musteriTelNo = row.Cells[4].Value.ToString(),

                },
            };
            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriGuncelle(frmMusteri.Musteri);
                if (b)
                {
                    row.Cells[1].Value = frmMusteri.Musteri.musteriAd;
                    row.Cells[2].Value = frmMusteri.Musteri.musteriSoyad;
                    row.Cells[3].Value = frmMusteri.Musteri.musteriMail;
                    row.Cells[4].Value = frmMusteri.Musteri.musteriTelNo;

                }

            }
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.MusteriHepsi("");
            if (ds1 != null)
            {
                dataGridView1.DataSource = ds1.Tables[0];

            }
        }

        private void Gonder_Click(object sender, EventArgs e)
        {

        }
        public MUSTERILER Musteri { get; set; }
        private void tamam_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            Musteri = new MUSTERILER()
            {
                musteriID = Guid.Parse(row.Cells[0].Value.ToString()),
                musteriAd = row.Cells[1].Value.ToString(),
                musteriSoyad = row.Cells[2].Value.ToString(),
                musteriMail = row.Cells[3].Value.ToString(),
                musteriTelNo = row.Cells[4].Value.ToString(),

            };



            DialogResult = DialogResult.OK;
        }

        private void iptall_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
    }
}
