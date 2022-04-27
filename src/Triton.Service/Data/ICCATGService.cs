using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Service.Model.TFFDAT.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class ICCATGService
    {
        public static async Task<List<ICCATG>> GetAsync()
        {
            return await RestApiHelper.GetAsync<List<ICCATG>>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.ICCATG}GetAsync"));
        }
    }
}
