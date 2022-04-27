using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Model.HRM.Custom;
using Triton.Service.Model.HRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
   public class CourseService
    {
        public static async Task<List<CourseCustomModel>> GetAllAsync()
        {
            return await RestApiHelper.GetAsync<List<CourseCustomModel>>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Course}GetAllAsync"));
        }

        public static async Task<bool> IsProviderNameExists(string courseName)
        {
            return await RestApiHelper.GetAsync<bool>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Course}IsCourseNameExists?courseName={courseName}"));
        }

        public static async Task<Course> GetByIdAsync(int courseId)
        {
            return await RestApiHelper.GetAsync<Course>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Course}GetByIdAsync?courseId={courseId}"));
        }

        public static async Task<bool> UpdateAsync(Course course)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Course}UpdateAsync"), course);
        }

        public static async Task<bool> InsertAsync(Course course)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Course}InsertAsync"), course);
        }
        public static async Task<bool> DeleteAsync(Course course)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Course}DeleteAsync"), course);
        }

        public static async Task<List<Course>> GetCoursesAsync()
        {
            return await RestApiHelper.GetAsync<List<Course>>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Course}GetCoursesAsync"));
        }

        public static async Task<bool> IsCourserNameExistsAsync(string courseName)
        {
            return await RestApiHelper.GetAsync<bool>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Course}IsCourserNameExistsAsync?courseName={courseName}"));
        }

    }
}
