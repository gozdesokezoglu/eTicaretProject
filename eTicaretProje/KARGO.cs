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
    
    public partial class KARGO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KARGO()
        {
            this.SIPARISLER = new HashSet<SIPARISLER>();
        }
    
        public int kargoID { get; set; }
        public string kargoFirmaAdi { get; set; }
        public string kargoFirmaAciklama { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SIPARISLER> SIPARISLER { get; set; }
    }
}
