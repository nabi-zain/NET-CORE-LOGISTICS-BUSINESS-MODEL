using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Service.Model.TFFDAT.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class ARCUSService
    {
        public static async Task<List<ARCUS>> GetAsync()
        {
            return await RestApiHelper.GetAsync<List<ARCUS>>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.ARCUS}GetAsync"));
        }
    }
}
