using Dapper.Contrib.Extensions;
using System;


namespace Triton.Model.LeaveManagement.Tables
{
    [Table("JobProfiles")]
    public class JobProfiles
    {
        [Key]
        public int JobProfileID { get; set; }
        public string Description { get; set; }
        public int? JobCategoryID { get; set; }
        public bool JobProfileActive { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
