using System;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("UserAudit")]
    public class UserAudit
    {
        [Key]
        public long UserAuditID { get; set; }

        public string PageName { get; set; }

        public int SystemID { get; set; }

        public DateTime CreatedOn { get; set; }

        public int CreatedByUserID { get; set; }
    }
}
