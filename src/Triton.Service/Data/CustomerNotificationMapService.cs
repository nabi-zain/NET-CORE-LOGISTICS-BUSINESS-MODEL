using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Custom;
using Triton.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class CustomerNotificationMapService
    {
        public static async Task<CustomerNotificationMaps> GetById(int customerNotificationMapId)
        {
            return await RestApiHelper.GetAsync<CustomerNotificationMaps>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CustomerNotificationMap}{customerNotificationMapId}"));
        }

        public static async Task<CustomerNotificationMaps> GetAsync()
        {
            return await RestApiHelper.GetAsync<CustomerNotificationMaps>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CustomerNotificationMap}/GetAsync"));
        }

        public static async Task<List<proc_CustomerNotificationMapSearch>> GetCustomerNotificationMapList()
        {
            return await RestApiHelper.GetAsync<List<proc_CustomerNotificationMapSearch>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CustomerNotificationMap}GetCustomerNotificationMapList"));
        }

        public static async Task<CustomerNotificationMapsModel> GetComplex(int customerNotificationMapId)
        {
            return await RestApiHelper.GetAsync<CustomerNotificationMapsModel>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CustomerNotificationMap}GetComplex/{customerNotificationMapId}"));
        }

        public static async Task<long> PostAsync(CustomerNotificationMaps model)
        {
            return await RestApiHelper.PostAsyncLong<CustomerNotificationMaps>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CustomerNotificationMap}PostAsync"), model);
        }

        public static async Task<bool> PutAsync(CustomerNotificationMaps model)
        {
            return await RestApiHelper.PutAsync<CustomerNotificationMaps>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CustomerNotificationMap}PutAsync"), model);
        }
        public static async Task<CustomerNotificationMapsEditModel> Create()
        {
            return await RestApiHelper.GetAsync<CustomerNotificationMapsEditModel>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CustomerNotificationMap}Create"));
        }


    }
}
