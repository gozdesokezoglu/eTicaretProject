//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eTicaretProje
{
    using System;
    using System.Collections.Generic;
    
    public partial class SIPARISLER
    {
        public int siparisID { get; set; }
        public int urunID { get; set; }
        public string siparisDurum { get; set; }
        public int odemeSecekenleriID { get; set; }
        public System.DateTime siparisTarihi { get; set; }
        public int kargoID { get; set; }
        public string kargoNo { get; set; }
        public System.DateTime TeslimTarihi { get; set; }
    
        public virtual KARGO KARGO { get; set; }
        public virtual ODEMESECENEKLER ODEMESECENEKLER { get; set; }
        public virtual URUNLER URUNLER { get; set; }
    }
}