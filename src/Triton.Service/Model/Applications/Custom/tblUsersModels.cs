using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;

namespace Triton.Model.Applications.Custom
{
    public class tblUsersModels
    {
        public List<tblUsers> User { get; set; }
        public List<tblMasterBranches> Branch {get;set;}
        public List<tblDepartments> Department { get; set; }
        public tblStatus Status { get; set; }
 }
}
