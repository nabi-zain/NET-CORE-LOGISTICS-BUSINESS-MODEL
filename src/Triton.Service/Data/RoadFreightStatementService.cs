using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Model.Applications.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class RoadFreightStatementService
    {
        public static async Task<List<RoadFreightStatement>> GetAllStatements()
        {
            return await RestApiHelper.GetAsync<List<RoadFreightStatement>>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightStatement}GetAllStatements"));
        }

        public static async Task<RoadFreightStatement> GetStatementByID(int RoadFreightStatementID)
        {
            return await RestApiHelper.GetAsync<RoadFreightStatement>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightStatement}GetStatementByID/{RoadFreightStatementID}"));
        }

        public static async Task<bool> InsertAsync(RoadFreightStatement model)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightStatement}InsertAsync/Insert"), model);
        }

        public static async Task<bool> UpdateAsync(RoadFreightStatement model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightStatement}UpdateAsync/Update"), model);
        }

        public static async Task<bool> DeleteAsync(RoadFreightStatement model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightStatement}DeleteAsync/Update"), model);
        }

        public static async Task<RoadFreightStatement> CheckForDuplicate(string SupplierCode, int Year, int Month)
        {
            return await RestApiHelper.GetAsync<RoadFreightStatement>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.RoadFreightStatement}CheckForDuplicates/{SupplierCode}/{Year}/{Month}"));
        }
    }
}
