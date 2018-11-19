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

     public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Sales = new HashSet<Sale>();
        }
    
        public int EmployeeID { get; set; }
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Display(Name ="Hire Date")]
        public System.DateTime HireDate { get; set; }
        public int RoleID { get; set; }
        [Display(Name ="Phone Number")]
        public string PhoneNum { get; set; }
        public int AddressID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Active { get; set; }
    
        public virtual Address Address { get; set; }
        [Display(Name ="Employee Role")]
        public virtual EmployeeRole EmployeeRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
