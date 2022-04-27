using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Service.Model.CRM.Custom;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class FuelSurchangeClassServices
    {
        /// <summary>
        /// Returns back all fuel surchange class
        /// </summary>
        /// <returns><List<FuelSurchangeClass>></returns>
        public static async Task<List<FuelSurchargeClasss>>GetAsync()
        {
            return await RestApiHelper.GetAsync<List<FuelSurchargeClasss>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.FuelSurchargeClass}"));
        }


        /// <summary>
        /// Updates a Fuel surchaneg record
        /// </summary>
        /// <returns><>fuelSurchangeClass</returns>
        public static async Task<bool>UpdateAsync(List<FuelSurchargeClasss> model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonApi,$"{UrlHelper.Controller.FuelSurchargeClass}"), model);
        }

        public static async Task<bool> UpdateAsync(FuelSurchargeClasssModel fuelSurchargeClasss)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.CustomerApi, $"{UrlHelper.Controller.FuelSurchargeClasss}UpdateAsync"), fuelSurchargeClasss);
        }
    }
}
