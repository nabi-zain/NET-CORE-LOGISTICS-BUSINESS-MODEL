using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Model.CRM.Custom;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class CustomerAssessmentService
    {
        public static async Task<CustomerAssessmentModel> GetWaybillCustomerAssessment(int CustomerID, DateTime DateFrom, DateTime DateTo)
        {
            return await RestApiHelper.GetAsync<CustomerAssessmentModel>(new Uri(UrlHelper.Api.CrmApi, $"{UrlHelper.Controller.Customer}GetWaybillCustomerAssessment?CustomerID={CustomerID}&DateFrom={DateFrom}&DateTo={DateTo}"));
        }
    }
}
