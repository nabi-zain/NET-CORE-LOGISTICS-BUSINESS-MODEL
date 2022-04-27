using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Triton.Model.TritonVehicles.Tables
{
    [Table("VehicleExpenseTypes")]
    public  class VehicleExpenseTypes
    {
        [Key]
        public int VehicleExpenseTypeID { get; set; }
        public string VehicleExpenseType { get; set; }
        public int Status { get; set; }

        [DisplayFormat(DataFormatString = "{0;:yyyy/MM/dd }"  ,ApplyFormatInEditMode=true)]
        public DateTime StatusDate { get; set; }

        [DisplayName("Vehicle Expense Type Order By")]
        public int VehicleExpeseTypeOrderBy { get; set; }
    }
}
