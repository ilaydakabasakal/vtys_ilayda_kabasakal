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
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            textID.Text = Satis.satisID.ToString();
            if (Guncelle)
            {
                txtMusteri.Text=Satis.musteriID.ToString();
                textUrun.Text=Satis.urunID.ToString();
                Adres.Text=Satis.satisAdres.ToString();
                tarih.Value = Satis.satisTarih;
            }
        }
        public URUNLER Urun { get; set; }
        public MUSTERILER Musteri { get; set; }
        public SATISLAR Satis { get; set; }
        public bool Guncelle { get; set; } = false;

        private void Gonder_Click(object sender, EventArgs e)
        {

            Satis.satisTarih = tarih.Value;
            Satis.urunID = Urun.urunID;
            Satis.musteriID = Musteri.musteriID;
            Satis.satisAdres = Adres.Text; // Ensure this line is added

            DialogResult = DialogResult.OK;
        }

        private void Iptal_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.Cancel;
        }

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            Musteriler frm=new Musteriler();
            if(frm.ShowDialog()== DialogResult.OK)
            {
                Musteri = frm.Musteri;
                txtMusteri.Text = Musteri.ToString();

            }
        }

        private void btnUrunSec_Click(object sender, EventArgs e)
        {
            Urunler frm = new Urunler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Urun = frm.Urun;
                textUrun.Text = Urun.ToString();

            }
        }
    }
}
