using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eTicaretProje.Models
{
    public class Homemodel
    {
      

        public List<KATEGORILER> Kategori { get; set; }
        public List<ANAKATEGORİ> AnaKategori { get; set; }
        public List<URUNLER> OneCikanUrunler { get; set; }
        public List<URUNLER> YeniUrunler { get; set; }
        public List<URUNLER> Urunler { get; set; }
        public List<URUNLER> FirsatUrunler { get; set; }
        public List<URUNLER> urunOzellikler { get; set; }
        public List<URUNLER> kategoriUrunler { get; set; }
        public List<MARKALAR> Marka { get; set; }
        public List<URUNOZELLIKLER> Ozellikler { get; set; }
        public List<OZELLIKDETAY> OzellikDetay { get; set; }
        public List<ALISVERISSEPETI> Sepet { get; set; }
       
    }
}