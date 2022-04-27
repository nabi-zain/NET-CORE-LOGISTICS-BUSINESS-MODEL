using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("QuestionnaireQuestions")]
    public class QuestionnaireQuestions
    {
        [Key]
        public int QuestionnaireQuestionId { get; set; }
        public string QuestionText { get; set; }
        public int QuestionCategoryLCId { get; set; }
        public int QuestionFieldTypeLCId { get; set; }
        public bool Required { get; set; }
        public string ErrorText { get; set; }
        public int CreatedByGroupUserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedByGroupUserId { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
