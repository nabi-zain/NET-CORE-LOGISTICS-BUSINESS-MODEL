using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.HelpDesk.StoredProcs
{
    public class GetEmployeeByUserID
    {
      public string BranchFullName { get; set; }
      public string Department { get; set; }
      public string Name { get; set; }
      public string EmailAddress { get; set; }

    }
}
