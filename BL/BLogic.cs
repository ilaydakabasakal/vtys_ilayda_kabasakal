using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using veritabaniProje.DL;
using veritabaniProje.UI;

namespace veritabaniProje.BL
{
    public static class BLogic
    {
        public static bool MusteriEkle(MUSTERILER m)
        {
            try
            { 
                int res = DataLayer.MusteriEkle(m);      
                return (res>0);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool MusteriGuncelle(MUSTERILER m)
        {
            try
            {
                int res = DataLayer.MusteriGuncelle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static DataSet MusteriHepsi(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.MusteriHepsi(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);
                return null;
            }
        }

        internal static bool MusteriSil(string id)
        {
            try
            {
                int res = DataLayer.MusteriSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static DataSet OdemeDetay()
        {
            try
            {
                DataSet ds = DataLayer.OdemeDetay();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return null;
            }
        }

        internal static bool OdemeEkle(ODEMELER o)
        {
            try
            {
                int res = DataLayer.OdemeEkle(o);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool OdemeGuncelle(ODEMELER o)
        {
            try
            {
                int res = DataLayer.OdemeGuncelle(o);
                return res > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

      

        internal static bool OdemeSil(string id)
        {
            try
            {
                int res = DataLayer.OdemeSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool SatisEkle(SATISLAR s)
        {

            try
            {
                int res = DataLayer.SatisEkle(s);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool SatisGuncelle(SATISLAR s)
        {
            try
            {
                int res = DataLayer.SatisGuncelle(s);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static DataSet SatisHepsi()
        {
            try
            {
                DataSet ds = DataLayer.SatisHepsi();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return null;
            }
        }

        internal static bool SatisSil(string id)
        {

            try
            {
                int res = DataLayer.SatisSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool SiparisEkle(SIPARISLER s)
        {
            try
            {
                int res = DataLayer.SiparisEkle(s);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool SiparisGuncelle(SIPARISLER s)
        {
            try
            {
                int res = DataLayer.SiparisGuncelle(s);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static DataSet SiparisHepsi()
        {
            try
            {
                DataSet ds = DataLayer.SiparisHepsi();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return null;
            }
        }

        internal static bool SiparisSil(string id)
        {
            try
            {
                int res = DataLayer.SiparisSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool UrunEkle(URUNLER u)
        {
            try
            {
                int res = DataLayer.UrunEkle(u);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool UrunGuncelle(URUNLER u)
        {
            try
            {
                int res = DataLayer.UrunGuncelle(u);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static DataSet UrunHepsi(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.UrunHepsi(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);
                return null;
            }
        }

        internal static bool UrunSil(string id)
        {
            try
            {
                int res = DataLayer.UrunSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);
                return false;
            }
        }
    }
}
