using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblVehicleCheck")]
    public class tblVehicleCheck
    {
        [Dapper.Contrib.Extensions.Key]
        public Int64 VehicleCheckID { get; set; }

        [DisplayName("VehicleID")]
        public Int32 VehicleID { get; set; }

        public string VehicleCheck { get; set; }

        [DisplayName("UserID")]
        public Int32 UserID { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd ,ApplyFormatInEditMode=true}")]
        public DateTime DateChecked { get; set; }


    }
}
