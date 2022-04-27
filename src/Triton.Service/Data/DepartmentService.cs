using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonSecurity.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class DepartmentService
    {
        public static async Task<List<Departments>> GetAllActiveDepartments(int isDepartment)
        {
            return await RestApiHelper.GetAsync<List<Departments>>(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"{UrlHelper.Controller.Departments}Departments/{isDepartment}"));
        }
    }
}
