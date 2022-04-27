using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class WayBillStatusService
    {
        public static async Task<WayBillStatuss>FindWaybill(long waybillId)
        {
            return await RestApiHelper.GetAsync<WayBillStatuss>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}{waybillId}"));
        }
    }
}
