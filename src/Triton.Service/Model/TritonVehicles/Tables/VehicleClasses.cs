using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonVehicles.Tables
{
    [Table("VehicleClasses")]
  public  class VehicleClasses
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int VehicleClassID { get; set; }
        [Required]
        public string Descripition { get; set; }
        [Required]
        public string ShortDesc { get; set; }
    }
}
