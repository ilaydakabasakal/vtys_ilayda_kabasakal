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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        private void urunEkle_Click(object sender, EventArgs e)
        {
            FrmUrun frm = new FrmUrun()
            {
                Text = "Urun Ekle",
                Urun = new URUNLER() { urunID = Guid.NewGuid() },
            };
        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunEkle(frm.Urun);
                if (b)
                {
                    DataSet ds = BLogic.UrunHepsi(" ");
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.UrunHepsi(toolStripButton2.Text);
            if (ds2 != null)
            {
                dataGridView1.DataSource = ds2.Tables[0];

            }
        }

        private void urunDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FrmUrun frm = new FrmUrun()
            {
                Text = "Urun Güncelle",
                Guncelle = true,
                Urun = new URUNLER()
                {
                    urunID = Guid.Parse(row.Cells[0].Value.ToString()),
                    urunAd = row.Cells[1].Value.ToString(),
                    kategori = row.Cells[2].Value.ToString(),
                    urunAciklama = row.Cells[3].Value.ToString(),
                    urunFiyat = double.Parse(row.Cells[4].Value.ToString()),
                    urunStok = double.Parse(row.Cells[5].Value.ToString()),

                },
            };
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunGuncelle(frm.Urun);
                if (b)
                {
                    row.Cells[1].Value = frm.Urun.urunAd;
                    row.Cells[2].Value = frm.Urun.kategori;
                    row.Cells[3].Value = frm.Urun.urunAciklama;
                    row.Cells[4].Value = frm.Urun.urunFiyat;
                    row.Cells[5].Value = frm.Urun.urunStok;


                }

            }
        }

        private void urunSil_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunSil(ID);
                if (b)
                {
                    DataSet ds = BLogic.UrunHepsi(" ");
                    if (ds != null)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }

                }

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void Urunler_Load(object sender, EventArgs e)
        {
          
            DataSet ds2 = BLogic.UrunHepsi("");
            if (ds2 != null)
            {
                dataGridView1.DataSource = ds2.Tables[0];

            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        public URUNLER Urun { get; set; }

        private void tamam_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            Urun = new URUNLER()
            {
                urunID = Guid.Parse(row.Cells[0].Value.ToString()),
                urunAd = row.Cells[1].Value.ToString(),
                kategori = row.Cells[2].Value.ToString(),
                urunAciklama = row.Cells[3].Value.ToString(),
                urunFiyat = double.Parse(row.Cells[4].Value.ToString()),
                urunStok = double.Parse(row.Cells[5].Value.ToString()),

            };
            DialogResult = DialogResult.OK;
        }

        private void iptall_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Urunler_Load_1(object sender, EventArgs e)
        {

            DataSet ds = BLogic.UrunHepsi(" ");
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
