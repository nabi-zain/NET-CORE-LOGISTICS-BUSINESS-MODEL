using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.CRM.Custom;
using Triton.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class WaybillQueryMasterService
    {
        public static async Task<WaybillQueryMaster> Get(int waybillQueryMasterId)
        {
            return await RestApiHelper.GetAsync<WaybillQueryMaster>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.WaybillQueryMaster}/{waybillQueryMasterId}"));
        }

        public static async Task<List<WaybillQueryMaster_Waybills_Model>> GetWaybillQueryMaster(int userId, string queryStatusLcid, int? systemId)
        {
            return await RestApiHelper.GetAsync<List<WaybillQueryMaster_Waybills_Model>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.WaybillQueryMaster}/{userId}/{queryStatusLcid}?systemId={systemId}"));
        }

        public static async Task<List<WaybillQuery>> GetWaybillQueryList(long waybillId)
        {
            return await RestApiHelper.GetAsync<List<WaybillQuery>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}/{UrlHelper.Controller.WaybillQuery}/{waybillId}"));
        }

        public static async Task<bool> PutWaybillQueryMaster(WaybillQueryMaster waybillQueryMaster)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}/{UrlHelper.Controller.WaybillQueryMaster}"), waybillQueryMaster);
        }

        public static async Task<bool> PostWaybillQueryMaster(WaybillQueryMasterInsertModel model)
        {
            return await RestApiHelper.PostAsyncBool(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}/{UrlHelper.Controller.WaybillQueryMaster}"), model);
        }

        public static async Task<bool> Delete(long waybillId, int userId)
        {
            return await RestApiHelper.DeleteAsync(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}/{UrlHelper.Controller.WaybillQueryMaster}/{waybillId}/{userId}"));
        }
    }
}
