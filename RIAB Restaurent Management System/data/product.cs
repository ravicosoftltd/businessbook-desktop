//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RIAB_Restaurent_Management_System.data
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            this.subproduct = new HashSet<subproduct>();
            this.salepurchaseproduct = new HashSet<salepurchaseproduct>();
            this.subproduct1 = new HashSet<subproduct>();
        }
    
        public int id { get; set; }
        public string barcode { get; set; }
        public string category { get; set; }
        public Nullable<double> carrycost { get; set; }
        public Nullable<double> discount { get; set; }
        public string name { get; set; }
        public Nullable<double> purchaseprice { get; set; }
        public Nullable<bool> purchaseactive { get; set; }
        public Nullable<double> quantity { get; set; }
        public Nullable<double> saleprice { get; set; }
        public Nullable<bool> saleactive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<subproduct> subproduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<salepurchaseproduct> salepurchaseproduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<subproduct> subproduct1 { get; set; }
    }
}
