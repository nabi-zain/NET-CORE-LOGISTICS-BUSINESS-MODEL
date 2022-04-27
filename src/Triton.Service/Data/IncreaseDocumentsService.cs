using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Service.Model.CRM.Custom;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class IncreaseDocumentsService
    {
        public static async Task<List<IncreaseDocumentModel>> GetAllIncreaseDocumentAsync(int customerAnalysisId)
        {
            return await RestApiHelper.GetAsync<List<IncreaseDocumentModel>>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.IncreaseDocument}GetIncreaseDocumentByIdAsync?customerAnalysisId={customerAnalysisId}"));
        }

        public static async Task<IncreaseDocumentModel> GetIncreaseDocumentByDocumentID(int documentId)
        {
            return await RestApiHelper.GetAsync<IncreaseDocumentModel>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.IncreaseDocument}GetIncreaseDocumentByDocumentID?documentId={documentId}"));
        }

        public static async Task<IncreaseDocuments> GetIncreaseDocumentByAnalysisID(int customerAnalysisId)
        {
            return await RestApiHelper.GetAsync<IncreaseDocuments>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.IncreaseDocument}GetIncreaseDocumentByAnalysisID?customerAnalysisId={customerAnalysisId}"));
        }
    }
}
