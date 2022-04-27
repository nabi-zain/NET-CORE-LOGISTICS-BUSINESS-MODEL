using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.TritonSecurity.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class SystemsService
    {
        public static async Task<List<Systems>> GetAllAsync(int systemId)
        {
            return await RestApiHelper.GetAsync<List<Systems>>(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"{UrlHelper.Controller.Systems}SystemsAsync?systemId={systemId}"));
        }
    }
}
