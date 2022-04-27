using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Model.HRM.Custom;
using Triton.Service.Model.HRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class ProviderService
    {
        public static async Task<List<ProviderCustomModel>> GetAllAsync()
        {
            return await RestApiHelper.GetAsync<List<ProviderCustomModel>>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Provider}GetAllAsync"));
        }

        public static async Task<Provider> GetByIdAsync(int providerId)
        {
            return await RestApiHelper.GetAsync<Provider>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Provider}GetByIdAsync?providerId={providerId}"));
        }

        public static async Task<bool> UpdateAsync(Provider provider)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Provider}UpdateAsync"), provider);
        }

        public static async Task<bool> InsertAsync(Provider provider)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Provider}InsertAsync"), provider);
        }
        public static async Task<bool> DeleteAsync(Provider provider)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Provider}DeleteAsync"), provider);
        }

        public static async Task<List<Provider>> GetProvidersAsync()
        {
            return await RestApiHelper.GetAsync<List<Provider>>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Provider}GetProvidersAsync"));
        }

        public static async Task<bool> IsProviderNameExists(Provider provider)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Provider}IsProviderNameExists"), provider);
        }

    }
}
