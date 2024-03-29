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
    
    public partial class ScholarRequestSchoolInfo
    {
        public int Id { get; set; }
        public int ScholarRequestId { get; set; }
        public int SchoolTypeId { get; set; }
        public string University { get; set; }
        public string UniversityFaculty { get; set; }
        public string UniversityFacultyDepartment { get; set; }
        public string HighSchool { get; set; }
        public string HighSchoolDivision { get; set; }
        public Nullable<int> ClassDegree { get; set; }
        public int SchoolCountryId { get; set; }
        public int SchoolCityId { get; set; }
        public int SchoolDistrictId { get; set; }
        public int IsActive { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
    
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual District District { get; set; }
        public virtual Login Login { get; set; }
        public virtual Login Login1 { get; set; }
        public virtual ScholarRequest ScholarRequest { get; set; }
        public virtual SchoolType SchoolType { get; set; }
    }
}
