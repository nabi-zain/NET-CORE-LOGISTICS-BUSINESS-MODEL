using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonOps.Tables
{
    public class CCLEmployeeVehicleMap
    {
        [Dapper.Contrib.Extensions.Key]
        [Required]
        public int CCLEmployeeVehicleMapID { get; set; }

        [DisplayName("Driver")]
        public int EmployeeID { get; set; }

        [DisplayName("Horse Reg")]
        public int VehicleID { get; set; }

        [DisplayName("Trailer 1")]
        public int? Trailer1VehicleID { get; set; }

        [DisplayName("Trailer 2")]
        public int? Trailer2VehicleID { get; set; }

        public int? TrailerTypeLookUpCodeID { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidTo { get; set; }

        public int? LookUpCodeID { get; set; }

        [DisplayName("Created On")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("Created By")]
        public int CreatedByUserID { get; set; }
    }
}