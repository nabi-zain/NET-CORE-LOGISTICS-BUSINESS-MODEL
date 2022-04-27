using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Triton.Model.TritonLH.Tables;

namespace Triton.Model.TritonLH.Custom
{
    public class FinancePostedARsModel
    {
        public FinancePostedARs FinancePostedAR { get; set; }
        public Customers Customer { get; set; }
        public Triton.Model.TritonGroup.Tables.LookUpCodes LookUpCodes { get; set; }
        public TritonGroup.Tables.Users Users { get; set; }
    }

        public class FinancePostedARsEditModel
        {
      
        public FinancePostedARsModel FinancePostedARs { get; set; }
        public Triton.Model.TritonGroup.Tables.LookUpCodes LookUpCodes { get; set; }
        public List<Customers> Customers { get; set; }
        }
   
}

