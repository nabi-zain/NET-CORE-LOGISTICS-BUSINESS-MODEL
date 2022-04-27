using System;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class  eDocService
    {
        public static async Task<long> PostProposalAsync(string accountCode, IncreaseDocuments document)
        {
            return await RestApiHelper.PostAsyncLong(new Uri(UrlHelper.Api.TritonApi, $"Edocs/PostProposal/{accountCode}"), document);
        }
    }
}
