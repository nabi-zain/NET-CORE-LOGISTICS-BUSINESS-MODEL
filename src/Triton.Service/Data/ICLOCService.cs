using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Service.Model.TFFDAT.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class ICLOCService
    {
        /// <summary>
        /// Get locations
        /// </summary>
        /// <returns></returns>
        public static async Task<List<ICLOC>> GetAsync()
        {
            return await RestApiHelper.GetAsync<List<ICLOC>>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.ICLOC}GetAsync"));
        }
    }
}
