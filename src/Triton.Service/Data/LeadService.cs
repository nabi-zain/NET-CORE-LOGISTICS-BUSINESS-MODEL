using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class LeadService
    {
        public static async Task<List<Leads>> GetLeads(string companyName)
        {
            return await RestApiHelper.GetAsync<List<Leads>>(new Uri(UrlHelper.Api.SalesApi, $"{UrlHelper.Controller.Leads}Leads/{companyName}"));
        }

        public static async Task<Leads> GetLeadsID(string companyName)
        {
            return await RestApiHelper.GetAsync<Leads>(new Uri(UrlHelper.Api.SalesApi, $"{UrlHelper.Controller.Leads}LeadsID/{companyName}"));
        }

        public static async Task<bool> UpdateLeadAsync(Leads model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.SalesApi, $"{UrlHelper.Controller.Leads}UpdateLeadAsync/Update"), model);
        }

        public static async Task<Leads> GetLeadsByID(long LeadID)
        {
            return await RestApiHelper.GetAsync<Leads>(new Uri(UrlHelper.Api.SalesApi, $"{UrlHelper.Controller.Leads}LeadsByID/{LeadID}"));
        }
    }
}
