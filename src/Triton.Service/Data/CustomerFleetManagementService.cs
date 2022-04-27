using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Service.Model.TritonFleetManagement.Custom;
using Triton.Service.Model.TritonFleetManagement.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class CustomerFleetManagementService
    {
        public static async Task<List<CustomerModel>> GetAllCustomersAsync()
        {
            return await RestApiHelper.GetAsync<List<CustomerModel>>(new Uri(UrlHelper.Api.FleetManagementApi, $"Customer/Customer"));
        }

        public static async Task<CustomerModel> GetCustomerByIdAsync(int customerID)
        {
            return await RestApiHelper.GetAsync<CustomerModel>(new Uri(UrlHelper.Api.FleetManagementApi, $"Customer/Customer{customerID}"));
        }

        public static async Task<CustomerModel> LookUpCodesAsync()
        {
            return await RestApiHelper.GetAsync<CustomerModel>(new Uri(UrlHelper.Api.FleetManagementApi, $"Customer/Customer/LookUpCodes"));
        }

        public static async Task<bool> InsertAsync(CustomerModel customerModel)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"Customer/Customer"), customerModel);
        }


        public static async Task<bool> UpdateAsync(CustomerModel customerModel)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"Customer/Customer"), customerModel);
        }


        public static async Task<bool> IsCustomerNameExists(string customerName)
        {
            return await RestApiHelper.GetAsync<bool>(new Uri(UrlHelper.Api.FleetManagementApi, $"Customer/IsCustomerNameExists?customerName={customerName}"));
        }

        public static async Task<bool> DeleteAsync(Customer customer)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"Customer/DeleteAsync/Delete"), customer);
        }

        public static async Task<bool> InsertDocument(CustomerDocumentRepositoryModel documentRepository)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"Customer/InsertDocumentRepositoryAsync/Insert"), documentRepository);
        }

        public static async Task<DocumentRepository> ViewDocumentAsync(int DocumentRepositoryID)
        {
            return await RestApiHelper.GetAsync<DocumentRepository>(new Uri(UrlHelper.Api.FleetManagementApi, $"Customer/GetAllDocuments/{DocumentRepositoryID}"));
        }

        public static async Task<Customer> GetCustomerIDByCustomerName(string customerName)
        {
            return await RestApiHelper.GetAsync<Customer>(new Uri(UrlHelper.Api.FleetManagementApi, $"Customer/GetCustomerID/{customerName}"));
        }

        public static async Task<bool> DeleteFile(CustomerDocumentRepositoryModel customerDocumentRepository)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"Customer/DeleteFile/Update"), customerDocumentRepository);
        }

        public static async Task<List<CustomerAuditModel>> GetCustomerAuditAsync(int CustomerID)
        {
            return await RestApiHelper.GetAsync<List<CustomerAuditModel>>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.Customer}CustomerAudit/{CustomerID}"));
        }
    }
}
