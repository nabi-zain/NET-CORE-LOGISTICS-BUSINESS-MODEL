using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Service.Model.Utils;

namespace Triton.Service.Data
{
    public static class GitlabService
    {
        public static async Task<List<GitlabModel.Root>> GetGitlabData(string filter)
        {
            var url = "http://neo:8089/api/Gitlab";
            if (filter != null)
            {
                url = $"{url}?filter={filter}";
            }
            return await RestApiHelper.GetAsync<List<GitlabModel.Root>>(new Uri(url));
        }

        public static async Task<List<GitlabProject.Root>> GetGitlabProject()
        {
            return await RestApiHelper.GetAsync<List<GitlabProject.Root>>(new Uri("http://neo:8089/api/Gitlab/Project"));
        }

        public static async Task<List<GitlabModel.Root>> GetProjectByFilter(int projectId, string filter)
        {
            return await RestApiHelper.GetAsync<List<GitlabModel.Root>>(new Uri($"http://neo:8089/api/Gitlab/GetProjectByFilter?projectId={projectId}&filter={filter}"));
        }
    }
}
