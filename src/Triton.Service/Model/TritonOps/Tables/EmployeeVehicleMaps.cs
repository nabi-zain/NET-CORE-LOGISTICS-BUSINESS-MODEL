using System;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonOps.Tables
{
    [Table("EmployeeVehicleMaps")]
    public class EmployeeVehicleMaps
    {
        [Key]
        public int EmployeeVehicleMapsID { get; set; }
        public int? EmployeeID { get; set; }
        public int? VehicleID { get; set; }
        public int? RouteID { get; set; }
        public bool? Spare { get; set; }
        public int? LookUpCodeID { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedByUserID { get; set; }
    }
}
