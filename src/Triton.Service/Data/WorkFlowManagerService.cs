using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.CRM.StoredProcs;
using Triton.Model.CRM.Tables;
using Triton.Model.LeaveManagement.Custom;
using Triton.Service.Model.CRM.StoredProcs;
using Triton.Service.Model.TritonGroup.Custom;
using Triton.Service.Utils;


namespace Triton.Service.Data
{
    public class WorkFlowManagerService
    {
        public static async Task<recExistingPositionsModel> GetByEmployeeCodeAsync(string currentEmployeeCode)
        {
            return await RestApiHelper.GetAsync<recExistingPositionsModel>(new Uri(UrlHelper.Api.RecruitmentApi, $"WorkFlowManagers/GetByEmployeeCode{currentEmployeeCode}"));
        }

        public static async Task<bool> InsertAsync(WorkFlowManager workFlowManager)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"WorkFlowManagers/WorkFlowManagers"), workFlowManager);
        }

        public static async Task<bool> InsertWorkFlowManagerAsync(WorkFlowManager workFlowManager)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.WorkFlowApi, $"{UrlHelper.Controller.WorkFlowManager}WorkFlowManager"), workFlowManager);
        }

        public static async Task<WorkFlowManager> GetByIdAsync(int recorId)
        {
            return await RestApiHelper.GetAsync<WorkFlowManager>(new Uri(UrlHelper.Api.WorkFlowApi, $"{UrlHelper.Controller.WorkFlowManager}GetByIdAsync?customerAnalysisId={recorId}"));
        }

        public static async Task<proc_ProposalSummaryTabs_Select> ProposalSummaryTabsAsync(int customerAnalysisId)
        {
            return await RestApiHelper.GetAsync<proc_ProposalSummaryTabs_Select>(new Uri(UrlHelper.Api.WorkFlowApi, $"{UrlHelper.Controller.WorkFlowManager}ProposalSummaryTabsAsync?customerAnalysisId={customerAnalysisId}"));
        }

        public static async Task<bool> UpdateAsync(List<WorkFlowManager> workFlowManager)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.WorkFlowApi, $"{UrlHelper.Controller.WorkFlowManager}UpdateAsync"), workFlowManager);
        }

        /// <summary>
        /// Insert a new WorkFlowManager for the LeaveManagement System
        /// </summary>
        /// <param name="workFlowManager"></param>
        /// <returns></returns>
        public static async Task<bool> InsertAsyncLeaveManagement(Triton.Model.LeaveManagement.Tables.WorkFlowManager workFlowManager)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"WorkFlowManagers/WorkFlowManagers"), workFlowManager);
        }

        public static async Task<bool> MoveBackToCaptureIncreaseAsync(int userId, int workFlowStageId, int customerAnalysisId)
        {
            return await RestApiHelper.GetAsync<bool>(new Uri(UrlHelper.Api.WorkFlowApi, $"{UrlHelper.Controller.WorkFlowManager}MoveBackToCaptureIncreaseAsync?userId={userId}&workFlowStageId={workFlowStageId}&customerAnalysisId={customerAnalysisId}"));
        }
    }
}
