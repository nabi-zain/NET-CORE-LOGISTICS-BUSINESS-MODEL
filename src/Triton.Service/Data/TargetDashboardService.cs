using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Model.CRM.Custom;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class TargetDashboardService
    {
        public static async Task<TargetsDashboardModel> GetDashboard(int UserID)
        {
            return await RestApiHelper.GetAsync<TargetsDashboardModel>(new Uri(UrlHelper.Api.CrmApi, $"{UrlHelper.Controller.Dashboard}GetDashboard?UserID={UserID}"));
        }
    }
}
