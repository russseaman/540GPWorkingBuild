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

     public partial class SaleItem
     {
          public int SaleItemID { get; set; }
          public int ProductID { get; set; }
          public int Quantity { get; set; }
          public int Returned { get; set; }
          public int SaleID { get; set; }

          public double TotalSIPrice { get; set; }
          public int TotalSI { get; set; }

          //public double totalSalePrice { get { return (double)Quantity * (double)Inventory.SalePrice; } }

          public virtual Inventory Inventory { get; set; }
          public virtual Sale Sale { get; set; }
     }
}
