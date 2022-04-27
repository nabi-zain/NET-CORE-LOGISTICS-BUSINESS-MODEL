using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Service.Model.TritonGroup.Custom;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class WorkflowTasksService
    {
        public static async Task<List<WorkFlowManagerModel>> WorkFlowHistoryAsync(int customerAnalysisId)
        {
            return await RestApiHelper.GetAsync<List<WorkFlowManagerModel>>(new Uri(UrlHelper.Api.WorkFlowApi, $"{UrlHelper.Controller.WorkflowTasks}WorkFlowHistoryAsync?customerAnalysisId={customerAnalysisId}"));
        }
    }
}
