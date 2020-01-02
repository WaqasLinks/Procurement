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
    
    public partial class BOM
    {
        public Nullable<decimal> ProjectCode { get; set; }
        public decimal RowAuto { get; set; }
        public Nullable<short> BOMTypeCode { get; set; }
        public string SORef { get; set; }
        public string SerialNo { get; set; }
        public string ProductCategory { get; set; }
        public string Product { get; set; }
        public string CostHead { get; set; }
        public string CostSubHead { get; set; }
        public string System { get; set; }
        public string Area { get; set; }
        public string Panel { get; set; }
        public string Category { get; set; }
        public string Manufacturer { get; set; }
        public string PartNo { get; set; }
        public string Description { get; set; }
        public string Qty { get; set; }
        public string UnitCost { get; set; }
        public string ExCost { get; set; }
        public string UnitPrice { get; set; }
        public string ExPrice { get; set; }
    
        public virtual BOMType BOMType { get; set; }
        public virtual Project Project { get; set; }
    }
}
