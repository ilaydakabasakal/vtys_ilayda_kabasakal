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



    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }
        public MUSTERILER Musteri { get; set; }
        public bool Guncelle { get; set; } = false;

        private void Iptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Gonder_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(textAd)) return;
            if (!ErrorControl(textSoyad)) return;
            if (!ErrorControl(textMail)) return;
            if (!ErrorControl(textTelefon)) return;
            Musteri.musteriAd = textAd.Text;
            Musteri.musteriSoyad = textSoyad.Text;
            Musteri.musteriMail = textMail.Text;
            Musteri.musteriTelNo = textTelefon.Text;


            DialogResult = DialogResult.OK;
        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
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
            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
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
            return true;
        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            textID.Text=Musteri.musteriID.ToString();
            if (Guncelle)
            {
                textAd.Text = Musteri.musteriAd;
                textSoyad.Text = Musteri.musteriSoyad;
                textMail.Text = Musteri.musteriMail;
                textTelefon.Text = Musteri.musteriTelNo;
            }
           
        }
    }
}