using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Model.LeaveManagement.Tables
{
     [Table("QuestionnaireTemplateMaps")]
    public class QuestionnaireTemplateMaps
    {
        [Key]
        public int QuestionnaireTemplateMapId { get; set; }
        public int QuestionnaireTemplateId { get; set; }
        public int QuestionnaireQuestionId { get; set; }
        public int CreatedByGroupUserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedByGroupUserId { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
