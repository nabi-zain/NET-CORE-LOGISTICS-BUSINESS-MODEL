using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using Triton.Model.CRM.Custom;
using Triton.Model.CRM.StoredProcs;
using Triton.Model.TritonOps.StoredProcs;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class BusinessOnlineServices
    {
        /// <summary>
        /// Get the CSA / Customer information to build a dashboard
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="isTritonGroupUserId"></param>
        /// <param name="date"></param>
        /// <returns>List<proc_Waybills_CSA_Dashboard_Select></returns>
        public static async Task<List<proc_Waybills_CSA_Dashboard_Select>> GetCustomerDashboard(int userId, bool isTritonGroupUserId, DateTime date)
        {
            return await RestApiHelper.GetAsync<List<proc_Waybills_CSA_Dashboard_Select>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.BusinessOnline}{userId}/{isTritonGroupUserId}/{date}"));
        }

        /// <summary>
        /// Get all the waybill information by category for CSA or customers
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="type"></param>
        /// <param name="mobile"></param>
        /// <param name="date"></param>
        /// <returns>List<proc_CSA_WaybillList_Select></returns>
        public static async Task<List<proc_CSA_WaybillList_Select>> GetWaybillsByType(string customerId, string type, bool mobile, DateTime? date)
        {
            return await RestApiHelper.GetAsync<List<proc_CSA_WaybillList_Select>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.BusinessOnline}{customerId}/{type}/{date}"));
        }

        /// <summary>
        /// Waybill Status Summary for CSA or customers
        /// </summary>
        /// <param name="customerIds"></param>
        /// <returns><proc_CSA_Customer_Select></returns>
        public static async Task<proc_CSA_Customer_Select> GetDeliveryStatusCount(string customerIds)
        {
            return await RestApiHelper.GetAsync<proc_CSA_Customer_Select>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.BusinessOnline}{customerIds}"));
        }

        /// <summary>
        /// Multi-query to get all the information for CSA/Customer dashboard
        /// </summary>
        /// <param name="customerIds"></param>
        /// <param name="userId"></param>
        /// <param name="isTritonGroupUserId"></param>
        /// <param name="date"></param>
        /// <param name="tableName"></param>
        /// <returns>Returns a multi-query to build the dashboard for the BusinessOnline System of type CSADashboardModel</returns>
        public static async Task<CSADashboardModel> GetDashboardForCustomerMultiQuery(string customerIds, int userId, bool? isTritonGroupUserId, DateTime? date, string tableName)
        {
            return await RestApiHelper.GetAsync<CSADashboardModel>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.BusinessOnline}{customerIds}/{userId}/{isTritonGroupUserId}/{date}/{tableName}"));
        }

        /// <summary>
        /// Gets a waybill list by the customerId's and type such as Bookings etc
        /// </summary>
        /// <param name="customerIds"></param>
        /// <param name="type"></param>
        /// <returns><List<proc_Customer_By_CustomerID_Tabs_Select>></returns>
        public static async Task<List<proc_Customer_By_CustomerID_Tabs_Select>> GetCustomerDeliveriesByStatus(string customerIds, string type)
        {
            _ = HttpUtility.UrlEncode(customerIds.Replace(" ", ""));
            return await RestApiHelper.GetAsync<List<proc_Customer_By_CustomerID_Tabs_Select>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.BusinessOnline}{customerIds}/{type}"));
        }
    }
}
