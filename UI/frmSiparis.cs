using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace veritabaniProje.UI
{
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }
        public URUNLER Urun { get; set; }
        public MUSTERILER Musteri { get; set; }
        public SIPARISLER Siparis { get; set; }
        public bool Guncelle { get; set; } = false;



        private void Gonder_Click(object sender, EventArgs e)
        {
            if (Musteri != null && Urun != null)
            {
                Siparis.musteriID = Musteri.musteriID;
                Siparis.urunID = Urun.urunID;
                Siparis.siparisAdet = (float)adet.Value; // Sipariş adedini float olarak ayarla
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Lütfen müşteri ve ürünü seçin.");
            }
        }

        private void Iptal_Click(object sender, EventArgs e)
        {
            Siparis.siparisAdet = (double)adet.Value;
            DialogResult = DialogResult.Cancel;
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

        private void btnUrunSec_Click(object sender, EventArgs e)
        {
            Urunler frm = new Urunler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Urun = frm.Urun;
                textUrun.Text = Urun.ToString();
            }
        }

        private void frmSiparis_Load(object sender, EventArgs e)
        {
            textID.Text = Siparis.siparisID.ToString();
            if (Guncelle)
            {
                textUrun.Text = Siparis.urunID.ToString();
                txtMusteri.Text = Siparis.musteriID.ToString();
                adet.Value = (decimal)Siparis.siparisAdet;
            }
        }

    }
}
