using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.LeaveManagement.Tables
{
    [Table("OFOCode")]
    public class OFOCode
    {

        [Key]
        public int OFOCodeID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public bool Active { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }

    }
}
