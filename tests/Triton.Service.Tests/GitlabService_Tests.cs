//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;
//using System.Threading.Tasks;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Triton.Service.Data;
//using Triton.Service.Model.Utils;

//namespace Triton.Service.Tests
//{
//    [ExcludeFromCodeCoverage]
//    [TestClass]
//    public class GitlabService_Tests : TestHelper
//    {
//        [TestMethod]
//        public async Task GetGitlabData_Success()
//        {
//            var result = await GitlabService.GetGitlabData("%26created_after=2021-05-06");
//            Assert.IsNotNull(result);
//            Assert.IsTrue(result.Count > 0);
//            Assert.IsInstanceOfType(result, typeof(List<GitlabModel.Root>));
//        }

//        [TestMethod]
//        public async Task GetGitlabProject_Success()
//        {
//            var result = await GitlabService.GetGitlabProject();
//            Assert.IsNotNull(result);
//            Assert.IsTrue(result.Count > 0);
//            Assert.IsInstanceOfType(result, typeof(List<GitlabProject.Root>));
//        }

//        [TestMethod]
//        public async Task GetProjectByFilter_Success()
//        {
//            var result = await GitlabService.GetProjectByFilter(14, "&labels=bug");
//            Assert.IsNotNull(result);
//            Assert.IsTrue(result.Count > 0);
//            Assert.IsInstanceOfType(result, typeof(List<GitlabModel.Root>));
//        }
//    }
//}