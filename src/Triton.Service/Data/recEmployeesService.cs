using System;
using System.Threading.Tasks;
using Triton.Model.LeaveManagement.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class recEmployeesService
    {
        public static async Task<bool> UpdaterecEmployeeAsync(recEmployees recEmployees)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"RecEmployees/RecEmployees"), recEmployees);
        }

        public static async Task<bool> ReinstateExistingPositionByrempIdAsync(int rempID)
        {
            return await RestApiHelper.GetAsync<bool>(new Uri(UrlHelper.Api.RecruitmentApi, $"RecEmployees/RecEmployees?rempId={rempID}"));
        }
    }
}
