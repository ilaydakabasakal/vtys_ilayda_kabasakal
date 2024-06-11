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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace veritabaniProje.UI
{
    public partial class Satislar : Form
    {
        public Satislar()
        {
            InitializeComponent();
        }
        public MUSTERILER Musteri { get; set; }
        public Satislar Satis { get; set; }
        
        private void SatisDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FrmSatis frm = new FrmSatis()
            {
                Text = "Satış Güncelle",
                Guncelle = true,
                Satis = new SATISLAR()
                {
                    satisID = Guid.Parse(row.Cells[0].Value.ToString()),
                    musteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                    urunID = Guid.Parse(row.Cells[2].Value.ToString()),
                    satisTarih = DateTime.Parse(row.Cells[8].Value.ToString()),
                    satisAdres = row.Cells[9].Value.ToString(),

                },
            };
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatisGuncelle(frm.Satis);
                if (b)
                {
                    row.Cells[1].Value = frm.Satis.musteriID;
                    row.Cells[2].Value = frm.Satis.urunID;
                    row.Cells[8].Value = frm.Satis.satisTarih;
                    row.Cells[9].Value = frm.Satis.satisAdres;

                }

            }
        }

        private void satisSil_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatisSil(ID);
                if (b)
                {
                    DataSet ds = BLogic.SatisHepsi();
                    if (ds != null)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }

                }

            }
        }

        private void satisHepsi_Click(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.SatisHepsi();
            if (ds1 != null)
            {
                dataGridView1.DataSource = ds1.Tables[0];
                //dataGridView1.Columns["SatisID"].HeaderText = "Satış ID";
                //dataGridView1.Columns["MusteriID"].HeaderText = "Müşteri ID";
                //dataGridView1.Columns["UrunID"].HeaderText = "Ürün ID";
                //dataGridView1.Columns["MüşteriAdSoyad"].HeaderText = "Müşteri Ad Soyad";
                //dataGridView1.Columns["Ürün"].HeaderText = "Ürün";
                //dataGridView1.Columns["Kategori"].HeaderText = "Kategori";
                //dataGridView1.Columns["Fiyat"].HeaderText = "Fiyat";
                //dataGridView1.Columns["Stok"].HeaderText = "Stok";
            }
        }
        private void tamam_Click(object sender, EventArgs e)
        {
            
        }


        private void satisEkle_Click(object sender, EventArgs e)
        {
            FrmSatis frm = new FrmSatis()
            {
                Text = "Satış Yap",
                Satis = new SATISLAR()
                {
                    satisID = Guid.NewGuid(),
                }
            };

        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatisEkle(frm.Satis);
                if (b)
                {
                    DataSet ds1 = BLogic.SatisHepsi();
                    if (ds1 != null)
                    {
                        dataGridView1.DataSource = ds1.Tables[0];
                        //dataGridView1.Columns["SatisID"].HeaderText = "Satış ID";
                        //dataGridView1.Columns["MusteriID"].HeaderText = "Müşteri ID";
                        //dataGridView1.Columns["UrunID"].HeaderText = "Ürün ID";
                        //dataGridView1.Columns["MüşteriAdSoyad"].HeaderText = "Müşteri Ad Soyad";
                        //dataGridView1.Columns["Ürün"].HeaderText = "Ürün";
                        //dataGridView1.Columns["Kategori"].HeaderText = "Kategori";
                        //dataGridView1.Columns["Fiyat"].HeaderText = "Fiyat";
                        //dataGridView1.Columns["Stok"].HeaderText = "Stok";
                    }
                    //else
                    //{
                    //    goto tekrar;
                    //}
                }
                else
                {
                    goto tekrar;
                }
            }
        }


        private void iptall_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void Satislar_Load_1(object sender, EventArgs e)
        {

            DataSet ds = BLogic.SatisHepsi();
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        
    }
}
