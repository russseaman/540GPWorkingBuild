//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _540GPWorkingBuild.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Inventory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inventory()
        {
            this.PurchaseOrderItems = new HashSet<PurchaseOrderItem>();
            this.SaleItems = new HashSet<SaleItem>();
        }
    
        public int ProductID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(0, 9999999999999, ErrorMessage="Net price must be a postive number.")]
        public decimal NetPrice { get; set; }
        [Required]
        [Range(0, 9999999999999, ErrorMessage = "Sale price must be a postive number.")]
        public decimal SalePrice { get; set; }
        [Required]
        [Range(0, 9999999999999, ErrorMessage = "Quantity must be a postive number.")]
        public int Quantity { get; set; }
        [Required]
        public int CategoryID { get; set; }
        public int Active { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleItem> SaleItems { get; set; }
    }
}
