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
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
        }
        public MUSTERILER Musteri { get; set; }
        public Siparisler Siparis { get; set; }


        private void siparisEkle_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis()
            {
                Text = "Sipariş Yap",
                Siparis = new SIPARISLER()
                {
                    siparisID = Guid.NewGuid()
                }
            };

        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                if (frm.Musteri != null && frm.Urun != null)
                {
                    SIPARISLER yeniSiparis = new SIPARISLER()
                    {
                        siparisID = frm.Siparis.siparisID,
                        urunID = frm.Urun.urunID,
                        musteriID = frm.Musteri.musteriID,
                        siparisAdet = (float)frm.adet.Value
                    };

                    bool b = BLogic.SiparisEkle(yeniSiparis);
                    if (b)
                    {
                        MessageBox.Show("Sipariş başarıyla eklendi ve stok güncellendi.");

                        DataSet ds1 = BLogic.SiparisHepsi();
                        if (ds1 != null)
                        {
                            dataGridView1.DataSource = ds1.Tables[0];
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sipariş eklenirken bir hata oluştu.");
                        goto tekrar;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen müşteri ve ürünü seçin.");
                    goto tekrar;
                }
            }
        }


        private void Siparisler_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.SiparisHepsi();
            if (ds1 != null)
            {
                dataGridView1.DataSource = ds1.Tables[0];

            }
        }

        //private void siparisDuzenle_Click(object sender, EventArgs e)
        //{
        //    DataGridViewRow row = dataGridView1.SelectedRows[0];
        //    frmSiparis frm = new frmSiparis()
        //    {
        //        Text = "Sipariş Güncelle",
        //        Guncelle = true,
        //        Siparis = new SIPARISLER()
        //        {
        //            siparisID = Guid.Parse(row.Cells[0].Value.ToString()),
        //            musteriID = Guid.Parse(row.Cells[1].Value.ToString()),
        //            urunID = Guid.Parse(row.Cells[2].Value.ToString()),
        //            siparisAdet = Double.Parse(row.Cells[7].Value.ToString()),

        //        },
        //    };
        //    var sonuc = frm.ShowDialog();
        //    if (sonuc == DialogResult.OK)
        //    {
        //        bool b = BLogic.SiparisGuncelle(frm.Siparis);
        //        if (b)
        //        {
        //            row.Cells[1].Value = frm.Siparis.musteriID;
        //            row.Cells[2].Value = frm.Siparis.urunID;
        //            row.Cells[7].Value = frm.Siparis.siparisAdet;

        //        }

        //    }
        //}
        private void siparisDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                frmSiparis frm = new frmSiparis()
                {
                    Text = "Sipariş Güncelle",
                    Guncelle = true,
                    Siparis = new SIPARISLER()
                    {
                        siparisID = Guid.Parse(row.Cells[0].Value.ToString()),
                        musteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                        urunID = Guid.Parse(row.Cells[2].Value.ToString()),
                        siparisAdet = Double.Parse(row.Cells[6].Value.ToString()),
                    },
                };
                var sonuc = frm.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    bool b = BLogic.SiparisGuncelle(frm.Siparis);
                    if (b)
                    {
                        row.Cells[1].Value = frm.Siparis.musteriID;
                        row.Cells[2].Value = frm.Siparis.urunID;
                        row.Cells[6].Value = frm.Siparis.siparisAdet;
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir sipariş seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void siparisSil_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SiparisSil(ID);
                if (b)
                {
                    DataSet ds = BLogic.SiparisHepsi();
                    if (ds != null)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }

                }

            }
        }
    }
}
