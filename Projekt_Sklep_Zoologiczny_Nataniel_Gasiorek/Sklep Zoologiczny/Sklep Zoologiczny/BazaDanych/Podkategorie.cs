//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sklep_Zoologiczny.BazaDanych
{
    using System;
    using System.Collections.Generic;
    
    public partial class Podkategorie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Podkategorie()
        {
            this.Produkty = new HashSet<Produkty>();
        }
    
        public int ID_Podkategorii { get; set; }
        public string Nazwa_podkategorii { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produkty> Produkty { get; set; }
    }
}
