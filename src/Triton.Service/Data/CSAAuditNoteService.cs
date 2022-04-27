using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Model.CRM.Custom;
using Triton.Service.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class CSAAuditNoteService
    {
        public static async Task<bool> InsertAsync(CSAAuditNote cSAAuditNote)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.Waybill, $"{UrlHelper.Controller.CSAAuditNote}InsertAsync"), cSAAuditNote);
        }

        public static async Task<CSAAuditNoteModel> GetAllAsync(int userId, int customerId, DateTime startDate, DateTime endDate)
        {
            return await RestApiHelper.GetAsync<CSAAuditNoteModel>(new Uri(UrlHelper.Api.Waybill, $"{UrlHelper.Controller.CSAAuditNote}GetAllAsync?userId={userId}&customerId={customerId}&startDate={startDate}&endDate={endDate}"));
        }

        public static async Task<CSAAuditNote> GetByIdAsync(int cSAAuditNoteId)
        {
            return await RestApiHelper.GetAsync<CSAAuditNote>(new Uri(UrlHelper.Api.Waybill, $"{UrlHelper.Controller.CSAAuditNote}GetByIdAsync?cSAAuditNoteId={cSAAuditNoteId}"));
        }
    }
}
