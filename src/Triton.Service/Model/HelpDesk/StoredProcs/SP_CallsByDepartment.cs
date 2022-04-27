using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.HelpDesk.StoredProcs
{
    public class SP_CallsByDepartment
    {
        public string NoOfCalls { get; set; }
        public string Descripition { get; set; }
        public DateTime TimeofCall { get; set; }
    }
}
