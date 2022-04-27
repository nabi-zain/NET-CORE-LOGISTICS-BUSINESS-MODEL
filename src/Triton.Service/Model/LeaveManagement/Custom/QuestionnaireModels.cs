using System;
using System.Collections.Generic;
using Triton.Model.TritonGroup.Tables;
using Triton.Model.LeaveManagement.Tables;

namespace Triton.Model.LeaveManagement.Custom
{
    public class QuestionnaireModel
    {
        public Questionnaires   Questionnaire { get; set; }
        public QuestionnaireTemplates Template { get; set; }
        public List<QuestionAnswerModel> QuestionsandAnswers { get; set; }
        public Employees Employee { get; set; }
    }

    public class QuestionAnswerModel
    {
        public QuestionnaireQuestions Question{ get; set; }
        public QuestionnaireAnswerMaps Answer { get; set; }
        public LookUpCodes QuestionCategoryCode { get; set; }
        public LookUpCodes QuestionFieldType { get; set; }
    }

    public class QuestionnaireSearchModel 
    {
        public int QuestionnaireId { get; set; }
        public string QuestionnaireDescription { get; set; }
        public DateTime CreatedOn { get; set; }
        public string IdentityResponse { get; set; }

    }

    public class QuestionnairePostModel
    {
        public int QuestionnaireTemplateId { get; set; }
        public int CreatedByGroupUserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? BranchId { get; set; }
        public List<QuestionnaireAnswerMaps> Answers { get; set; }
    }

}
