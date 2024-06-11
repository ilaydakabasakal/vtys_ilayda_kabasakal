using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabaniProje.UI
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            textID.Text = Urun.urunID.ToString();
            if (Guncelle)
            {
                kategori.Text = Urun.kategori;
                textUrun.Text = Urun.urunAd;
                Fiyat.Value =(decimal) Urun.urunFiyat;
                Stok.Value = (decimal)Urun.urunStok;
                Aciklama.Text = Urun.urunAciklama;
            }
        }


        private void Iptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public URUNLER Urun { get; set; }
        public bool Guncelle { get; set; } = false;
        private void Gonder_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(kategori)) return;
            if (!ErrorControl(textUrun)) return;
            if (!ErrorControl(Fiyat)) return;
            if (!ErrorControl(Aciklama)) return;
            if (!ErrorControl(Stok)) return;

            Urun.kategori = kategori.Text;
            Urun.urunAd = textUrun.Text;
            Urun.urunFiyat = (double)Fiyat.Value;
            Urun.urunStok = (double)Stok.Value;
            Urun.urunAciklama = Aciklama.Text;
            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya yanlış bilgi girdiniz!");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value==0)
                {
                    errorProvider1.SetError(c, "Eksik veya yanlış bilgi girdiniz!");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            if (kategori.SelectedIndex == null)
            {
                errorProvider1.SetError(kategori, "Ödeme durumu seçiniz...");
                kategori.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(kategori, "");
                return true;
            }
            return true;
        }
    }
}
