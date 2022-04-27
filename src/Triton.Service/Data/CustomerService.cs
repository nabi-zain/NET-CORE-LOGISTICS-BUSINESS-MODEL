using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.CRM.StoredProcs;
using Triton.Model.CRM.Tables;
using Triton.Model.TritonGroup.Custom;
using Triton.Service.Model.CRM.Custom;
using Triton.Service.Model.CRM.StoredProcs;
using Triton.Service.Model.TritonGroup.Custom;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class CustomerService
    {

        /// <summary>
        /// Returns a List<Customers> from the CRM.dbo.Customers table
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Customers>> GetAllActiveCustomers()
        {
            return await RestApiHelper.GetAsync<List<Customers>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Customer}"));
        }

        /// <summary>
        /// Returns CRM Customer by customerId
        /// </summary>
        /// <param name="id"></param>
        /// <returns><Customers></returns>
        public static async Task<Customers> GetCrmCustomerById(int id)
        {
            return await RestApiHelper.GetAsync<Customers>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Customer}{id}"));
        }

        /// <summary>
        /// Gets a specific Customers by the Search
        /// </summary>
        /// <param name="search"></param>
        /// <returns><List<Customers>></returns>
        public static async Task<List<Customers>> FindCrmCustomer(string search)
        {
            return await RestApiHelper.GetAsync<List<Customers>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Customer}{search}"));
        }

        public static async Task<bool> PutCustomer(Customers customer)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Customer}"), customer);
        }

        /// <summary>
        /// Returns Customers by userId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns><UserMapCustomerModel></returns>
        public static async Task<UserMapCustomerModels> GetUserMap_With_Customers(int userId)
        {
            return await RestApiHelper.GetAsync<UserMapCustomerModels>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Customer}{userId}"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="userId"></param>
        /// <param name="routeName"></param>
        /// <returns></returns>
        public static async Task<UserMapCustomerModels> GetCustomerInfo(int userId, string routeName)
        {
            return await RestApiHelper.GetAsync<UserMapCustomerModels>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Customer}{userId}/{routeName}"));
        }

        /// <summary>
        /// returns back Customers by
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public static async Task<List<Customers>> GetAllCustomersSearch(string search)
        {
            return await RestApiHelper.GetAsync<List<Customers>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Customer}{search}"));
        }


        /// <summary>
        /// Create a new user 
        /// </summary>
        /// <returns><UserMap></returns>
        public static Task<Triton.Model.TritonGroup.Tables.UserMap> UserMapInset(Triton.Model.TritonGroup.Tables.UserMap userMap)
        {
            throw new NotImplementedException("This method requires implementation in the Triton.CustomerService");
            //return await RestApiHelper.GetAsync<UserMap>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.TritonGroupStoredProcs}Post_proc_UserMap_Insert"));
        }

        /// <summary>
        /// Returns Customers by userId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns><List<Customers>></returns>
        public static async Task<List<Customers>> GetCrmCustomersByRepUserId(int userId)
        {
            return await RestApiHelper.GetAsync<List<Customers>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Customer}{userId}"));
        }

        /// <summary>
        /// Returns a List<Customers> from the CRM.dbo.Customers table
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns><List<Customers>></returns>
        public static async Task<List<Customers>> GetCrmInternalAccounts<T>()
        {
            return await RestApiHelper.GetAsync<List<Customers>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Customer}"));
        }

        /// <summary>
        /// Returns Customer Assessment by customerId, periodFrom, periodTo, branch, rep
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="periodFrom"></param>
        /// <param name="periodTo"></param>
        /// <param name="branch"></param>
        /// <param name="rep"></param>
        /// <returns><CustomerAssessment></returns>
        public static async Task<CustomerAssessment> GetCustomerAssessment(int customerId, string periodFrom, string periodTo, int? branch = null, int? rep = null)
        {
            var path = $"/GetCustomerAssessment/{customerId}?periodFrom={periodFrom}&periodTo={periodTo}&branch={branch}&rep={rep}";
            return await RestApiHelper.GetAsync<CustomerAssessment>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Customer}{path}"));
        }

        /// <summary>
        /// Find a list of customers by supplying a string of multiple customerId's
        /// </summary>
        /// <param name="customerIds"></param>
        /// <returns>A List of Customers</returns>
        public static async Task<List<Customers>> FindCrmCustomerByIds(string customerIds)
        {
            return await RestApiHelper.GetAsync<List<Customers>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Customer}{customerIds}"));
        }

        /// <summary>
        /// Returns Customers by account code and dbname
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="accountCode"></param>
        /// <param name="dbName"></param>
        /// <returns><customers></returns>
        public static async Task<Customers> GetCRMCustomerByAccountCode(string accountCode, string dbName = "CRM")
        {
            if (dbName is null)
            {
                throw new ArgumentNullException(nameof(dbName));
            }

            return await RestApiHelper.GetAsync<Customers>(new Uri(UrlHelper.Api.CustomerApi, $"{UrlHelper.Controller.Customer}GetCustomerByAccountCode/{accountCode}"));
        }

        public static async Task<Customers> GetCrmIDCustomerByAccountCode(string accountCode)
        {
            return await RestApiHelper.GetAsync<Customers>(new Uri(UrlHelper.Api.CustomerApi, $"{UrlHelper.Controller.Customer}GetCustomerIDByAccountCode/{accountCode}"));
        }

        public static async Task<Customers> GetCustomerAccountCodeByCustomerId(int CustomerID)
        {
            return await RestApiHelper.GetAsync<Customers>(new Uri(UrlHelper.Api.CustomerApi, $"{UrlHelper.Controller.Customer}GetCustomerAccountCodeByCustomerId/{CustomerID}"));
        }

        public static async Task<List<proc_Customers_Select>> GetCustomerDetails(string accountCode)
        {
            return await RestApiHelper.GetAsync<List<proc_Customers_Select>>(new Uri(UrlHelper.Api.CustomerApi, $"{UrlHelper.Controller.Customer}GetCustomerDetails/{accountCode}"));
        }

        public static async Task<List<proc_Customers_Select>> GetRepsCustomers(int UserID)
        {
            return await RestApiHelper.GetAsync<List<proc_Customers_Select>>(new Uri(UrlHelper.Api.CustomerApi, $"{UrlHelper.Controller.Customer}GetRepsCustomers/{UserID}"));
        }

        public static async Task<List<proc_RepsActiveCustomersPerCycle_Select>> GetRepsActiveCustomersPerRateCycle(int RateCycleID)
        {
            return await RestApiHelper.GetAsync<List<proc_RepsActiveCustomersPerCycle_Select>>(new Uri(UrlHelper.Api.CustomerApi, $"{UrlHelper.Controller.Customer}GetRepsActiveCustomersPerRateCycle/{RateCycleID}"));
        }

        public static async Task<CustomersIncreaseMatrixSelectModel> GetCustomersIncreaseMatrixSelectAsync(string dataBaseName, int userId, int workFlowId, int? filterbranchID, int? filteruserID )
        {
            return await RestApiHelper.GetAsync<CustomersIncreaseMatrixSelectModel>(new Uri(UrlHelper.Api.WorkFlowApi, $"{UrlHelper.Controller.Customers}GetCustomersIncreaseMatrixSelectAsync?dataBaseName={dataBaseName}&userID={userId}&workFlowId={workFlowId}&filterBranchID={filterbranchID}&filterUserID={filteruserID}"));
        }

        public static async Task<CustomersModel> GetCustomerByCustomerIdAsync(int customerId)
        {
            return await RestApiHelper.GetAsync<CustomersModel>(new Uri(UrlHelper.Api.CustomerApi, $"{UrlHelper.Controller.Customer}GetCustomerByCustomerIdAsync/{customerId}"));
        }

        public static async Task<bool> UpdateAsync(Customers customers)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.CustomerApi, $"{UrlHelper.Controller.Customer}UpdateAsync"), customers);
        }

        public static async Task<proc_CustomerSummary> CustomerSummaryAsync(int userId, int workFlowStageId)
        {
            return await RestApiHelper.GetAsync<proc_CustomerSummary>(new Uri(UrlHelper.Api.WorkFlowApi, $"{UrlHelper.Controller.Customers}CustomerSummaryAsync?userId={userId}&workFlowStageId={workFlowStageId}"));
        }

        public static async Task<Customers> GetByAccountCodeAsync(string accountCode)
        {
            return await RestApiHelper.GetAsync<Customers>(new Uri(UrlHelper.Api.CustomerApi, $"{UrlHelper.Controller.Customer}GetByAccountCodeAsync?accountCode={accountCode}"));
        }

        public static async Task<BillingModel> GetCustomersBilling(int customerID)
        {
            return await RestApiHelper.GetAsync<BillingModel>(new Uri(UrlHelper.Api.CrmApi, $"{UrlHelper.Controller.Customer}GetCustomerBill?customerID={customerID}"));
        }

        public static async Task<List<proc_Waybills_ByMonthSelect>> GetCustomerBillWaybillSales(int customerID, string currentDate)
        {
            return await RestApiHelper.GetAsync<List<proc_Waybills_ByMonthSelect>>(new Uri(UrlHelper.Api.CrmApi, $"{UrlHelper.Controller.Customer}CustomerBillWaybillSales?customerID={customerID}&currentDate={currentDate}"));
        }

        public static async Task<List<proc_Customer_UpDownTrader>> GetCustomerUpDownTrader(int customerID, string currentDate)
        {
            return await RestApiHelper.GetAsync<List<proc_Customer_UpDownTrader>>(new Uri(UrlHelper.Api.CrmApi, $"{UrlHelper.Controller.Customer}GetCustomerUpDownTrader?customerID={customerID}&currentDate={currentDate}"));
        }
    }
}
