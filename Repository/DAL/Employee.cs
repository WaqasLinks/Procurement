//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string HOD { get; set; }
        public Nullable<short> EmployeeTypeCode { get; set; }
        public Nullable<decimal> ProjectCode { get; set; }
    
        public virtual EmployeeType EmployeeType { get; set; }
        public virtual Project Project { get; set; }
    }
}