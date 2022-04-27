using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class InsuranceTypeSerivces
    {

        /// <summary>
        /// Returns a list of insurance types
        /// </summary>
        /// <returns><insureancetypes></returns>
        public static async Task<List<InsuranceTypes>>GetInsuranceTypes<T>()
        {
            return await RestApiHelper.GetAsync<List<InsuranceTypes>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.InsuranceTypes}"));
        }

        /// <summary>
        /// returns Insurance Types by
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="InsuranceTypeId"></param>
        /// <returns><InsureanceTypes></returns>
        public static async Task<InsuranceTypes>GetInsuranceTypesById(int InsuranceTypeId)
        {
            return await RestApiHelper.GetAsync<InsuranceTypes>(new Uri(UrlHelper.Api.TritonApi, ($"{UrlHelper.Controller.InsuranceTypes}{InsuranceTypeId}")));
        }

        /// <summary>
        /// update a on InsuranceTypes
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns><InsureanceTypes></returns>
        public static async Task<long>Post(InsuranceTypes insuranceTypes)
        {
            return await RestApiHelper.PostAsyncLong(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Insurance}"), insuranceTypes);
        }

        /// <summary>
        /// Create a new record on insureancetypes 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns><InsureanceTypes></returns>
        public static async Task<bool> Put(InsuranceTypes model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.InsuranceTypes}"), model);
        }
    }
}
