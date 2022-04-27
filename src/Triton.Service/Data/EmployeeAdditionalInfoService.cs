using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Model.HRM.Custom;
using Triton.Service.Model.HRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class EmployeeAdditionalInfoService
    {
        public static async Task<bool> InsertAsync(EmployeeAdditionalInfo model)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.EmployeeAdditionalInfo}InsertAsync/Insert"), model);
        }

        public static async Task<bool> UpdateAsync(EmployeeAdditionalInfo model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.EmployeeAdditionalInfo}UpdateAsync/Update"), model);
        }

        public static async Task<List<EmployeeAdditionalInfoCustomModel>> GetAllEmployees()
        {
            return await RestApiHelper.GetAsync<List<EmployeeAdditionalInfoCustomModel>>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.EmployeeAdditionalInfo}GetAllEmployees"));
        }

        public static async Task<EmployeeAdditionalInfoCustomModel> GetEmployeeByID(int employeeAdditionalInfoID)
        {
            return await RestApiHelper.GetAsync<EmployeeAdditionalInfoCustomModel>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.EmployeeAdditionalInfo}GetEmployeeByID/{employeeAdditionalInfoID}"));
        }

        public static async Task<List<EmployeeAdditionalInfoCustomModel>> GetEmployeeBySAID(string SAID)
        {
            return await RestApiHelper.GetAsync<List<EmployeeAdditionalInfoCustomModel>>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.EmployeeAdditionalInfo}GetEmployeeBySAID/{SAID}"));
        }
    }
}
