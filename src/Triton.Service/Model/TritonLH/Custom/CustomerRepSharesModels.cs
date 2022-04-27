using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonLH.Tables;

namespace Triton.Model.TritonLH.Custom
{
    public class CustomerRepSharesEditModels
    {
        public CustomersModels Customer { get; set; }
        public List<CustomerRepShareModels> RepShares { get; set; }
    }

    public class CustomerRepShareModels
    {
        public CustomerRepShares Share { get; set; }
        public Customers Customer { get; set; }
        public RepsModels Rep { get; set; }
    }

    public class CustomerRepShareCreateModels
    {
        public CustomerRepShares Share { get; set; }
        public Customers Customer { get; set; }

        public List<RepsModels> Reps { get; set; }
    }
}
