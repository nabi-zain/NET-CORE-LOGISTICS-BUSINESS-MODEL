using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Model.HRM.Custom;
using Triton.Service.Model.HRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class EmployeeCourseProviderMapService
    {
        public static async Task<List<EmployeeCourseProviderMapCustomModel>> GetAllAsync()
        {
            return await RestApiHelper.GetAsync<List<EmployeeCourseProviderMapCustomModel>>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.EmployeeCourseProviderMap}GetAllAsync"));
        }

        public static async Task<EmployeeCourseProviderMapCustomModel> GetByIdAsync(int employeeCourseProviderMapId)
        {
            return await RestApiHelper.GetAsync<EmployeeCourseProviderMapCustomModel>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.EmployeeCourseProviderMap}GetByIdAsync?employeeCourseProviderMapId={employeeCourseProviderMapId}"));
        }

        public static async Task<bool> UpdateAsync(EmployeeCourseProviderMap employeeCourseProviderMap)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.EmployeeCourseProviderMap}UpdateAsync"), employeeCourseProviderMap);
        }

        public static async Task<bool> InsertAsync(EmployeeCourseProviderMap employeeCourseProviderMap)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.EmployeeCourseProviderMap}InsertAsync"), employeeCourseProviderMap);
        }
        public static async Task<bool> DeleteAsync(EmployeeCourseProviderMap employeeCourseProviderMap)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.EmployeeCourseProviderMap}DeleteAsync"), employeeCourseProviderMap);
        }

        public static async Task<EmployeeCourseProviderMap> IsEmployeeBookedAsync(int employeeId, int courseId, int providerId)
        {
            return await RestApiHelper.GetAsync<EmployeeCourseProviderMap>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.EmployeeCourseProviderMap}IsEmployeeBookedAsync?employeeId={employeeId}&courseId={courseId}&providerId={providerId}"));
        }
    }
}
