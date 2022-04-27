using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Model.TritonFleetManagement.Custom;
using Triton.Service.Model.TritonFleetManagement.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class ScaleHourService
    {
        public static async Task<bool> InsertScaleHour(ScaleHours model)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.ScaleHour}InsertScaleHour/Insert"), model);
        }

        public static async Task<bool> UpdateScaleHour(ScaleHours model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.ScaleHour}UpdateScaleHour/Update"), model);
        }

        public static async Task<List<CostScaleUsersModel>> GetEmployees()
        {
            return await RestApiHelper.GetAsync<List<CostScaleUsersModel>>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.ScaleHour}GetEmployees"));
        }

        public static async Task<List<ScaleHoursModel>> GetEmployeesAndScaleHours()
        {
            return await RestApiHelper.GetAsync<List<ScaleHoursModel>>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.ScaleHour}GetEmployeesandScaleHours"));
        }

        public static async Task<List<ScaleHoursModel>> GetEmployeesAndScaleHoursByCostScale(int costScale)
        {
            return await RestApiHelper.GetAsync<List<ScaleHoursModel>>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.ScaleHour}GetEmployeesAndScaleHoursByCostScale/{costScale}"));
        }

        public static async Task<bool> DeleteScaleHour(ScaleHoursModel model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.ScaleHour}DeleteScaleHour/Update"), model);
        }

        public static async Task<ScaleHoursModel> GetEmployeeDetailsByID(int employeeID)
        {
            return await RestApiHelper.GetAsync<ScaleHoursModel>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.ScaleHour}GetEmployeeDetailsByID/{employeeID}"));
        }

        public static async Task<ScaleHours> CheckIfEmployeeScaleHourExists(int employeeID, int scaleHour)
        {
            return await RestApiHelper.GetAsync<ScaleHours>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.ScaleHour}CheckIfEmployeeScaleHourExists/{employeeID}/{scaleHour}"));
        }

        public static async Task<List<ScaleHourAuditModel>> GetScaleHourAuditAsync(int EmployeeID)
        {
            return await RestApiHelper.GetAsync<List<ScaleHourAuditModel>>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.ScaleHour}ScaleHourAudit/{EmployeeID}"));
        }
    }
}
