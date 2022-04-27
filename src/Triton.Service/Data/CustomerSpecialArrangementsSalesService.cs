using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class CustomerSpecialArrangementsSalesService
    {
        public static async Task<CustomerSpecialArangementsSales> GetSpeicalArrangementSales(int customerID)
        {
            return await RestApiHelper.GetAsync<CustomerSpecialArangementsSales>(new Uri(UrlHelper.Api.CrmApi, $"{UrlHelper.Controller.Customer}GetSpeicalArrangementSales?customerID={customerID}"));
        }

        public static async Task<CustomerSpecialArangementsSales> GetSpecialArangementSalesByID(int SpecialArangementSalesID)
        {
            return await RestApiHelper.GetAsync<CustomerSpecialArangementsSales>(new Uri(UrlHelper.Api.CrmApi, $"{UrlHelper.Controller.Customer}GetSpecialArangementSalesByID/{SpecialArangementSalesID}"));
        }

        public static async Task<bool> UpdateSpecialArrangementSales(CustomerSpecialArangementsSales model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.CrmApi, $"{UrlHelper.Controller.Customer}UpdateSpecialArrangementSales/Update"), model);
        }

        public static async Task<bool> InsertSpecialArrangementSales(CustomerSpecialArangementsSales model)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.CrmApi, $"{UrlHelper.Controller.Customer}InsertSpecialArrangementSales/Insert"), model);
        }
    }
}
