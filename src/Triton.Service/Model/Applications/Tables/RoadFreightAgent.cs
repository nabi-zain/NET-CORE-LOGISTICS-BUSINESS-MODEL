using Dapper.Contrib.Extensions;
using System;

namespace Triton.Service.Model.Applications.Tables
{
    [Table("RoadFreightAgent")]
    public class RoadFreightAgent
    {
        [Key]
        public int RoadFreightAgentID { get; set; }
        public string SupplierDate { get; set; }
        public string WaybillNo { get; set; }
        public decimal? Volumetric { get; set; }
        public decimal? Mass { get; set; }
        public decimal? Surcharge { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Total { get; set; }
        public string Invoice { get; set; }
        public int CategoryLCID { get; set; }
        public int SupplierID { get; set; }
        public int StatusLCID { get; set; }
        public int ? WaybillID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public int? DeletedOn { get; set; }
     
    }
}
