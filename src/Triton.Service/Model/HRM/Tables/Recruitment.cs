using Dapper.Contrib.Extensions;
using System;

namespace Triton.Service.Model.HRM.Tables
{
    [Table("Recruitment")]
    public class Recruitment
    {
        [Key]
        public int RecruitmentID { get; set; }
        public int JobProfileID { get; set; }
        public int DepartmentID { get; set; }
        public int BranchID { get; set; }
        public int StatusLCID { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime ? EffectivedDate { get; set; }
        public string SupportingReason { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime ? DeletedOn { get; set; }
        public int ? DeletedByUserID { get; set; }
    }
}
