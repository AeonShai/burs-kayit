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
    
    public partial class ScholarReceive
    {
        public int Id { get; set; }
        public int ScholarContactId { get; set; }
        public int YearId { get; set; }
        public int SeasonId { get; set; }
        public int MonthId { get; set; }
        public int ReceivedAmount { get; set; }
        public System.DateTime ReceivedAmountDate { get; set; }
        public int ScholarBankAccountId { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
    
        public virtual Contact Contact { get; set; }
        public virtual Login Login { get; set; }
        public virtual Login Login1 { get; set; }
        public virtual Month Month { get; set; }
        public virtual ScholarBankAccount ScholarBankAccount { get; set; }
        public virtual ScholarReceive ScholarReceives1 { get; set; }
        public virtual ScholarReceive ScholarReceive1 { get; set; }
        public virtual Season Season { get; set; }
        public virtual Year Year { get; set; }
    }
}
