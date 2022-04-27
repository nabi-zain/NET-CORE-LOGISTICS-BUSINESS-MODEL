using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Model.CRM.Custom;
using Triton.Service.Model.CRM.StoredProcs;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class CustomerMeetingService
    {
        public static async Task<List<CustomerMeetingsViewModel>> GetCustomerMeetingMinutesByCustomerID(int CustomerID)
        {
            return await RestApiHelper.GetAsync<List<CustomerMeetingsViewModel>>(new Uri(UrlHelper.Api.CrmApi, $"{UrlHelper.Controller.Customer}GetCustomerMeetingMinutesByCustomerID/{CustomerID}"));
        }

        public static async Task<bool> InsertMeetingAsync(proc_AddCustomerMeeting model)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.CrmApi, $"{UrlHelper.Controller.Customer}InsertMeetingAsync/Insert"), model);
        }
    }
}
