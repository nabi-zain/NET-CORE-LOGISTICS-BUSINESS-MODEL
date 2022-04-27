using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.TritonGroup.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class ReportManagerService
    {
        public static async Task<List<ReportManager>> Get(string roleIds)
        {
            return await RestApiHelper.GetAsync<List<ReportManager>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.ReportManager}/{roleIds}"));
        }

        public static async Task<List<ReportManager>> Get(int systemId, string categoryLciDs, string roleIds)
        {
            return await RestApiHelper.GetAsync<List<ReportManager>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.ReportManager}/{systemId}/{categoryLciDs}/{roleIds}"));
        }

        public static async Task<ReportManager> Get(int reportManagerId)
        {
            return await RestApiHelper.GetAsync<ReportManager>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.ReportManager}/{reportManagerId}"));
        }
    }
}
