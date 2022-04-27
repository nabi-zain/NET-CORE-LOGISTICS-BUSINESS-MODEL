using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("orgCompany")]
    public class orgCompany
    {
        [Key]
        public int ocoID { get; set; }
        public int ocoCompanyNumber { get; set; }
        public string ocoCompanyName { get; set; }
        public bool ocoActive { get; set; }
        public DateTime ocoTimeDateStamp { get; set; }
    }
}
