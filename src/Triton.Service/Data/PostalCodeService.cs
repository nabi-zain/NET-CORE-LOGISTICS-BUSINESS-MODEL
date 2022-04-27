using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonExpress.Tables;
using Triton.Service.Model.TritonExpress.Custom;
using Triton.Service.Model.TritonExpress.StoredProcs;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class PostalCodeService
    {
        public static Task<PostalCodes> GetAllPostalCodes(string BranchCode)
        {
            throw new NotImplementedException();
        }

        public static async Task<PostalCodes> GetPostalCodes(string name)
        {
            return await RestApiHelper.GetAsync<PostalCodes>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.PostalCode}{name}"));
        }

        public static async Task<List<PostalCodes>> GetPostalCodesOps(string name)
        {
            return await RestApiHelper.GetAsync<List<PostalCodes>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.PostalCode}{name}"));
        }

        public static Task<PostalCodes> GetPostalCodesByCode(string Code)
        {
            throw new NotImplementedException();
        }

        public static Task<PostalCodes> GetSenderPostCodeName(string Date, DateTime CollectionDate, string SenderPostCodeName)
        {
            throw new NotImplementedException();
        }

        public static Task<bool> PutPostalCodes()
        {
            throw new NotImplementedException();
        }

        public static async Task<List<PostalCodes>> FindByPostalCodeAsync(string postalCode)
        {
            return await RestApiHelper.GetAsync<List<PostalCodes>>(new Uri(UrlHelper.Api.Waybill, $"{UrlHelper.Controller.PostalCodes}FindByPostalCodeAsync?postalCode={postalCode}"));
        }

        public static async Task<bool> UploadPostalCodeAsync(string fileName)
        {
            return await RestApiHelper.GetAsync<bool>(new Uri(UrlHelper.Api.Waybill, $"{UrlHelper.Controller.PostalCodes}UploadPostalCodeAsync?fileName={fileName}"));
        }

        public static async Task<bool> DeletePostalCodeAsync(int postalCodeId)
        {
            return await RestApiHelper.GetAsync<bool>(new Uri(UrlHelper.Api.Waybill, $"{UrlHelper.Controller.PostalCodes}DeletePostalCodeAsync?postalCodeId={postalCodeId}"));
        }

        public static async Task<bool> UpdateAsync(PostalCodes postalCodes)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.Waybill, $"{UrlHelper.Controller.PostalCodes}UpdateAsync"), postalCodes);
        }

        public static async Task<bool> InsertAsync(PostalCodes postalCodes)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.Waybill, $"{UrlHelper.Controller.PostalCodes}InsertAsync"), postalCodes);
        }

        public static async Task<PostalCodesModel> GetLookUpAsync()
        {
            return await RestApiHelper.GetAsync<PostalCodesModel>(new Uri(UrlHelper.Api.Waybill, $"{UrlHelper.Controller.PostalCodes}GetLookUpAsync"));
        }

        public static async Task<PostalCodesModel> GetByIdAsync(int postalCodeId)
        {
            return await RestApiHelper.GetAsync<PostalCodesModel>(new Uri(UrlHelper.Api.Waybill, $"{UrlHelper.Controller.PostalCodes}GetByIdAsync?postalCodeId={postalCodeId}"));
        }

        public static async Task<bool> IsNameAndSuburbAndPostalCodeExistsAsync(string name, string suburb, string postalCode)
        {
            return await RestApiHelper.GetAsync<bool>(new Uri(UrlHelper.Api.Waybill, $"{UrlHelper.Controller.PostalCodes}IsNameAndSuburbAndPostalCodeExistsAsync?name={name}&suburb={suburb}&postalCode={postalCode}"));
        }

        public static async Task<List<proc_PostalCodes_Overview>> PostalCodesOverviewAsync(string postalCode)
        {
            return await RestApiHelper.GetAsync<List<proc_PostalCodes_Overview>>(new Uri(UrlHelper.Api.Waybill, $"{UrlHelper.Controller.PostalCodes}PostalCodesOverviewAsync?postalCode={postalCode}"));
        }
    }
}
