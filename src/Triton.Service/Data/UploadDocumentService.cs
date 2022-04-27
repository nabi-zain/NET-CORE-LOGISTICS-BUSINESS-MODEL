using System;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Service.Model.TritonGroup.Custom;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class UploadDocumentService
    {
        public static async Task<UploadDocumentModel> GetDocumentCategorysAsync()
        {
            return await RestApiHelper.GetAsync<UploadDocumentModel>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.UploadDocument}GetDocumentCategorysAsync"));
        }

        public static async Task<bool> InsertIncreaseDocumentsAsync(IncreaseDocuments increaseDocuments)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.UploadDocument}InsertIncreaseDocumentsAsync"), increaseDocuments);
        }
    }
}
