using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonOps.Tables
{
    [Table("CheckLists")]
    public class CheckList
    {
        [Dapper.Contrib.Extensions.Key]
        public int CheckListID { get; set; }

        public int ItemID { get; set; }
        public bool? Status { get; set; }
        public int EmployeeID { get; set; }
        public int RouteID { get; set; }
        public int BagID { get; set; }
        public int CheckListDetailID { get; set; }
        public int VehicleID { get; set; }
        public int CreatedbyUserID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? DeletedOn { get; set; }
        public string Quantity { get; set; }
        public int? CheckListDocID { get; set; }
        public bool? VehicleCheck { get; set; }
        public string Comment { get; set; }


    }
}
