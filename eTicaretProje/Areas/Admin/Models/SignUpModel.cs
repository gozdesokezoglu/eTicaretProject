using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eTicaretProje.Areas.Admin.Models
{
    public class SignUpModel
    {
        public int AdminID { get; set; }
        public string AdminAd { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string Sehir { get; set; }
        public string KullaniciAdi { get; set; }
        public string Password { get; set; }
        public string TekrarPassword { get; set; }
    }
}