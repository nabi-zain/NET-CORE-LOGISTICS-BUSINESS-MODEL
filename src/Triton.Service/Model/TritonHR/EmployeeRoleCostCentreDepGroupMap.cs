using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    public class EmployeeRoleCostCentreDepGroupMap
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int CostCentreID { get; set; }
        public int DepartmentID { get; set; }
        public int RoleID { get; set; }
        public int GroupID { get; set; }
        public int SeqID { get; set; }
        public int DepartmentLimit { get; set; }
        public int DepotID { get; set; }
        public DateTime AmendDate { get; set; }
    }
}
