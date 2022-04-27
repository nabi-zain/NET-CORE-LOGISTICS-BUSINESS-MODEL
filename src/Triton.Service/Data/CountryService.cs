using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.TritonSecurity.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class CountryService
    {

        /// <summary>
        /// Returns a List<Countrys> from the TritonSecurity.dbo.Countrys.table
        /// </summary>
        /// <returns><Countrys></returns>
        public static async Task<List<Countrys>>GetAsync()
        {
            return await RestApiHelper.GetAsync<List<Countrys >>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Countrys}"));
        }

        public static  Task<long> InsertListAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update a record on Countrys
        /// </summary>
        /// <param name="model"></param>
        /// <returns><Countrys></returns>
        public static async Task<bool> UpdateAsync(List<CountryCurrencySpots> countrys)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Countrys}"), countrys);
        }
    }
}
