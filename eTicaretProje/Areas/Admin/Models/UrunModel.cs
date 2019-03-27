using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eTicaretProje.Areas.Admin.Models
{
    public class UrunModel
    {
        public int urunID { get; set; }
        public int kategoriID { get; set; }
        public int markaID { get; set; }
        public string urunAciklama { get; set; }
        public string urunAdi { get; set; }
        public decimal urunFiyat { get; set; }
        public Nullable<decimal> urunAlisFiyati { get; set; }
        public string urunResimYol { get; set; }
        public Nullable<System.DateTime> BaslangicTarihi { get; set; }
        public Nullable<System.DateTime> BitisTarihi { get; set; }
        public HttpPostedFileBase Resim1 { get; set; }
    }
}