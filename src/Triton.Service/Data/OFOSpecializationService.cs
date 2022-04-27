using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Model.LeaveManagement.Custom;
using Triton.Service.Model.LeaveManagement.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class OFOSpecializationService
    {
        public static async Task<List<OFOSpecialisation>> GetOFOSpecializations()
        {
            return await RestApiHelper.GetAsync<List<OFOSpecialisation>>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOSpecialization}GetOFOSpecializations"));
        }

        public static async Task<List<OFOSpecialisationModel>> GetOFOSpecializationsByID(int OFOCodeID)
        {
            return await RestApiHelper.GetAsync<List<OFOSpecialisationModel>>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOSpecialization}GetOFOSpecializationsByOFOCodeID?OFOCodeID={OFOCodeID}"));
        }

        public static async Task<OFOSpecialisationModel> GetOFOSpecializationsBySpecialisationID(int OFOSpecialisationID)
        {
            return await RestApiHelper.GetAsync<OFOSpecialisationModel>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOSpecialization}GetOFOSpecializationsBySpecialisationID?OFOSpecialisationID={OFOSpecialisationID}"));
        }

        public static async Task<bool> InsertOFOSpecializationAsync(OFOSpecialisation model)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOSpecialization}InsertOFOSpecializationAsync/Insert"), model);
        }

        public static async Task<bool> UpdateOFOSpecializationAsync(OFOSpecialisation model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOSpecialization}UpdateOFOSpecializationAsync/Update"), model);
        }

        public static async Task<bool> DeleteOFOSpecializationAsync(OFOSpecialisation model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOSpecialization}DeleteOFOSpecializationAsync/Update"), model);
        }

        public static async Task<OFOSpecialisation> CheckDuplicateDescription(string Description)
        {
            return await RestApiHelper.GetAsync<OFOSpecialisation>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOSpecialization}CheckDuplicateDescription?Description={Description}"));
        }
    }
}
