//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace stajprojesi.Models.EntitiyFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class ogrenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ogrenci()
        {
            this.stajBilgisi = new HashSet<stajBilgisi>();
        }
    
        public int ogr_no { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public Nullable<bool> ogretim { get; set; }
        public Nullable<bool> durum { get; set; }
        public Nullable<int> gun { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stajBilgisi> stajBilgisi { get; set; }
    }
}
