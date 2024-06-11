using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabaniProje
{
    public class MUSTERILER
    {
        public Guid musteriID { get; set; }
        public string musteriAd { get; set; }
        public string musteriSoyad { get; set; }
        public string musteriMail { get; set; }
        public string musteriTelNo { get; set; }
        public override string ToString()
        {
            return $"{musteriAd} {musteriSoyad}";
        }
    }
    
    public class URUNLER
    {
        public Guid urunID { get; set; }
        public string urunAd { get; set; }
        public string kategori { get; set; }
        public string urunAciklama { get; set; }
        public double urunFiyat { get; set; }
        public double urunStok { get; set; }
        public override string ToString()
        {
            return $"{urunAd}";
        }
    }
    public class SATISLAR
    {
        public Guid satisID { get; set; }
        public Guid musteriID { get; set; }
        public Guid urunID { get; set; }
        public DateTime satisTarih { get; set; }
        public string satisAdres { get; set; }
        public override string ToString()
        {
            return $"{satisID}";
        } //burada aslında müsteri ve ürün adını almak istiyorum 
    }
    public class SIPARISLER
    {
        public Guid siparisID { get; set; }
        public Guid musteriID { get; set; }
        public Guid urunID { get; set; }
        public double siparisAdet { get; set; }
       
    }
    public class ODEMELER
    {
        public Guid odemeID { get; set; }
        public Guid musteriID { get; set; }
        public DateTime odemeTarih { get; set; }
        public double odemeTutar { get; set; }
        public string odemeDurum { get; set; }
        public string odemeAciklama { get; set; }
    }
        
        
}
