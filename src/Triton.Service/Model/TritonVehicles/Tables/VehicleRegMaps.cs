using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonVehicles.Tables
{
    [Table("VehicleRegMaps")]
    public class VehicleRegMaps
    {
        [Required]
        [Dapper.Contrib.Extensions.Key]
        public int VehicleRegMapID { get; set; }

        [Required]
        public int VehicleID { get; set; }

        [Required]
        public string Registration { get; set; }

        public bool? Status { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }
    }
}
