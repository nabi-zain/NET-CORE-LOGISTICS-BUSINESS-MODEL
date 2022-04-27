using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonGroup.Tables;
using Triton.Service.Model.TritonFleetManagement.Custom;
using Triton.Service.Model.TritonFleetManagement.StoredProcs;
using Triton.Service.Model.TritonFleetManagement.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class VehicleService
    {
        public static async Task<List<Customer>> GetAllCustomers()
        {
            return await RestApiHelper.GetAsync<List<Customer>>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.Vehicle}Customers"));
        }
        public static async Task<List<proc_Vehicle_License_Customer_TailLift_Select>> GetVehicles()
        {
            return await RestApiHelper.GetAsync<List<proc_Vehicle_License_Customer_TailLift_Select>>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.Vehicle}Vehicles"));
        }

        public static async Task<proc_Vehicle_License_Customer_TailLift_Select> GetVehicleDetailsByID(int VehicleID)
        {
            return await RestApiHelper.GetAsync<proc_Vehicle_License_Customer_TailLift_Select>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.Vehicle}VehicleDetails/{VehicleID}"));
        }

        public static async Task<List<proc_Vehicle_License_Customer_TailLift_Select>> GetVehiclesPerCustomer(int? CustomerID, string RegistrationNumber)
        {
            return await RestApiHelper.GetAsync<List<proc_Vehicle_License_Customer_TailLift_Select>>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.Vehicle}VehiclePerCustomer/{CustomerID}/{RegistrationNumber}"));
        }

        public static async Task<List<LookUpCodes>> GetLookUpCodesPerCategory(int LookupcodeCategoryID)
        {
            return await RestApiHelper.GetAsync<List<LookUpCodes>>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.Vehicle}LookUpCodesPerCategory/{LookupcodeCategoryID}"));
        }

        public static async Task<bool> InsertVehicleAsync(VehicleModel model)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.Vehicle}InsertVehicleAsync/Insert"), model);
        }

        public static async Task<bool> UpdateVehicleAsync(proc_Vehicle_Update model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.Vehicle}UpdateVehicleAsync/Update"), model);
        }

        public static async Task<bool> DeActivateVehicleAsync(proc_Vehicle_License_Customer_TailLift_Select model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.Vehicle}DeActivateVehicleAsync/Update"), model);
        }

        public static async Task<bool> ActivateVehicleAsync(proc_Vehicle_License_Customer_TailLift_Select model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.Vehicle}ActivateVehicleAsync/Update"), model);
        }

        public static async Task<Vehicle> CheckIfRegistrationExists(string RegistrationNumber)
        {
            return await RestApiHelper.GetAsync<Vehicle>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.Vehicle}CheckIfRegistrationExists/{RegistrationNumber}"));
        }

        public static async Task<List<VehiclesModel>> GetVehiclesByCustomerIDAsyn(int customerID)
        {
            return await RestApiHelper.GetAsync<List<VehiclesModel>>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.Vehicle}GetVehiclesByCustomerID/{customerID}"));
        }

        public static async Task<List<VehicleAuditModel>> GetVehicleAuditAsync(int VehicleID)
        {
            return await RestApiHelper.GetAsync<List<VehicleAuditModel>>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.Vehicle}VehicleAudit/{VehicleID}"));
        }
    }
}
