using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Custom;
using Triton.Model.CRM.Tables;
using Triton.Model.TritonGroup.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class InvoiceService
    {

        /// <summary>
        /// Returns invoices by InvoiceNo
        /// </summary>
        /// <param name="InvoiceNo"></param>
        /// <returns><invoices></returns>
        public static async Task<InvoiceSearchModel>GetInvoiceNo(string InvoiceNo)
        {
            return await RestApiHelper.GetAsync<InvoiceSearchModel>(new Uri(UrlHelper.Api.TritonApi,($"{UrlHelper.Controller.Invoices}{InvoiceNo}")));
        }

        /// <summary>
        /// Returns invoices by invoiceNo, customerId, startDate, EndDate
        /// </summary>
        /// <param name="InvoiceNo"></param>
        /// <param name="CustomerID"></param>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        /// <returns><invoices></returns>
        public static async Task<InvoiceSearchModel>GetInvoiceNo(string InvoiceNo, int CustomerID, DateTime? StartDate, DateTime? EndDate)
        {
            return await RestApiHelper.GetAsync<InvoiceSearchModel>(new Uri(UrlHelper.Api.TritonApi, ($"{UrlHelper.Controller.Invoices}{InvoiceNo}/{CustomerID}/{StartDate}/{EndDate}")));
        }

        /// <summary>
        /// Returns invoices by invoiceId
        /// </summary>
        /// <param name="InvoiceId"></param>
        /// <returns><Invoice></returns>
        public static async Task<Invoices>GetInvoicesById(int InvoiceId)
        {
            return await RestApiHelper.GetAsync<Invoices>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Invoices}{InvoiceId}"));
        }

        public static async Task<DocumentRepositories>GetExcelInvoice(string invoiceNumber, int customerId, DateTime? startDate = null, DateTime? endDate = null)
        {
            return await RestApiHelper.GetAsync<DocumentRepositories>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Invoices}{invoiceNumber}/{customerId}/{startDate}/{endDate}"));
        }
    }
}
