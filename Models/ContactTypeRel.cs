//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyAdmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContactTypeRel
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public int ContactTypeId { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual Contact Contact { get; set; }
        public virtual ContactType ContactType { get; set; }
        public virtual Login Login { get; set; }
        public virtual Login Login1 { get; set; }
    }
}