using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonVehicles.Tables
{
    [Table("VehicleConfigs")]
    public class VehicleConfigs
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int VehicleCongfigID { get; set; }
        public string VehicleConfig { get; set; }
        public int StatusID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime StatusDate { get; set; }

    }
}
