using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class CollectionServices
    {
        /// <summary>
        /// get collection by collectionId and dbname
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="dbname"></param>
        /// <returns><Collections></returns>
        public static  async Task<Collections>GetCollection(int collectionId, string dbname)
        {
            return await RestApiHelper.GetAsync<Collections>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Collection}{collectionId}/{dbname}"));
        }


        /// <summary>
        /// Create a new record by model
        /// </summary>
        /// <param name="model"></param>
        /// <returns><Collections></returns>
        public static  async Task<bool>Put(Collections collections)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Collection}"), collections);
        }

        /// <summary>
        /// Update a record in collection by model
        /// </summary>
        /// <param name="model"></param>
        /// <returns><Collections></returns>
        public static  async Task<long> Post(Collections collections)
        {
            return await RestApiHelper.PostAsyncLong(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Collection}"), collections);
        }

        /// <summary>
        /// returns COllections by collectionNo and dbname
        /// </summary>
        /// <param name="CollectionNo"></param>
        /// <param name="dbname"></param>
        /// <returns><Collections></returns>
        public static  async Task<Collections>GetCollectionByNo(string CollectionNo, string dbname)
        {
            return await RestApiHelper.GetAsync<Collections>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Collection}{CollectionNo}/{dbname}"));
        }

    }
}