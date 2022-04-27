using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Custom;
using Triton.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class CollectionManifestService
    {


        /// <summary>
        ///  Gets a specific CollectionManifest by the CollectionManifestid
        /// </summary>
        /// <param name="CollectionManifestId"></param>
        /// <returns><collectionManifest></returns>
        public static  async Task<CollectionManifestLineItems>GetCollectionManifest<T>(int CollectionManifestId)
        {
            return await RestApiHelper.GetAsync<CollectionManifestLineItems>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CollectionManifests}{CollectionManifestId}"));
        }

        /// <summary>
        /// Returns a complex model of Collection Manifest by collectionManifestId
        /// </summary>
        /// <param name="CollectionManifesId"></param>
        /// <param name="dbname"></param>
        /// <returns><CollectionManifestModel></returns>
        public static async Task<CollectionManifestLineItemsModel> GetComplex<T>(int CollectionManifesId, string dbname)
        {
            return await RestApiHelper.GetAsync<CollectionManifestLineItemsModel>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CollectionManifests}{CollectionManifesId}/{dbname}"));
        }

        /// <summary>
        /// Update information by CollectionManifest
        /// </summary>
        /// <param name="collectionManifests"></param>
        /// <returns><CollectionManifest></returns>
        public static  async Task<long>Post(CollectionManifests collectionManifests)
        {
            return await RestApiHelper.PostAsyncLong(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CollectionManifests}"), collectionManifests);
        }


        //public static async Task<long> Post(QuestionnairePostModel model)
        //{
        //    return await RestApiHelper.PostAsyncLong(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Questionnaire}"), model);
        //}



        /// <summary>
        /// Create a new record for CollectionManifest
        /// </summary>
        /// <param name="model"></param>
        /// <returns><CollectionManifest></returns>
        public static  async Task<bool> Put(CollectionManifests collectionManifests)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CollectionManifests}"), collectionManifests);
        }
    }
}
