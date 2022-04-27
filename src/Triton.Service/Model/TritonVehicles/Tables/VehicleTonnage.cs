using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonVehicles.Tables
{
    [Table("VehicleTonnage")]
    public  class VehicleTonnage
    {
        [Key]
        public int TonnageID { get; set; }
        public string Tonnage { get; set; }
        public int Status { get; set; }
            [DisplayFormat(DataFormatString = "{0;:yyyy/MM/dd }"  ,ApplyFormatInEditMode=true)]
            public DateTime StatusDate { get; set; }
        public int CapacityKG { get; set; }
    }
}
