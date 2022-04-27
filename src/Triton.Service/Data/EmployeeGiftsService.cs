using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.LeaveManagement.Tables;
using Triton.Model.TritonOps.Custom;
using Triton.Model.TritonOps.Tables;
using Triton.Service.Utils;
using LookUpCodes = Triton.Model.TritonGroup.Tables.LookUpCodes;

namespace Triton.Service.Data
{
    public class EmployeeGiftsService
    {
        public static async Task<List<LookUpCodes>> GetAllLookUpCodes()
        {
            return await RestApiHelper.GetAsync<List<LookUpCodes>>(new Uri(UrlHelper.Api.SalesApi, $"EmployeeGifts/LookUpCodes"));
        }

        public static async Task<bool> InsertAsync(EmployeeGifts model)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.SalesApi, $"EmployeeGifts/EmployeeGifts"), model);
        }

        public static async Task<Employees> FindEmployeeByCode(string employeeCode)
        {
            return await RestApiHelper.GetAsync<Employees>(new Uri(UrlHelper.Api.SalesApi, $"EmployeeGifts/{employeeCode}"));
        }
        public static async Task<bool> EmployeeCodeExists(string employeeCode)
        {
            return await RestApiHelper.GetAsync<bool>(new Uri(UrlHelper.Api.SalesApi, $"EmployeeGifts/IsEmployeeCodeExists/{employeeCode}"));
        }

        public static async Task<List<EmployeesBranchesModel>> GetAllEmployeesBranches(string employeeCode)
        {
            return await RestApiHelper.GetAsync<List<EmployeesBranchesModel >> (new Uri(UrlHelper.Api.SalesApi, $"EmployeeGifts/GetAllEmployeesBranches?employeeCode={employeeCode}"));
        }

        public static async Task<List<EmployeeGiftsEditModel>> GetAll()
        {
            return await RestApiHelper.GetAsync<List<EmployeeGiftsEditModel>>(new Uri(UrlHelper.Api.SalesApi, $"EmployeeGifts"));
        }
        public static async Task<EmployeeGifts> GetByEmployeeCode(string employeeCode)
        {
            return await RestApiHelper.GetAsync<EmployeeGifts>(new Uri(UrlHelper.Api.SalesApi, $"EmployeeGifts/GetByEmployeeCode/{employeeCode}"));
        }
        public static async Task<bool> UpdateAsync(EmployeeGifts model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonApi, $"EmployeeGifts/EmployeeGifts"), model);
        }
    }
}
