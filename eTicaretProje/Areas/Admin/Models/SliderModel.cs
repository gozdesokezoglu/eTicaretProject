using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eTicaretProje.Areas.Admin.Models
{
    public class SliderModel
    {
        public int SliderID { get; set; }
        public byte[] SliderFoto { get; set; }
        public string SliderText { get; set; }
        public string ResimYolu { get; set; }
        public Nullable<System.DateTime> BaslangicTarihi { get; set; }
        public Nullable<System.DateTime> BitisTarihi { get; set; }
        public HttpPostedFileBase Resim { get; set; }
    }
}