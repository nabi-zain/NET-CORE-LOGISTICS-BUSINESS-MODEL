using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Model.LeaveManagement.Tables
{
     [Table("QuestionnaireTemplates")]
    public class QuestionnaireTemplates
    {
        [Key]
        public int QuestionnaireTemplateId { get; set; }
        public string Questionnaire { get; set; }
        public string QuestionnaireDescription { get; set; }
        public int CreatedByGroupUserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedByGroupUserId { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
