using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Service.Model.Applications.Custom;
using Triton.Service.Model.Applications.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class RoadFreightAgentHistoryService
    {
        public static async Task<bool> InsertAsync(RoadFreightAgentHistory roadFreightAgentHistory)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgentHistory}InsertAsync"), roadFreightAgentHistory);
        }


        public static async Task<List<RoadFreightAgentHistoryModel>> GetByIdAsync(int roadFreightAgentHistoryId)
        {
            return await RestApiHelper.GetAsync<List<RoadFreightAgentHistoryModel>>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgentHistory}GetByIdAsync?roadFreightAgentHistoryId={roadFreightAgentHistoryId}"));
        }

        public static async Task<bool> InsertRoadFreightAgentHistoryAsync(List<RoadFreightAgentHistory> roadFreightAgentHistories)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgentHistory}InsertRoadFreightAgentHistoryAsync"), roadFreightAgentHistories);
        }

    }
}
