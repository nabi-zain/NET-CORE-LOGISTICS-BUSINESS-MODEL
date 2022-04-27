using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Model.CRM.Custom;
using Triton.Service.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class CustomerReportService
    {
        public static async Task<bool> InsertCustomerReportAsync(CustomerReportModel model)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.CrmApi, $"{UrlHelper.Controller.CustomerReport}InsertCustomerReportAsync/Insert"), model);
        }

        public static async Task<List<CustomerReport>> GetAllCustomerReportTimes(int customerID)
        {
            return await RestApiHelper.GetAsync<List<CustomerReport>>(new Uri(UrlHelper.Api.CrmApi, $"{UrlHelper.Controller.CustomerReport}GetAllCustomerReportTimes?customerID={customerID}"));
        }
    }
}
