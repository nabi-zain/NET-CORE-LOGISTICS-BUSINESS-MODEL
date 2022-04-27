using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("QuestionnaireAnswerMaps")]
    public class QuestionnaireAnswerMaps
    {
        [Key]
        public long QuestionnaireAnswerMapId { get; set; }
        public long QuestionnaireId { get; set; }
        public int QuestionId { get; set; }
        public string Response { get; set; }
        public int CreatedByGroupUserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedByGroupUserId { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
