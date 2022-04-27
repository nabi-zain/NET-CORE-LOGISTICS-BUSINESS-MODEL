using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Model.HRM.Custom;
using Triton.Service.Model.LeaveManagement.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class OFOCodeService
    {
        public static async Task<List<OFOCode>> GetAllAsync()
        {
            return await RestApiHelper.GetAsync<List<OFOCode>>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOCode}GetAllAsync"));
        }

        public static async Task<bool> IsOFOCodeExistsAsync(OFOCode ofoCode)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOCode}IsOFOCodeExistsAsync"), ofoCode);
        }

        public static async Task<OFOCode> GetByIdAsync(int ofoCodeId)
        {
            return await RestApiHelper.GetAsync<OFOCode>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOCode}GetByIdAsync?ofoCodeId={ofoCodeId}"));
        }

        public static async Task<bool> UpdateAsync(OFOCode ofoCode)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOCode}UpdateAsync"), ofoCode);
        }

        public static async Task<bool> InsertAsyn(List<OFOCode> ofoCodes)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOCode}InsertAsync"), ofoCodes);
        }

        public static async Task<bool> DeleteAsync(OFOCode ofoCode)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOCode}DeleteAsync"), ofoCode);
        }

        public static async Task<List<OFOCode>> GetCoursesAsync()
        {
            return await RestApiHelper.GetAsync<List<OFOCode>>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOCode}GetOFOCodesAsync"));
        }

    }
}
