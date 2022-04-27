using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("Questionnaires")]
    public class Questionnaires
    {
        [Key]
        public long QuestionnaireId { get; set; }
        public long QuestionnaireTemplateId { get; set; }
        public int CreatedByGroupUserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedByGroupUserId { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? BranchId { get; set; }
    }
}
