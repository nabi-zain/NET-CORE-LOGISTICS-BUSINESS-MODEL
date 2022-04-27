using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Service.Model.TFFDAT.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class OESHDTService
    {
        public static async Task<List<OESHDT>> GetAsync()
        {
            return await RestApiHelper.GetAsync<List<OESHDT>>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.OESHDT}GetAsync"));
        }
    }
}
