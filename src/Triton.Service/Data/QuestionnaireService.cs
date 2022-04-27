using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.LeaveManagement.Custom;
using Triton.Model.TritonGroup.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class QuestionnaireService
    {

        /// <summary>
        /// Returns <see cref="QuestionnaireModel"/>
        /// </summary>
        /// <param name="questionId"></param>
        /// <param name="response"></param>
        /// <param name="CreatedDate"></param>
        /// <returns><see cref="QuestionnaireModel"/></returns>
        public static async Task<QuestionnaireModel> FindByQuestionResponse(int questionId, string response, DateTime CreatedDate)
        {
            return await RestApiHelper.GetAsync<QuestionnaireModel>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Questionnaire}{questionId}/{response}/{CreatedDate}"));
        }


        /// <summary>
        /// Returns <see cref="List<QuestionnaireSearchModel>"/>
        /// </summary>
        /// <param name="identity"></param>
        /// <param name="forDate"></param>
        /// <param name="questionId"></param>
        /// <returns>List<QuestionnaireSearchModel></returns>
        public static async Task<List<QuestionnaireSearchModel>> FindQuestionaireList(string identity, DateTime? forDate, int questionId = 13)
        {
            return await RestApiHelper.GetAsync<List<QuestionnaireSearchModel>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Questionnaire}{identity}/{forDate}/{questionId}"));
        }

        /// <summary>
        /// returns questionnaire by
        /// </summary>
        /// <param name="employeeCode"></param>
        /// <param name="createdDate"></param>
        /// <returns>QuestionnaireModel</returns>
        public static async Task<QuestionnaireModel> FindTritonCovidQuestionaireModel(string employeeCode, DateTime createdDate)
        {
            return await RestApiHelper.GetAsync<QuestionnaireModel>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Questionnaire}{employeeCode}/{createdDate}"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeCode"></param>
        /// <param name="createdDate"></param>
        /// <returns></returns>
        public static async Task<int>GetExcessTempCountforTritonCovid(string employeeCode, DateTime createdDate)
        {
            return await RestApiHelper.GetAsync<int>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Questionnaire}{employeeCode}/{createdDate:yyyy-MM-dd}"));
        }

        /// <summary>
        /// Returns a <see cref="QuestionnaireModel"/>
        /// </summary>
        /// <param name="questionnaireTemplateId"></param>
        public static async Task<QuestionnaireModel> GetQuestionaireCreateModel(int questionnaireTemplateId)
        {
            return await RestApiHelper.GetAsync<QuestionnaireModel>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Questionnaire}{questionnaireTemplateId}"));
        }

        /// <summary>
        /// Returns a questionnaire model of type QuestionnaireModel
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="questionnaireId"></param>
        /// <returns>QuestionnaireModel</returns>
        public static async Task<QuestionnaireModel> GetQuestionaireModel(long questionnaireId)
        {
            return await RestApiHelper.GetAsync<QuestionnaireModel>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Questionnaire}{questionnaireId}"));
        }

        /// <summary>
        /// Returns questionnaires by 
        /// </summary>
        /// <param name="branchId"></param>
        /// <param name="forDate"></param>
        /// <returns></returns>
        public static async Task<DocumentRepositories> GetQuestionaireReport(int branchId, DateTime forDate)
        {
            return await RestApiHelper.GetAsync<DocumentRepositories>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Questionnaire}{branchId}/{ forDate:yyyy-MM-dd}"));
        }

        /// <summary>
        /// Insert a new 
        /// </summary>
        /// <param name="model"></param>
        /// <returns>long</returns>
        public static async Task<long>Post(QuestionnairePostModel model)
        {
            return await RestApiHelper.PostAsyncLong(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Questionnaire}"), model);
        }

        [Obsolete("This method is internal to the repo and should not be used.")]
        public static Task SendCovidEmails(long questionnairID)
        {
            throw new NotImplementedException();
        }
    }
}
