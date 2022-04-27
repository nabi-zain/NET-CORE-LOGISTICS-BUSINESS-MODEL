using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Service.Model.Applications.Custom;
using Triton.Service.Model.Applications.StoredProcs;
using Triton.Service.Model.Applications.Tables;
using Triton.Service.Model.TritonGroup;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class RoadFreightAgentService
    {
        public static async Task<ErrorMessage> UploadRoadFreightAgentAsync(string fileName, int userId, string fileDescription)
        {
            return await RestApiHelper.GetAsync<ErrorMessage>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgent}UploadRoadFreightAgentAsync?fileName={fileName}&userId={userId}&fileDescription={fileDescription}"));
        }

        public static async Task<PurchaseOrder_Overview> PurcharseOrderOverviewAsync(int lookupcodeId, DateTime startDate, DateTime endDate, int userId)
        {
            return await RestApiHelper.GetAsync<PurchaseOrder_Overview>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgent}PurcharseOrderOverviewAsync?lookupcodeId={lookupcodeId}&startDate={startDate}&endDate={endDate}&userId={userId}"));
        }


        public static async Task<RoadFreightAgent> GetByIdAsync(int roadFreightAgentId)
        {
            return await RestApiHelper.GetAsync<RoadFreightAgent>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgent}GetByIdAsync?roadFreightAgentId={roadFreightAgentId}"));
        }

        public static async Task<bool> UpdateAsync(RoadFreightAgent roadFreightAgent)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgent}UpdateAsync"), roadFreightAgent);
        }

        public static async Task<bool> InsertAsync(RoadFreightAgent roadFreightAgent)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgent}UpdateAsync"), roadFreightAgent);
        }

        public static async Task<List<RoadFreightAgentModel>> GetRoadFreightAgentBySubCodeDate(DateTime startDate, DateTime endDate, int reasonLCID, string subCode)
        {
            return await RestApiHelper.GetAsync<List<RoadFreightAgentModel>>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgent}RoadFreightAgentByDateSubCode?startDate={startDate}&endDate={endDate}&reasonLCID={reasonLCID}&subCode={subCode}"));
        }

        public static async Task<int> RoadFreightAgent_BL_UpdateAsync(string wayBillNo, DateTime? fromDate, DateTime? toDate, int? statusLCId)
        {
            return await RestApiHelper.GetAsync<int>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgent}RoadFreightAgent_BL_UpdateAsync?wayBillNo={wayBillNo}&fromDate={fromDate}&toDate={toDate}&statusLCId={statusLCId}"));
        }

        public static async Task<List<string>> GetAllWayBillNumbersAsync(DateTime fromDate, DateTime toDate, int statusLCId)
        {
            return await RestApiHelper.GetAsync<List<string>>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgent}GetAllWayBillNumbersAsync?fromDate={fromDate}&toDate={toDate}&statusLCId={statusLCId}"));
        }

        public static async Task<List<RoadFreightAgentComplexModel>> GetRoadFreightAgentComplexAsync(DateTime fromDate, DateTime toDate, int userId, int? statusLCID)
        {
            return await RestApiHelper.GetAsync<List<RoadFreightAgentComplexModel>>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgent}GetRoadFreightAgentComplexAsync?&fromDate={fromDate}&toDate={toDate}&userId={userId}&statusLCId={statusLCID}"));
        }

        public static async Task<PurchaseOrder_Overview> SupplierOverviewAsync(int lookupcodeId, DateTime startDate, DateTime endDate, int userId, int supplierId)
        {
            return await RestApiHelper.GetAsync<PurchaseOrder_Overview>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgent}SupplierOverviewAsync?lookupcodeId={lookupcodeId}&startDate={startDate}&endDate={endDate}&userId={userId}&supplierId={supplierId}"));
        }

        public static async Task<bool> MoveToPaidAsync(List<RoadFreightAgent> roadFreightAgents)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgent}MoveToPaidAsync"), roadFreightAgents);
        }

        public static async Task<proc_RoadFreightAgent_GetByID> proc_RoadFreightAgent_GetByIDAsync(int roadFreightAgentId)
        {
            return await RestApiHelper.GetAsync<proc_RoadFreightAgent_GetByID>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgent}proc_RoadFreightAgent_GetByIDAsync?roadFreightAgentId={roadFreightAgentId}"));
        }

        public static async Task<bool> DeleteRoadFreightAgentAsync(DateTime startDate, DateTime endDate, int userId)
        {
            return await RestApiHelper.GetAsync<bool>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgent}DeleteRoadFreightAgentAsync?startDate={startDate}&endDate={endDate}&userId={userId}"));
        }

        public static async Task<PurchaseOrder_Overview> AdminsAndBranchManagerOverviewAsync(int lookupcodeId, DateTime startDate, DateTime endDate, int userId)
        {
            return await RestApiHelper.GetAsync<PurchaseOrder_Overview>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgent}AdminsAndBranchManagerOverviewAsync?lookupcodeId={lookupcodeId}&startDate={startDate}&endDate={endDate}&userId={userId}"));
        }

        public static async Task<PurchaseOrder_Overview> SupplierBranchManagerOverviewAsync(int lookupcodeId, DateTime startDate, DateTime endDate, int userId, int supplierId)
        {
            return await RestApiHelper.GetAsync<PurchaseOrder_Overview>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgent}SupplierBranchManagerOverviewAsync?lookupcodeId={lookupcodeId}&startDate={startDate}&endDate={endDate}&userId={userId}&supplierId={supplierId}"));
        }

        public static async Task<List<RoadFreightAgentCategory>> GetCategoryList(DateTime startDate, DateTime endDate, int supplierId)
        {
            return await RestApiHelper.GetAsync<List<RoadFreightAgentCategory>>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgent}GetCategoryList?&startDate={startDate}&endDate={endDate}&supplierId={supplierId}"));
        }
        
        public static async Task<List<proc_GetWayBillList_Select>> GetSupplierInfoAsync(DateTime startDate, DateTime endDate, int userId)
        {
            return await RestApiHelper.GetAsync<List<proc_GetWayBillList_Select>>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgent}GetSupplierInfoAsync?startDate={startDate}&endDate={endDate}&userId={userId}"));
        }

        public static async Task<List<proc_Supplier_Category_Select>> SupplierSummaryAsync(DateTime startDate, DateTime endDate, int supplierId)
        {
            return await RestApiHelper.GetAsync<List<proc_Supplier_Category_Select>>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgent}SupplierSummaryAsync?startDate={startDate}&endDate={endDate}&supplierId={supplierId}"));
        }

        public static async Task<List<RoadFreightAgentModel>> GetWaybillListAsync(DateTime startDate, DateTime endDate, int supplierId, int lookUpCodeId)
        {
            return await RestApiHelper.GetAsync<List<RoadFreightAgentModel>>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightAgent}GetWaybillListAsync?startDate={startDate}&endDate={endDate}&supplierId={supplierId}&lookUpCodeId={lookUpCodeId}"));
        }


    }
}
