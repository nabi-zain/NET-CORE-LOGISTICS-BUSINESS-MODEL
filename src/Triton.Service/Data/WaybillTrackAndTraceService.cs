using System;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class WaybillTrackAndTraceService
    {

        /// <summary>
        /// Returns Track and Trace information by reference
        /// </summary>
        /// <param name="reference"></param>
        /// <returns><WaybillTrackandTraces></returns>
        public static async Task<WaybillTrackandTraces> GetCustomerWaybillTrackandTraceby_Reference(string reference)
        {
            return await RestApiHelper.GetAsync<WaybillTrackandTraces>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.WaybillTandT}{reference}"));
        }

        
        /// <summary>
        /// Returns Track and Trace information by waybillId
        /// </summary>
        /// <param name="waybillId"></param>
        /// <returns><WaybillTrackAndTrace></returns>
        public static async Task<WaybillTrackandTraces>GetCustomerWaybillTrackandTraceby_WaybillID(long waybillId)
        {
            return await RestApiHelper.GetAsync<WaybillTrackandTraces>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.WaybillTandT}{waybillId}"));
        }


        /// <summary>
        /// Returns Track and Trace information by waybillNo
        /// </summary>
        /// <param name="waybillNo"></param>
        /// <returns><WaybillTrackAndTrace></returns>
        public static async Task<WaybillTrackandTraces>GetCustomerWaybillTrackandTraceby_WaybillNo(string waybillNo)
        {
            return await RestApiHelper.GetAsync<WaybillTrackandTraces>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.WaybillTandT}{waybillNo}"));
        }


        /// <summary>
        /// Returns Track and Trace information by waybillId
        /// </summary>
        /// <param name="waybillId"></param>
        /// <returns><WaybillTrackAndTrace></returns>
        public static async Task<WaybillTrackandTraces>GetWaybillTrackandTraceby_WaybillID(long waybillId)
        {
            return await RestApiHelper.GetAsync<WaybillTrackandTraces>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.WaybillTandT}{waybillId}"));
        }
    }
}
