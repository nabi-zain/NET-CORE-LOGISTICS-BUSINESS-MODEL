using System.Collections.Generic;
using Triton.Model.Applications.Tables;
using Triton.Model.LeaveManagement.Tables;
using Triton.Model.TritonGroup.Tables;
using Customers = Triton.Model.CRM.Tables.Customers;

namespace Triton.Model.TritonGroup.Custom
{
    public class UserMapCustomerModels
    {
        public List<UserMap> UserMap { get; set; }
        public List<Customers> Customers { get; set; }
        public List<tblMasterSuppliers> Suppliers { get; set; }
        public Employees Employees { get; set; }
    }
}
