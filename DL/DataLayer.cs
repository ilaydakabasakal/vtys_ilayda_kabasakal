using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veritabaniProje.UI;
using MySql.Data.MySqlClient;
using System.Data;

namespace veritabaniProje.DL
{
    public static class DataLayer
    {
        static MySqlConnection conn = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server = "127.0.0.1",
                Database = "vtysproje",
                UserID = "root",
            }.ConnectionString
        );
        public static int MusteriEkle(MUSTERILER m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut = new MySqlCommand("MusteriEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@musteriID", m.musteriID);
                komut.Parameters.AddWithValue("@musteriAd", m.musteriAd);
                komut.Parameters.AddWithValue("@musteriSoyad", m.musteriSoyad);
                komut.Parameters.AddWithValue("@musteriMail", m.musteriMail);
                komut.Parameters.AddWithValue("@musteriTelNo", m.musteriTelNo);
                int res=komut.ExecuteNonQuery();
                return res;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if( conn.State != System.Data.ConnectionState.Closed ) 
                {
                    conn.Close();
                }
            }
        }

        internal static int MusteriGuncelle(MUSTERILER m)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut = new MySqlCommand("MusteriGuncelle", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_musteriID", m.musteriID);
                komut.Parameters.AddWithValue("@p_musteriAd", m.musteriAd);
                komut.Parameters.AddWithValue("@p_musteriSoyad", m.musteriSoyad);
                komut.Parameters.AddWithValue("@p_musteriMail", m.musteriMail);
                komut.Parameters.AddWithValue("@p_musteriTelNo", m.musteriTelNo);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        internal static DataSet MusteriHepsi(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut;
                if (string .IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("MusteriHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("MusteriHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre ", filtre);

                }
                DataSet dataSet= new DataSet();
                MySqlDataAdapter adp=new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        internal static int UrunSil(string id)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut = new MySqlCommand("UrunSil", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_urunID", id);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        internal static int UrunEkle(URUNLER u)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut = new MySqlCommand("UrunEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@urunID", u.urunID);
                komut.Parameters.AddWithValue("@kategori", u.kategori);
                komut.Parameters.AddWithValue("@urunAd", u.urunAd);
                komut.Parameters.AddWithValue("@urunFiyat", u.urunFiyat);
                komut.Parameters.AddWithValue("@urunStok", u.urunStok);
                komut.Parameters.AddWithValue("@urunAciklama", u.urunAciklama);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }


        internal static int UrunGuncelle(URUNLER u)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut = new MySqlCommand("UrunGuncelle", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_urunID", u.urunID);
                komut.Parameters.AddWithValue("@p_kategori", u.kategori);
                komut.Parameters.AddWithValue("@p_urunAd", u.urunAd);
                komut.Parameters.AddWithValue("@p_urunFiyat", u.urunFiyat);
                komut.Parameters.AddWithValue("@p_urunStok", u.urunStok);
                komut.Parameters.AddWithValue("@p_urunAciklama", u.urunAciklama);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        internal static DataSet UrunHepsi(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("UrunHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("UrunHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre ", filtre);

                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        internal static int SatisEkle(SATISLAR s)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut = new MySqlCommand("SatisEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@satisID", s.satisID);
                komut.Parameters.AddWithValue("@musteriID", s.musteriID);
                komut.Parameters.AddWithValue("@urunID", s.urunID);
                komut.Parameters.AddWithValue("@satisTarih", s.satisTarih);
                komut.Parameters.AddWithValue("@satisAdres", s.satisAdres);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        internal static DataSet SatisHepsi()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut = new MySqlCommand("SatisHepsi", conn);
                komut.CommandType = CommandType.StoredProcedure;

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            //try
            //{
            //    if (conn.State != ConnectionState.Open)
            //    {
            //        conn.Open();
            //    }
            //    MySqlCommand komut = new MySqlCommand("SatisHepsi", conn);
            //    komut.CommandType = CommandType.StoredProcedure;

            //    DataSet dataSet = new DataSet();
            //    MySqlDataAdapter adp = new MySqlDataAdapter(komut);
            //    adp.Fill(dataSet);
            //    return dataSet;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //finally
            //{
            //    if (conn.State != ConnectionState.Closed)
            //    {
            //        conn.Close();
            //    }
            //}
        }

        internal static int SatisGuncelle(SATISLAR s)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut = new MySqlCommand("SatisGuncelle", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_satisID", s.satisID);
                komut.Parameters.AddWithValue("@p_musteriID", s.musteriID);
                komut.Parameters.AddWithValue("@p_urunID", s.urunID);
                komut.Parameters.AddWithValue("@p_satisTarih", s.satisTarih);
                komut.Parameters.AddWithValue("@p_satisAdres", s.satisAdres);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        internal static int SatisSil(string id)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut = new MySqlCommand("SatisSil", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_satisID", id);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        internal static int OdemeEkle(ODEMELER o)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut = new MySqlCommand("OdemeEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@odemeID", o.odemeID);
                komut.Parameters.AddWithValue("@musteriID", o.musteriID);
                komut.Parameters.AddWithValue("@odemeTarih", o.odemeTarih);
                komut.Parameters.AddWithValue("@odemeTutar", o.odemeTutar);
                komut.Parameters.AddWithValue("@odemeDurum", o.odemeDurum);
                komut.Parameters.AddWithValue("@odemeAciklama", o.odemeAciklama);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        internal static DataSet OdemeDetay()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut = new MySqlCommand("OdemeDetay", conn);
                komut.CommandType = CommandType.StoredProcedure;

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        internal static int OdemeGuncelle(ODEMELER o)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut = new MySqlCommand("OdemeGuncelle", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_odemeID", o.odemeID);
                komut.Parameters.AddWithValue("@p_musteriID", o.musteriID);
                komut.Parameters.AddWithValue("@p_odemeTarih", o.odemeTarih);
                komut.Parameters.AddWithValue("@p_odemeTutar", o.odemeTutar);
                komut.Parameters.AddWithValue("@p_odemeDurum", o.odemeDurum);
                komut.Parameters.AddWithValue("@p_odemeAciklama", o.odemeAciklama);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        internal static int OdemeSil(string id)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut = new MySqlCommand("OdemeSil", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_odemeID", id);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        internal static int SiparisEkle(SIPARISLER s)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut = new MySqlCommand("SiparisEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@siparisID", s.siparisID);
                komut.Parameters.AddWithValue("@musteriID", s.musteriID);
                komut.Parameters.AddWithValue("@urunID", s.urunID);
                komut.Parameters.AddWithValue("@siparisAdet", s.siparisAdet);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        internal static DataSet SiparisHepsi()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut = new MySqlCommand("SiparisHepsi", conn);
                komut.CommandType = CommandType.StoredProcedure;

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        internal static int SiparisGuncelle(SIPARISLER s)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut = new MySqlCommand("SiparisGuncelle", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_siparisID", s.siparisID);
                komut.Parameters.AddWithValue("@p_musteriID", s.musteriID);
                komut.Parameters.AddWithValue("@p_urunID", s.urunID);
                komut.Parameters.AddWithValue("@p_siparisAdet", s.siparisAdet);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        internal static int SiparisSil(string id)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut = new MySqlCommand("SiparisSil", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_siparisID", id);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        internal static int MusteriSil(string id)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                MySqlCommand komut = new MySqlCommand("MusteriSil", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@p_musteriID", id);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
    }
}

