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

    public partial class PurchaseOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseOrder()
        {
            this.PurchaseOrderItems = new HashSet<PurchaseOrderItem>();
        }

        public int PurchaseOrderID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string dateStr { get { return OrderDate.Date.ToShortDateString(); } }
        public double totalPrice { get; set; }
        public bool isReceived { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
    }
}
