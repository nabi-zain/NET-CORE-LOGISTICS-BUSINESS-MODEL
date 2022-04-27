using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class TransportTypeService
    {
        public static async Task<List<TransportTypes>> GetAllTransportTypes()
        {
            // TODO: This needs to be fixed... It does not work.  Have to move the API first
            //return await _connection.GetAsync<List<TransportTypes>>(StringHelpers.Controllers.TransportTypes, "", "oldApi_deprecated");            
            return await RestApiHelper.GetAsync<List<TransportTypes>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.TransportTypes}"));
        }

        public static async Task<List<TransportTypes>> GetTransportTypes()
        {
            // TODO: This needs to be fixed... It does not work.  Have to move the API first
            return await RestApiHelper.GetAsync<List<TransportTypes>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.TransportTypes}"));
            //return await _connection.GetAsync<List<TransportTypes>>(StringHelpers.Controllers.TransportTypes, "", "oldApi_deprecated");
        }
    }
}
