using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eTicaretProje.Areas.Admin.Models
{
    public class KategoriModel
    {
        public int kategoriID { get; set; }
        public string kategoriAdi { get; set; }
        public int anaKategoriID { get; set; }
    }
}