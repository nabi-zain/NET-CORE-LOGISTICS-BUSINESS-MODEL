using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.CRM.Custom;
using Triton.Model.CRM.StoredProcs;
using Triton.Model.CRM.Tables;
using Triton.Model.CRM.Views;
using Triton.Model.FWWebservice.Custom;
using Triton.Model.TritonStaging.Custom;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class WaybillService
    {
        /// <summary>
        /// Get a single waybill by the WaybillId
        /// </summary>
        /// <param name="waybillId"></param>
        /// <returns>Waybills</returns>
        public static async Task<Waybills>FindWaybill(long waybillId)
        {
            return await RestApiHelper.GetAsync<Waybills>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}{waybillId}"));
        }

        /// <summary>
        /// Return an object of VwopsWaybills by customerId, waybillNo, customerXRef and waybillId
        /// </summary>
        /// <param name="customerIds"></param>
        /// <param name="waybillNo"></param>
        /// <param name="customerXRef"></param>
        /// <param name="waybillId"></param>
        /// <returns>List<vwOpsWaybills></returns>
        public static async Task<List<vwOpsWaybills>>GetWaybillViewList(string customerIds, string waybillNo, string customerXRef, int? waybillId)
        {
            return await RestApiHelper.GetAsync<List<vwOpsWaybills>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}GetWaybillViewList/{customerIds}?waybillNo={waybillNo}&customerXRef={customerXRef}&waybillId={waybillId}"));
        }
        /// <summary>
        /// Returns a list of a waybill information by waybillId
        /// </summary>
        /// <param name="waybillId"></param>
        /// <returns>Waybills</returns>
        public static async Task<Waybills>GetWaybillInfoById(long waybillId)
        {
            return await RestApiHelper.GetAsync<Waybills>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}{waybillId}"));
        }

        /// <summary>
        /// Returns a waybill information by waybillNo
        /// </summary>
        /// <param name="waybillNo"></param>
        /// <param name="dbName"></param>
        /// <returns>Waybills</returns>
        public static async Task<Waybills>GetWaybillByWaybillNo(string waybillNo, string dbName)
        {
            return await RestApiHelper.GetAsync<Waybills>(new Uri(UrlHelper.Api.TritonApiLegacy, $"GetWaybillByWaybillNo?WaybillNo={waybillNo}&DBName={dbName}"));
        }

        /// <summary>
        /// Returns a waybill Sticker as a PDF by waybillNo and test
        /// </summary>
        /// <param name="waybillNo"></param>
        /// <param name="test"></param>
        /// <returns>Waybills</returns>
        public static async Task<Waybills>GetStickersForWaybillasPDF(string waybillNo, bool test)
        {
            return await RestApiHelper.GetAsync<Waybills>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}{waybillNo}/{test}"));
        }

        /// <summary>
        /// returns a POD Sticker by waybillNo and page
        /// </summary>
        /// <param name="waybillNo"></param>
        /// <param name="pages"></param>
        /// <returns>Waybills</returns>
        public static async Task<Waybills>GetPODStickersForWaybillasPDF(string waybillNo, int pages)
        {
            return await RestApiHelper.GetAsync<Waybills>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}{waybillNo}/{pages}"));
        }

        /// <summary>
        /// Returns a PDF of UAT of
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="waybillNo"></param>
        /// <returns>Waybills</returns>
        public static async Task<Waybills>GetEWaybillasPDFUAT(string waybillNo)
        {
            return await RestApiHelper.GetAsync<Waybills>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}{waybillNo}"));
        }

        /// <summary>
        /// Returns a Ewaybill as a PDF by waybillNo
        /// </summary>
        /// <param name="waybillNo"></param>
        /// <returns><Waybills></returns>
        public static async Task<Waybills>GetEWaybillasPDF(string waybillNo)
        {
            return await RestApiHelper.GetAsync<Waybills>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}{waybillNo}"));
        }


        /// <summary>
        /// Returns a FWWS waybill UAT by waybillNo
        /// </summary>
        /// <param name="waybillNo"></param>
        /// <returns><Waybills></Waybills></returns>
        public static async Task<Waybills>GetFWWSWaybillUAT(string waybillNo)
        {
            return await RestApiHelper.GetAsync<Waybills>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}{waybillNo}"));
        }

        
        /// <summary>
        /// Get a waybill from FWWS of 
        /// </summary>
        /// <param name="waybillNo"></param>
        /// <returns><Waybills></returns>
        public static async Task<Waybills>GetFWWSWaybill(string waybillNo)
        {
            return await RestApiHelper.GetAsync<Waybills>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}{waybillNo}"));
        }


        public static async Task<bool>PutWaybillDeliveredPODUAT(Waybills model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}"), model);
        }

        public static async Task<bool>PutWaybillDeliveredPODLive(Waybills model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}"), model);
        }


        public static async Task<TritonWaybillSubmitModels> GetTritonSubmitModelByWaybillID(long waybillId, string dbName)
        {
            return await RestApiHelper.GetAsync<TritonWaybillSubmitModels>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}{waybillId}/{dbName}"));
        }

        public static async Task<TritonWaybillSubmitModels> GetTritonSubmitModelByWaybillNo(string waybillNo, string dbName)
        {
            return await RestApiHelper.GetAsync<TritonWaybillSubmitModels>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}{waybillNo}/{dbName}"));
        }


        public static async Task<vwOpsWaybills> GetWaybillsByWaybillNo(string waybillNo)
        {
            return await RestApiHelper.GetAsync<vwOpsWaybills>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}{waybillNo}"));
        }

        //[Obsolete("This method is internal to the repository and should not be used.", true)]
        //Task<bool> IWaybill.StoreWaybillLines(dynamic waybill, long waybillID, string dbName)
        //{
        //    throw new NotImplementedException();
        //}


        //async Task<byte[]> IWaybillAPI.GetWaybillPODImage(string waybillNo, string nodeName)
        //{
        //   return await _connection.GetAsync<byte[]>(StringHelpers.Controllers.Edocs, $"/WaybillPOD/{waybillNo}{ (!String.IsNullOrEmpty(nodeName)?$"?nodename={nodeName}":"" ) }");
        //}

        //async Task<proc_FMOEndorsements_Signature_Select> IWaybillAPI.GetWaybillSignature(string waybillNo)
        //{
        //    return await _connection.GetAsync<proc_FMOEndorsements_Signature_Select>(StringHelpers.Controllers.Waybills, $"/Image/Signature/{waybillNo}");
        //}

        //#region Internal Waybills
        /// <summary>
        /// Returns a internal waybill by interalwaybillid and database name
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="internalWaybillID"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public static async Task<InternalWaybills> GetInternalWaybill(long internalWaybillID, string dbName)
        {
            return await RestApiHelper.GetAsync<InternalWaybills>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}{internalWaybillID}/{dbName}"));
        }


        /// <summary>
        /// Returns a internal waybill by waybillno
        /// </summary>
        /// <param name="waybillNo"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public static async Task<InternalWaybills> GetInternalWaybillByReference(string waybillNo, string dbName)
        {
            return await RestApiHelper.GetAsync<InternalWaybills>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}{waybillNo}/{dbName}"));
        }

        //[Obsolete("This method is internal to the repository and should not be used.", true)]
        //Task<long> IWaybill.PostInternalWaybill(InternalWaybills internalWaybill, string dbName)
        //{
        //    throw new NotImplementedException();
        //}
        //[Obsolete("This method is internal to the repository and should not be used.", true)]
        //Task<bool> IWaybill.PutInternalWaybill(InternalWaybills internalWaybill, string dbName)
        //{
        //    throw new NotImplementedException();
        //}

        //async Task<FWResponsePacket> IWaybillAPI.PostInternalWaybill(TritonWaybillSubmitModels model, string dbName)
        //{
        //   return await _connection.PostAsyncDynamic<dynamic,FWResponsePacket>(StringHelpers.Controllers.Waybills, $"InternalWaybill{ (!String.IsNullOrEmpty(dbName)?$"?dbName={dbName}":"" ) }",model);
        //}

        ////async Task<FWResponsePacket> IWaybillAPI.PutInternalWaybill(InternalWaybills waybill, string dbName)
        ////{
        ////   return await _connection.PostAsyncDynamic(StringHelpers.Controllers.Waybills, $"/InternalWaybill/{ (!String.IsNullOrEmpty(dbName)?$"?dbName={dbName}":"" ) }",waybill);
        ////}

        //async Task<FWResponsePacket> IWaybillAPI.PostInternalWaybillUAT(TritonWaybillSubmitModels model, string dbName)
        //{
        //   return await _connection.PostAsyncDynamic<dynamic,FWResponsePacket>(StringHelpers.Controllers.Waybills, $"UAT/InternalWaybill",model);
        //}

        //async Task<FWResponsePacket> IWaybillAPI.PutInternalWaybillUAT(InternalWaybills waybill, string dbName)
        //{
        //    return await _connection.PostAsyncDynamic(StringHelpers.Controllers.Waybills, $"UAT/InternalWaybill/{ (!String.IsNullOrEmpty(dbName)?$"?dbName={dbName}":"" ) }",waybill);
        //}{ (!String.IsNullOrEmpty(dbName)?$"?dbName={dbName}":"" ) }

        //#endregion

        //[Obsolete("This method is internal to the repository and should not be used.", true)]
        //public Task<long> PostWaybillFromFWWS(WaybillCustomerModel Waybill, string dbName = "CRM")
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// Returns a credit note page
        /// </summary>
        /// <param name="waybillNo"></param>
        /// <returns></returns>
        public static async Task<CreditNotePageModel> GetCreditNotePage(string waybillNo)
        {
            return await RestApiHelper.GetAsync<CreditNotePageModel>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}{waybillNo}"));
        }

        //public static async Task<List<TarsusTrackEventModel>> GetTarsusByWaybillNo(string WaybillNo)
        //{
        //    return await RestApiHelper.GetAsync<List<TarsusTrackEventModel>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybills}GetWaybillViewList/{customerIds}?waybillNo={waybillNo}&customerXRef={customerXRef}&waybillId={waybillId}"));
        //}

        public static async Task<FWResponsePacket> GetWaybillAsync(string waybillNo)
        {
            return await RestApiHelper.GetAsync<FWResponsePacket>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Waybill}Waybill?waybillNo={waybillNo}"));
        }
    }
}
