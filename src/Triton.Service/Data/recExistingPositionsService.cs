using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.LeaveManagement.Tables;
using Triton.Service.Utils;
using Triton.Model.LeaveManagement.Custom;

namespace Triton.Service.Data
{
    public class recExistingPositionsService
    {
        public static async Task<List<recExistingPositionsModel>> GetAllAsync(string referenceNumber)
        {
            return await RestApiHelper.GetAsync<List<recExistingPositionsModel>>(new Uri(UrlHelper.Api.RecruitmentApi, $"RecExistingPosition/recExistingPositions/GetAllAsync{referenceNumber}"));
        }
        public static async Task<recExistingPositionsModel> GetByextCodeIdAsync(int extCodeId)
        {
            return await RestApiHelper.GetAsync<recExistingPositionsModel>(new Uri(UrlHelper.Api.RecruitmentApi, $"RecExistingPosition/recExistingPositions{extCodeId}"));
        }


        public static async Task<bool> UpdateAsync(recExistingPositions recExistingPositions)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"RecExistingPosition/recExistingPositions"), recExistingPositions);
        }

        public static async Task<recExistingPositions> GetByextCodeID(int extCodeId)
        {
            return await RestApiHelper.GetAsync<recExistingPositions>(new Uri(UrlHelper.Api.RecruitmentApi, $"RecExistingPosition/recExistingPositions/GetByextCodeID{extCodeId}"));
        }
    }
}
