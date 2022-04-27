using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonVehicles.Tables
{
     [Table("VehicleMileageTracker")]
    public class VehicleMileageTracker
    {
        [Required]
        [Dapper.Contrib.Extensions.Key]
        public int Vehiclemileagetrackerid { get; set; }
        public int VehicleID { get; set; }
         [Required]
        public DateTime Mileagedate { get; set; }
        public decimal? Mileage { get; set; }
        public int? Userid { get; set; }
        public int? Monthno { get; set; }
        public int? Yearno { get; set; }
        public int? Systemid { get; set; }
        public int? Recordid { get; set; }
        public string Comment { get; set; }
        public int? MileageUpdateType { get; set; }
    }
}
