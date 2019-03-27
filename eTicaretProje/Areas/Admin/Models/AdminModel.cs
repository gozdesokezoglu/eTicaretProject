using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eTicaretProje.Areas.Admin.Models
{
    public class AdminModel
    {
        public List<ANAKATEGORİ> AnaKategori { get; set; }
        public List<KATEGORILER> Kategori { get; set; }
        public List<URUNLER> Urunler { get; set; }
        public List<URUNLER> FırsatUrunler { get; set; }
        public List<ALISVERISSEPETI> sepet { get; set; }
        public List<AspNetUsers> Users { get; set; }
        public List<IdentityRole> Kullanıcı { get; set; }
    }
}