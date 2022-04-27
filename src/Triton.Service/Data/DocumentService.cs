using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class DocumentService
    {
        /// <summary>
        /// Returns a Edoc Image by waybillNo
        /// </summary>
        /// <param name="waybillNo"></param>
        /// <param name="nodeName"></param>
        /// <returns></returns>
        public static  async Task<byte[]> GeteDocsImageByCustomerID(string waybillNo, string nodeName)
        {
            return await RestApiHelper.GetAsync<byte[]>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Edocs}{waybillNo}/{nodeName}"));
        }

        /// <summary>
        /// Returns a customer statement by accountCode, period
        /// </summary>
        /// <param name="AccountCode"></param>
        /// <param name="Period"></param>
        /// <returns></returns>
        public static  async Task<byte[]> GetCustomerStatementByAccountCodeandPeriod(string AccountCode, DateTime Period)
        {
            return await RestApiHelper.GetAsync<byte[]>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Edocs}{AccountCode}/{Period}"));
        }


        /// <summary>
        /// Returns customer invoice by invoiceNumber
        /// </summary>
        /// <param name="InvoiceNumber"></param>
        /// <returns></returns>
        public static  async Task<byte[]> GetCustomerInvoicebyInvoiceNumber(string InvoiceNumber)
        {
            return await RestApiHelper.GetAsync<byte[]>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Edocs}{InvoiceNumber}"));
        }
    }
}
