using Dapper.Contrib.Extensions;
using System;

namespace Triton.Service.Model.HRM.Tables
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int? SaqaID { get; set; }
        public string SaqaTitle { get; set; }
        public int ? Credit { get; set; }
        public int ? NQFLevel { get; set; }
        public int ? DurationInDays { get; set; }
        public int SkillsLCID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
    }



}
