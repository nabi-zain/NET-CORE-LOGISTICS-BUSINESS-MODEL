using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Custom;
using Triton.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class CollectionRequestTrackAndTraceService
    {
        /// <summary>
        /// Returns Collection Request by collectionrequestId and dbname
        /// </summary>
        /// <param name="collectionRequestId"></param>
        /// <param name="dbName"></param>
        /// <returns><List<CollectionRequestTrackandTracesModel>></returns>
        public static  async Task<CollectionRequestsModel> FindCollectionRequest<T>(int collectionRequestId, string dbName)
        {
            return await RestApiHelper.GetAsync<CollectionRequestsModel>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CollectionManifestLineItems}{collectionRequestId}/{dbName}"));
        }

        /// <summary>
        /// Returns CollectionRequestTrackandTrace by CollectionRequestTrackAndTraceId
        /// </summary>
        /// <param name="CollectionRequestTrackAndTraceID"></param>
        /// <param name="dbname"></param>
        /// <returns><CollectionRequestTrackAndTrace></returns>
        public static  async Task<CollectionRequestTrackAndTraces> GetCollectionRequestTrackAndTraces<T>(int CollectionRequestTrackAndTraceID, string dbname)
        {
            return await RestApiHelper.GetAsync<CollectionRequestTrackAndTraces>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Collection}{CollectionRequestTrackAndTraceID}/{dbname}"));
        }

        /// <summary>
        /// Update a record on CollectionRequestTrackAndTrace by T
        /// </summary>
        /// <param name="collectionRequestTrackAndTraces"></param>
        /// <returns><CollectionRequestTrackAndTrace></returns>
        public static  async Task<long>Post(CollectionRequestTrackAndTraces collectionRequestTrackAndTraces)
        {
            return await RestApiHelper.PostAsyncLong(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Collection}"), collectionRequestTrackAndTraces);
        }


        /// <summary>
        /// Create a new CollectionRequestTrackAndTrace record
        /// </summary>
        /// <param name="collectionRequestTrackAndTrace"></param>
        /// <returns><CollectionRequestTrackAndTrace></returns>
        public static  async Task<bool>Put(CollectionRequestTrackAndTraces collectionRequestTrackAndTrace)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Collection}"), collectionRequestTrackAndTrace);
        }

        /// <summary>
        /// Returns a complex model of 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="CollectionRequestTrackAndTraceID"></param>
        /// <param name="dbname"></param>
        /// <returns><CollectionRequestTrackAndTrace></returns>
        public static  async Task<CollectionRequestsModel>GetComplex(int CollectionRequestTrackAndTraceID, string dbname)
        {
            return await RestApiHelper.GetAsync<CollectionRequestsModel>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CollectionRequestTrackAndTrace}{CollectionRequestTrackAndTraceID}/{dbname}"));
        }


    }
}
