//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcStok.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLURUNLER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLURUNLER()
        {
            this.TBLSATIS = new HashSet<TBLSATIS>();
        }
    
        public int URUNID { get; set; }
        public string URUNAD { get; set; }
        public Nullable<short> URUNKATEGORI { get; set; }
        public Nullable<decimal> FIYAT { get; set; }
        public Nullable<byte> STOK { get; set; }
        public string MARKA { get; set; }
    
        public virtual TBLKATEGORI TBLKATEGORI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSATIS> TBLSATIS { get; set; }
    }
}
