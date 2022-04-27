using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Model.TritonFleetManagement.Custom;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class TFMDashboardService
    {
        public static async Task<DashboardModel> GetAllAsync(string startDate, string endDate)
        {
            return await RestApiHelper.GetAsync<DashboardModel>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.TFMDashboard}Dashboard/{startDate}/{endDate}"));
        }
    }
}
