using System.Collections.Generic;
using Triton.Model.TritonGroup.Tables;
using Triton.Model.TritonLH.Tables;
using Customers = Triton.Model.TritonLH.Tables.Customers;

namespace Triton.Model.TritonLH.Custom
{
    public class CustomerTarrifTypeWithLookupcodes
    {
        public CustomerTarrifType CustomerTarrifType { get; set; }
        public LookUpCodes LookUpCodes { get; set; }
    }

    public class ComplexCustomerTarrifTypes
    {
        public Customers Customers { get; set; }
        public CustomerTarrifType CustomerTarrifType { get; set; }
        public LookUpCodes LookUpCodes { get; set; }
    }
}
