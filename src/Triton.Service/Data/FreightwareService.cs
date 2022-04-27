//using Microsoft.Extensions.Configuration;
//using System.Collections.Generic;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Triton.Core;
//using Triton.Interface.Freightware;
//using Triton.Model.CRM.Custom;
//using Triton.Model.FWWebservice.Custom;
//using Vendor.Services.Freightware.PROD.GetCustRateAreaList;
//using Vendor.Services.Freightware.PROD.GetPcodeList;
//using Vendor.Services.Freightware.PROD.GetSiteList;
//using Vendor.Services.Freightware.PROD.SetAccountRate;
//using Vendor.Services.Freightware.PROD.SetCustRateArea;
//using Vendor.Services.Freightware.PROD.SetWaybill;

//namespace Triton.Service.Freightware
//{
//    public class FreightwareService:IFreightware
//    {
//         private static Connection _connection;

//        public FreightwareService(IConfiguration configuration, IHttpClientFactory factory)
//        {
//            _connection = new Connection(configuration, factory);
//        }

//          async Task<FWResponsePacket> IFreightware.GetSiteList(string customerCode, string siteCode)
//        {
//            return await _connection.GetAsync<FWResponsePacket>(StringHelpers.Controllers.Freightware, $"/CustomerSites/Customer/{customerCode}/SiteCode/{siteCode}");
//        }

//        async Task<FWResponsePacket> IFreightware.GetSiteListUAT(string customerCode, string siteCode)
//        {
//            return await _connection.GetAsync<FWResponsePacket>(StringHelpers.Controllers.FreightwareUAT, $"/CustomerSites/Customer/{customerCode}/SiteCode/{siteCode}");
//        }

//          async Task<List<GetPcodeListResponsePcodeOutput>> IFreightware.GetPostalList(string SearchPhrase)
//        {
//            return await _connection.GetAsync<List<GetPcodeListResponsePcodeOutput>>(StringHelpers.Controllers.Freightware, "GetPostalCodeList", $"SearchPhrase={SearchPhrase}");
//        }

//           async Task<List<Vendor.Services.Freightware.UAT.GetCustRateAreaList.GetCustRateAreaListResponseCustRateAreaOutput>> IFreightware.GetFWCustomerRateAreasUAT(string Code)
//        {
//            return await _connection.GetAsync<List<Vendor.Services.Freightware.UAT.GetCustRateAreaList.GetCustRateAreaListResponseCustRateAreaOutput>>(StringHelpers.Controllers.Freightware, "GetFWCustomerRateAreasUAT", $"Code={Code}");
//        }

//           async Task<List<GetCustRateAreaListResponseCustRateAreaOutput>> IFreightware.GetFWCustomerRateAreas(string Code)
//        {
//            return await _connection.GetAsync<List<GetCustRateAreaListResponseCustRateAreaOutput>>(StringHelpers.Controllers.Freightware, "GetFWCustomerRateAreas", $"Code={Code}");
//        }

//          async Task<List<GetPcodeListResponsePcodeOutput>> IFreightware.GetPostalListByCode(string Code)
//        {
//            return await _connection.GetAsync<List<GetPcodeListResponsePcodeOutput>>(StringHelpers.Controllers.Freightware, "GetPostalCodeListByCode", $"Code={Code}");
//        }

//          async Task<List<CustomerPostalCodes>> IFreightware.GetPostalListForCustomer(string SearchPhrase)
//        {
//            return await _connection.GetAsync<List<CustomerPostalCodes>>(StringHelpers.Controllers.Freightware, "GetPostalCodeListForCustomer", $"SearchPhrase={SearchPhrase}");
//        }

//           async Task<List<CustomerPostalCodes>> IFreightware.GetPostalListByCodeForCustomer(string Code)
//        {
//            return await _connection.GetAsync<List<CustomerPostalCodes>>(StringHelpers.Controllers.Freightware, "GetPostalCodeListByCodeForCustomer", $"Code={Code}");
//        }

//          async Task<FWResponsePacket> IFreightware.GetAccountRatesUAT(string accountCode, bool? active)
//        {
//            return await _connection.GetAsync<FWResponsePacket>(StringHelpers.Controllers.Freightware, "GetListofAccountRatesUAT", $"accountCode={accountCode}&active={active}");
//        }

//          async Task<FWResponsePacket> IFreightware.PostWaybillUAT(CustomerWaybillSubmitModels model)
//        {
//            return await _connection.PostAsyncDynamic<dynamic,FWResponsePacket>(StringHelpers.Controllers.Freightware, "PostWaybillUAT", model);
//        }

//          async Task<FWResponsePacket> IFreightware.PostWaybillLIVE(CustomerWaybillSubmitModels model)
//        {
//            return await _connection.PostAsyncDynamic<dynamic,FWResponsePacket>(StringHelpers.Controllers.Freightware, "PostWaybillLIVE", model);
//        }

//          async Task<FWResponsePacket> IFreightware.SetFWCustomerRateUAT(Vendor.Services.Freightware.UAT.SetAccountRate.SetAccountRateInRate model)
//        {
//            return await _connection.PostAsyncDynamic<dynamic,FWResponsePacket>(StringHelpers.Controllers.Freightware, "PostFWCustRateAreaUAT",model);
//        }

//           async Task<FWResponsePacket> IFreightware.SetFWCustRateArea(Vendor.Services.Freightware.PROD.SetCustRateArea.SetCustRateAreaInCustRateArea model)
//        {
//            return await _connection.PostAsyncDynamic<dynamic,FWResponsePacket>(StringHelpers.Controllers.Freightware, "PostFWCustRateArea",model);
//        }

//            async Task<FWResponsePacket> IFreightware.SetCustFWRateIncreaseUAT(FWIncreaseRatesModel model)
//        {
//            return await _connection.PostAsyncDynamic<dynamic,FWResponsePacket>(StringHelpers.Controllers.Freightware, "SetCustFWRateIncreaseUAT",model);
//        }

//            async Task<FWResponsePacket> IFreightware.SetCustFWRateIncrease(FWIncreaseRatesModel model)
//        {
//            return await _connection.PostAsyncDynamic<dynamic,FWResponsePacket>(StringHelpers.Controllers.Freightware, "SetCustFWRateIncrease",model);
//        }

//        public Task<Vendor.Services.Freightware.PROD.SetQuote.SetQuoteInQuote> ConvertToFWInQuote(QuoteModels quote)
//        {
//            throw new System.NotImplementedException();
//        }

//        public Task<Vendor.Services.Freightware.UAT.SetQuote.SetQuoteInQuote> ConvertToFWUATInQuote(QuoteModels quote)
//        {
//            throw new System.NotImplementedException();
//        }

//        public Task<SetWaybillInWaybill> ConvertDepotToDepot_To_FWWaybill(DepotToDepotModels depotToDepot)
//        {
//            throw new System.NotImplementedException();
//        }

//        public Task<FWResponsePacket> GetFWWSWaybill(string waybillNo)
//        {
//            throw new System.NotImplementedException();
//        }

//        public Task<FWResponsePacket> GetFWWSWaybillUAT(string waybillNo)
//        {
//            throw new System.NotImplementedException();
//        }

//        public Task<FWResponsePacket> SetPODLive(FWPodDetails podDetails)
//        {
//            throw new System.NotImplementedException();
//        }

//        public Task<FWResponsePacket> SetPODUAT(FWPodDetails podDetails)
//        {
//            throw new System.NotImplementedException();
//        }

//        public Task<FWResponsePacket> SetFWCustRateAreaUAT(Vendor.Services.Freightware.UAT.SetCustRateArea.SetCustRateAreaInCustRateArea area)
//        {
//            throw new System.NotImplementedException();
//        }

//        public Task<FWResponsePacket> SetFWCustomerRate(SetAccountRateInRate rate)
//        {
//            throw new System.NotImplementedException();
//        }
//    }
//}
