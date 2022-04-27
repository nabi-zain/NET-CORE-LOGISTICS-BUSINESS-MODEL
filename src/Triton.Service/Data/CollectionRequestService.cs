using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Custom;
using Triton.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class CollectionRequestService
    {

        /// <summary>
        /// Gets a specific collectionrequest by the collectionrequestId
        /// </summary>
        /// <param name="collectionRequestId"></param>
        /// <param name="dbname"></param>
        /// <returns><CollectionRequest></returns>
        public static  async Task<CollectionRequests>GetCollectionRequest(int collectionRequestId, string dbname)
        {
            return await RestApiHelper.GetAsync<CollectionRequests>(new Uri($"{UrlHelper.Controller.CollectionRequests}{collectionRequestId}/{dbname}"));
        }

        /// <summary>
        /// Returns a list of collection request by customerXRef, startDate, endDate, collectionRequestNumber, customerId
        /// </summary>
        /// <param name="customerXRef"></param>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        /// <param name="CollectionRequestNumber"></param>
        /// <param name="customerId"></param>
        /// <returns><CollectionRequestsModel></returns>
        public static  async Task<CollectionRequestsModel>FindCollectionRequest(string customerXRef, DateTime? StartDate, DateTime? EndDate, string CollectionRequestNumber, int customerId)
        {
            return await RestApiHelper.GetAsync<CollectionRequestsModel>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CollectionRequests}?customerXRef={customerXRef}&StartDate={StartDate}&EndDate={EndDate}&CollectionRequestNumber={CollectionRequestNumber}&CustomerID={customerId}"));
        }

        /// <summary>
        /// Returns a complex object of collection request by collectionRequestId
        /// </summary>
        /// <param name="CollectionRequestID"></param>
        /// <param name="dbName"></param>
        /// <returns><CollectionRequestsModel></returns>
        public static  async Task<CollectionRequestsModel>GetComplex(int CollectionRequestID, string dbName)
        {
            return await RestApiHelper.GetAsync<CollectionRequestsModel>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CollectionRequests}{CollectionRequestID}/{dbName}"));
        }

        
        /// <summary>
        /// Update a record on collection request
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns><CollectionRequest></returns>
        public static  async Task<T> Post<T>(T model)
        {
            return await RestApiHelper.PostAsync<T>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CollectionRequests}"), model);
        }

        /// <summary>
        /// Create a new collection request 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns><CollectionRequest></returns>
        public static  async Task<bool>Put<T>(T model)
        {
            return await RestApiHelper.PutAsync<T>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CollectionRequests}"), model);
        }




    }
}
