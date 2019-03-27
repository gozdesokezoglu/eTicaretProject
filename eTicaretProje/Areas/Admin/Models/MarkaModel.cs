using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eTicaretProje.Areas.Admin.Models
{
    public class MarkaModel
    {
        public int markaID { get; set; }
        public string markaAdi { get; set; }
        public string MarkaResimYol { get; set; }

        public HttpPostedFileBase Resim { get; set; }
    }
}