using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Custom;
using Triton.Model.CRM.Tables;
using Triton.Service;
using Triton.Service.Utils;


namespace Triton.Service.Data
{
    public class CustomerAdministrationHistorysService
    {
        public static async Task<long> InsertAsync<T>(T model)
        {
            return await RestApiHelper.PostAsyncLong<T>(new Uri(UrlHelper.Api.SalesApi, $"{UrlHelper.Controller.CustomerAdministrationHistory}InsertAsync" ), model); 
        }

        public static async Task<CustomerAdministrationHistory> GetCustomerAdministrationHistoryByAccountCode(string accountCode)
        {
            return await RestApiHelper.GetAsync<CustomerAdministrationHistory>(new Uri(UrlHelper.Api.SalesApi, $"{UrlHelper.Controller.CustomerAdministrationHistory}GetCustomerAdministrationHistoryByAccountCode/{accountCode}"));
        }

        public static async Task<List<FWRepMaps>> GetFWRepMaps(string FWCode)
        {
            return await RestApiHelper.GetAsync<List<FWRepMaps>>(new Uri(UrlHelper.Api.SalesApi, $"{UrlHelper.Controller.CustomerAdministrationHistory}GetFWRepMaps/{FWCode}"));
        }

        public static async Task<List<RepCodes>> GetRepCodesByRepCode(string RepCode)
        {
            return await RestApiHelper.GetAsync<List<RepCodes>>(new Uri(UrlHelper.Api.SalesApi, $"{UrlHelper.Controller.CustomerAdministrationHistory}GetRepCodesByRepCodes/{RepCode}"));
        }
        public static async Task<List<RepCodes>> GetRepCodesByID(int RepCodeID)
        {
            return await RestApiHelper.GetAsync<List<RepCodes>>(new Uri(UrlHelper.Api.SalesApi, $"{UrlHelper.Controller.CustomerAdministrationHistory}GetRepCodesByID/{RepCodeID}"));
        }
        public static async Task<List<CustomerCommisionTypes>> GetCommisionTypes()
        {
            return await RestApiHelper.GetAsync<List<CustomerCommisionTypes>>(new Uri(UrlHelper.Api.SalesApi, $"{UrlHelper.Controller.CustomerAdministrationHistory}GetCommisionTypes"));
        }
        public static async Task<List<RepCodes>> GetRepCodes()
        {
            return await RestApiHelper.GetAsync<List<RepCodes>>(new Uri(UrlHelper.Api.SalesApi, $"{UrlHelper.Controller.CustomerAdministrationHistory}GetRepCodes"));
        }
    }
}
