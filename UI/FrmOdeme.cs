using System;
using System.Windows.Forms;

namespace veritabaniProje.UI
{
    public partial class FrmOdeme : Form
    {
        public FrmOdeme()
        {
            InitializeComponent();
        }

        public ODEMELER Odeme { get; set; }
        public MUSTERILER Musteri { get; set; }
        public bool Guncelle { get; set; } = false;

        private void Iptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Gonder_Click(object sender, EventArgs e)
        {
            if (Tutar.Value == 0)
            {
                errorProvider1.SetError(Tutar, "Lütfen fiyat giriniz...");
                Tutar.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(Tutar, "");
            }

            if (Durum.SelectedIndex == -1)
            {
                errorProvider1.SetError(Durum, "Ödeme durumu seçiniz...");
                Durum.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(Durum, "");
            }

            Odeme.musteriID = Musteri.musteriID;
            Odeme.odemeDurum = Durum.SelectedItem.ToString();
            Odeme.odemeTarih = tarih.Value;
            Odeme.odemeTutar = (double)Tutar.Value;
            Odeme.odemeAciklama = Aciklama.Text;

            DialogResult = DialogResult.OK;
        }
         
        private void FrmOdeme_Load(object sender, EventArgs e)
        {
            if (Odeme == null)
            {
                MessageBox.Show("Odeme nesnesi null. Lütfen gerekli verileri doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textID.Text = Odeme.odemeID.ToString();
            if (Guncelle)
            {
                txtMusteri.Text = Odeme.musteriID.ToString();
                Tutar.Value = (decimal)Odeme.odemeTutar;
                tarih.Value = Odeme.odemeTarih;
                Durum.SelectedItem = Odeme.odemeDurum;
                Aciklama.Text = Odeme.odemeAciklama;
            }
        }

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Musteri = frm.Musteri;
                txtMusteri.Text = Musteri.ToString();

            }
        }

    }
}
