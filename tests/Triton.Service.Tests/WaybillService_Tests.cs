//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Diagnostics.CodeAnalysis;
//using System.Threading.Tasks;
//using Triton.Model.CRM.Tables;
////using Microsoft.VisualStudio.TestTools.UnitTesting;
////using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Triton.Service.Data;


//namespace Triton.Service.Tests
//{    
//    [ExcludeFromCodeCoverage]
//    [TestClass]
//    public class WaybillService_Tests : TestHelper
//    {
//        [TestMethod]
//        public async Task GetWaybillByWaybillNo_Success()
//        {
//            //GetWaybillByWaybillNo(string waybillNo, string dbName)
//            var result = await WaybillService.GetWaybillByWaybillNo("12019341", "CRM");
//            Assert.IsNotNull(result);
//            Assert.IsTrue(result.WaybillID == 10772854);
//            Assert.IsInstanceOfType(result, typeof(Waybills));
//        }

//        //[TestMethod]
//        //public async Task PutEmployee_Success()
//        //{
//        //    var employee = await EmployeeService.GetEmployeeModel(2828);
//        //    employee.Employees.Initials = "SH";
//        //    var result = await EmployeeService.Put(employee.Employees);
//        //    Assert.IsNotNull(result);
//        //    Assert.IsTrue(result);
//        //}
//    }
//}
