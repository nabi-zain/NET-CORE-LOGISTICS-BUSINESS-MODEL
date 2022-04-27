using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Model.LeaveManagement.Tables;
using Triton.Model.TritonSecurity.Tables;
using Triton.Service.Model.CRM.Custom;
using Triton.Service.Model.CRM.StoredProcs;
using Triton.Service.Model.CRM.Tables;
using Triton.Service.Model.TritonSecurity.Custom;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    #region New Business
    public class RepTargetService
    {
        public static async Task<List<Employees>> GetRepUsersNewBizGrid()
        {
            return await RestApiHelper.GetAsync<List<Employees>>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RepTargets}GetRepUsersNewBizGrid"));
        }
        public static async Task<List<Dates>> GetCalenderYear()
        {
            return await RestApiHelper.GetAsync<List<Dates>>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RepTargets}GetCalenderYear"));
        }

        public static async Task<List<RepTargetsModel>> GetRepTargetsNewBizGrid(int FinancialYear, int UserID, int TargetType)
        {
            return await RestApiHelper.GetAsync<List<RepTargetsModel>>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RepTargets}GetRepTargetsNewBizGrid/{FinancialYear}/{UserID}/{TargetType}"));
        }

        public static async Task<List<proc_FinancialvsSaleTargets>> GetFinancialvsSaleTargetsNewBizGrid()
        {
            return await RestApiHelper.GetAsync<List<proc_FinancialvsSaleTargets>>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RepTargets}GetFinancialvsSaleTargetsNewBizGrid"));
        }

        public static async Task<bool> UploadReptarget(int targetType, int UserID, string FileName)
        {
            return await RestApiHelper.GetAsync<bool>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.UploadDocument}UploadReptarget?targetType={targetType}&UserID={UserID}&FileName={FileName}"));
        }

        public static async Task<RepTargetsModel> IndividualRepTarget(string RepCode, int FinancialYear, int TargetType, int EmployeeID)
        {
            return await RestApiHelper.GetAsync<RepTargetsModel>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RepTargets}GetIndividualRepTarget/{RepCode}/{FinancialYear}/{TargetType}/{EmployeeID}"));
        }

        public static async Task<int> GetFinancialYear(DateTime Date)
        {
            return await RestApiHelper.GetAsync<int>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RepTargets}GetFinancialYear?Date={Date}"));
        }
    }
    #endregion

    #region Existing Business
    public class RepTargetExBizService
    {
        public static async Task<List<Employees>> GetRepUsersExBizGrid()
        {
            return await RestApiHelper.GetAsync<List<Employees>>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RepTargets}GetRepUsersExBizGrid"));
        }
        public static async Task<List<Dates>> GetCalenderYear()
        {
            return await RestApiHelper.GetAsync<List<Dates>>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RepTargets}GetCalenderYear"));
        }

        public static async Task<List<RepTargetsModel>> GetRepTargetsExBizGrid(int FinancialYear, int UserID, int TargetType)
        {
            return await RestApiHelper.GetAsync<List<RepTargetsModel>>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RepTargets}GetRepTargetsExBizGrid/{FinancialYear}/{UserID}/{TargetType}"));
        }

        public static async Task<List<proc_FinancialvsSaleTargets>> GetFinancialvsSaleTargetsExBizGrid()
        {
            return await RestApiHelper.GetAsync<List<proc_FinancialvsSaleTargets>>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RepTargets}GetFinancialvsSaleTargetsExBizGrid"));
        }
    }
    #endregion

    #region Transient Business
    public class RepTargetTransBizService
    {
        public static async Task<List<RepTargetsModel>> GetRepTargetsTransBizGrid(int FinancialYear, int UserID, int TargetType)
        {
            return await RestApiHelper.GetAsync<List<RepTargetsModel>>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RepTargets}GetRepTargetsTransBizGrid/{FinancialYear}/{UserID}/{TargetType}"));
        }

        public static async Task<List<proc_FinancialvsSaleTargets>> GetFinancialvsSaleTargetsTransBizGrid()
        {
            return await RestApiHelper.GetAsync<List<proc_FinancialvsSaleTargets>>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RepTargets}GetFinancialvsSaleTargetsTransBizGrid"));
        }
    }
    #endregion
}
