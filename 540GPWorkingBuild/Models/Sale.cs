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

     public partial class Sale
     {
          [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
          public Sale()
          {
               this.SaleItems = new HashSet<SaleItem>();
          }

          [Display(Name = "Transaction ID")]
          public int SaleID { get; set; }
          public Nullable<int> CustomerID { get; set; }
          public int EmployeeID { get; set; }
          [Display(Name = "Sale Date")]
          public System.DateTime SaleDate { get; set; }
          public string saleDateString { get { return SaleDate.Date.ToShortDateString(); } }
          

          public virtual Customer Customer { get; set; }
          public virtual Employee Employee { get; set; }
          [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
          [Display(Name = "Sale Items")]
          public virtual ICollection<SaleItem> SaleItems { get; set; }
     }
}
