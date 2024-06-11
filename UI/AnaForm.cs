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
using veritabaniProje.UI;

namespace veritabaniProje
{
    public partial class AnaForm : Form
    {

        public AnaForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            
        }

        Musteriler mf = new Musteriler();
        Urunler uf = new Urunler();
        Satislar st = new Satislar();
        Odemeler od = new Odemeler();
        Siparisler sp = new Siparisler();
        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            mf.ShowDialog();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            uf.ShowDialog();

        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            st.ShowDialog();
        }

      
        private void btnOdeme_Click(object sender, EventArgs e)
        {
            od.ShowDialog();
        }

        private void btnSepet_Click(object sender, EventArgs e)
        {
            sp.ShowDialog();
        }
    }
}