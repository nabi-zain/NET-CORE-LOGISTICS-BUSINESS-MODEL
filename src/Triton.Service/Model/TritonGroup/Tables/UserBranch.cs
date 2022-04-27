using Dapper.Contrib.Extensions;
using System;

namespace Triton.Service.Model.TritonGroup.Tables
{
    [Table("UserBranch")]
    public class UserBranch
    {
        [Key]
        public int UserBranchID { get; set; }
        public int BranchID { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ? DeletedOn { get; set; }
        public int? DeletedBy { get; set; }

    }
}
