using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Model.TritonOps.Tables
{
    [Table("EmployeeGifts")]
    public class EmployeeGifts
    {
        [Key]
        public int EmployeeGiftsID { get; set; }
        public string EmployeeCode { get; set; }
        public string Item { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
