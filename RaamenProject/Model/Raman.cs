//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RaamenProject.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Raman
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Raman()
        {
            this.Carts = new HashSet<Cart>();
            this.Details = new HashSet<Detail>();
        }
    
        public int id { get; set; }
        public int Meatid { get; set; }
        public string Name { get; set; }
        public string Borth { get; set; }
        public string Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detail> Details { get; set; }
        public virtual Meat Meat { get; set; }
    }
}
