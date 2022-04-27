using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Custom;
using Triton.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class CollectionManifestLineItemsService
    {

        /// <summary>
        /// Get Collection Manifest line items by collectionManifestLineItemId
        /// </summary>
        /// <param name="collectionManifestLineItemId"></param>
        /// <param name="dbname"></param>
        /// <returns></returns>
        public static  async Task<CollectionManifestLineItems>GetCollectionManifestLineItems<T>(int collectionManifestLineItemId, string dbname)
        {
            return await RestApiHelper.GetAsync<CollectionManifestLineItems>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CollectionManifestLineItems}{collectionManifestLineItemId}/{dbname}"));
        }

        /// <summary>
        /// Create a new collection manifest line item by collectionManifestLineItems
        /// </summary>
        /// <param name="collectionManifestLineItems"></param>
        /// <returns><CollectionManifestLineItems></returns>
        public static  async Task<bool>Put(CollectionManifestLineItems collectionManifestLineItems)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CollectionManifestLineItems}"), collectionManifestLineItems);
        }

        /// <summary>
        /// Update a record by 
        /// </summary>
        /// <param name="CollectionManifestLineItems"></param>
        /// <returns><CollectionManifestLineItems></returns>
        public static  async Task<long>Post(CollectionManifestLineItems collectionManifestLineItems)
        {
            return await RestApiHelper.PostAsyncLong(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CollectionManifestLineItems}"), collectionManifestLineItems);
               
        }

        /// <summary>
        /// Returns a complex model of collectionManifestLineItemId
        /// </summary>
        /// <param name="CollectionManifestLineItemID"></param>
        /// <param name="dbname"></param>
        /// <returns><CollectionManifestLineItemsModel></returns>
        public static  async Task<CollectionManifestLineItemsModel>GetComplex(int CollectionManifestLineItemID, string dbname)
        {
            return await RestApiHelper.GetAsync<CollectionManifestLineItemsModel>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CollectionManifestLineItems}{CollectionManifestLineItemID}/{dbname}"));
        }
    }
}
