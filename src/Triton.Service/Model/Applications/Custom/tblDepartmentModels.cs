using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;

namespace Triton.Model.Applications.Custom
{
    public class tblDepartmentModels
    {
        public tblDepartments Department { get; set; }
        public tblUsers PrimaryUser { get; set; }
        public tblUsers SecondaryUser { get; set; }
    }
}
