//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;
//using System.Threading.Tasks;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Triton.Model.CRM.StoredProcs;
//using Triton.Service.Data;

//namespace Triton.Service.Tests
//{
//    [ExcludeFromCodeCoverage]
//    [TestClass]
//    public class RateService_Tests : TestHelper
//    {
//        [TestMethod]
//        public async Task GetIncreaseMatrixListAsync_Success()
//        {
//            var result = await WorkFlowStagesService.GetIncreaseMatrixListAsync(null);
//            Assert.IsNotNull(result);
//            Assert.IsTrue(result.Count > 0);
//            Assert.IsInstanceOfType(result, typeof(List<proc_Increase_Matrix_Select>));
//        }
//    }
//}