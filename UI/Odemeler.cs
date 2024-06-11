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
    public partial class Odemeler : Form
    {
        public Odemeler()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void odemeEkle_Click(object sender, EventArgs e)
        {

            FrmOdeme frm = new FrmOdeme()
            {
                Text = "Odeme Yap",
                Odeme = new ODEMELER()
                {
                    odemeID = Guid.NewGuid(),
                }
            };

        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeEkle(frm.Odeme);
                if (b)
                {
                    DataSet ds1 = BLogic.OdemeDetay();
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
        private void Odemeler_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.OdemeDetay();
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void odemeDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                DateTime odemeTarih;
                double odemeTutar;

                // Use DateTime.TryParse to handle invalid date formats
                if (!DateTime.TryParse(row.Cells[3].Value.ToString(), out odemeTarih))
                {
                    MessageBox.Show("Geçersiz ödeme tarihi formatı.");
                    return;
                }

                // Use double.TryParse to handle invalid double formats
                if (!double.TryParse(row.Cells[4].Value.ToString(), out odemeTutar))
                {
                    MessageBox.Show("Geçersiz ödeme tutarı formatı.");
                    return;
                }

                FrmOdeme frm = new FrmOdeme()
                {
                    Text = "Ödeme Güncelle",
                    Guncelle = true,
                    Odeme = new ODEMELER()
                    {
                        odemeID = Guid.Parse(row.Cells[0].Value.ToString()),
                        musteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                        odemeTarih = DateTime.Parse(row.Cells[3].Value.ToString()),
                        odemeTutar = odemeTutar,
                        odemeDurum = row.Cells[5].Value.ToString(),
                        odemeAciklama = row.Cells[6].Value.ToString()
                    }
                };

                var sonuc = frm.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    bool b = BLogic.OdemeGuncelle(frm.Odeme);
                    if (b)
                    {
                        row.Cells[1].Value = frm.Odeme.musteriID;
                        row.Cells[3].Value = frm.Odeme.odemeTarih;
                        row.Cells[4].Value = frm.Odeme.odemeTutar;
                        row.Cells[5].Value = frm.Odeme.odemeDurum;
                        row.Cells[6].Value = frm.Odeme.odemeAciklama;
                    }
                    else
                    {
                        MessageBox.Show("Ödeme güncelleme işlemi başarısız oldu.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz bir ödeme seçin.");
            }
        }

        

        private void Odemeler_Load_1(object sender, EventArgs e)
        {
            DataSet ds = BLogic.OdemeDetay();
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void odemeSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeSil(ID);
                if (b)
                {
                    DataSet ds = BLogic.OdemeDetay();
                    if (ds != null)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }

                }

            }
        }

        private void odemeHepsi_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.OdemeDetay();
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        //private void odemeDuzenle_Click(object sender, EventArgs e)
        //{
        //    DataGridViewRow row = dataGridView1.SelectedRows[0];
        //    FrmOdeme frm = new FrmOdeme()
        //    {
        //        Text = "Ödeme Güncelle",
        //        Guncelle = true,
        //        Odeme = new ODEMELER()
        //        {
        //            odemeID = Guid.Parse(row.Cells[0].Value.ToString()),
        //            musteriID = Guid.Parse(row.Cells[1].Value.ToString()),
        //            odemeTarih = DateTime.Parse(row.Cells[2].Value.ToString()),
        //            odemeTutar = double.Parse(row.Cells[4].Value.ToString()),
        //            odemeDurum = row.Cells[5].Value.ToString(),
        //            odemeAciklama = row.Cells[6].Value.ToString(),

        //        },
        //    };
        //    var sonuc = frm.ShowDialog();
        //    if (sonuc == DialogResult.OK)
        //    {
        //        bool b = BLogic.OdemeGuncelle(frm.Odeme);
        //        if (b)
        //        {
        //            row.Cells[1].Value = frm.Odeme.musteriID;
        //            row.Cells[3].Value = frm.Odeme.odemeTarih;
        //            row.Cells[4].Value = frm.Odeme.odemeTutar;
        //            row.Cells[5].Value = frm.Odeme.odemeDurum;
        //            row.Cells[6].Value = frm.Odeme.odemeAciklama;


        //        }

        //    }

        //}
    }
}
