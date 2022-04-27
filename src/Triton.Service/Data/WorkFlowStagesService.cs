using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.CRM.StoredProcs;
using Triton.Service.Model.CRM.StoredProcs;
using Triton.Service.Model.CRM.Tables;
using Triton.Service.Model.TritonGroup.Custom;
using Triton.Service.Utils;


namespace Triton.Service.Data
{
    public class WorkFlowStagesService
    {
        public static async Task<List<WorkFlowStages>> GetWorkFlowStages(int workFlowId, string databaseName)
        {
            return await RestApiHelper.GetAsync<List<WorkFlowStages>>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.WorkFlowStages}WorkFlowStagesForNewIncreases/{workFlowId}/{databaseName}"));
        }

        public static async Task<List<proc_Increase_Matrix_Select>> GetIncreaseMatrixListAsync(int? branchId)
        {
            return await RestApiHelper.GetAsync<List<proc_Increase_Matrix_Select>>(new Uri(UrlHelper.Api.WorkFlowApi, $"{UrlHelper.Controller.WorkFlowStages}GetIncreaseMatrixListAsync/{branchId}"));
        }
        
        public static async Task<CustomerSummaryModel> GetWorkFlowStagesListByUserIDAsync(int userId, string dataBaseName, int workFlowId, int? filterBranchId = null, int? filterUserId = null)
        {
            return await RestApiHelper.GetAsync<CustomerSummaryModel>(new Uri(UrlHelper.Api.WorkFlowApi, $"{UrlHelper.Controller.WorkFlowStages}GetWorkFlowStagesListByUserIDAsync?userID={userId}&dataBaseName={dataBaseName}&workFlowID={workFlowId}&filterBranchID={filterBranchId}&filterUserID={filterUserId}"));
        }

        public static async Task<List<WorkFlowStagesModel>> GetWorkFlowStagesListAsync(int workFlowStageId, string dataBaseName)
        {
            return await RestApiHelper.GetAsync<List<WorkFlowStagesModel>>(new Uri(UrlHelper.Api.WorkFlowApi, $"{UrlHelper.Controller.WorkFlowStages}GetWorkFlowTaskListAsync?workFlowStageID={workFlowStageId}&dataBaseName={dataBaseName}"));
        }

        public static async Task<proc_Proposal_Information_Select> ProsalInformationAsync(int customerAnalysisId)
        {
            return await RestApiHelper.GetAsync<proc_Proposal_Information_Select>(new Uri(UrlHelper.Api.WorkFlowApi, $"{UrlHelper.Controller.WorkFlowStages}ProsalInformationAsync?customerAnalysisId={customerAnalysisId}"));
        }

        public static async Task<proc_CustomersIncreaseSummary> GetCustomerAnalysisAsync(int userId)
        {
            return await RestApiHelper.GetAsync<proc_CustomersIncreaseSummary>(new Uri(UrlHelper.Api.WorkFlowApi, $"{UrlHelper.Controller.WorkFlowStages}GetCustomerAnalysisAsync?userID={userId}"));
        }

        public static async Task<proc_WorkFlowStagesSummary> WorkFlowSummaryAsync(int userID, int workFlowStageID)
        {
            return await RestApiHelper.GetAsync<proc_WorkFlowStagesSummary>(new Uri(UrlHelper.Api.WorkFlowApi, $"{UrlHelper.Controller.WorkFlowStages}WorkFlowSummaryAsync?userId={userID}&workFlowStageId={workFlowStageID}"));
        }
    }
}

