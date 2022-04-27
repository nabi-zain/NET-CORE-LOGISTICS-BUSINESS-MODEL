using System;
using System.Collections.Generic;
using System.Text;
using Triton.Model.LeaveManagement.Tables;
using Triton.Model.TritonGroup.Tables;
using Triton.Service.Model.HRM.Tables;

namespace Triton.Service.Model.HRM.Custom
{
    public class EmployeeAdditionalInfoCustomModel
    {
        public string FullNames { get; set; }
        public string Surname { get; set; }
        public string SAID { get; set; }
        public string CurrentEmployeeCode { get; set; }
        public int EmployeeAdditionalID { get; set; }
        public int Equity { get; set; }
        public int SocioEconomicStatus { get; set; }
        public int Disability { get; set; }
        public string Name { get; set; }
        public string LC_Equity { get; set; }
        public string LC_SocioEconomicStatus { get; set; }
        public string LC_Disability { get; set; }
        public int EmployeeID { get; set; }
        public int OFOLCID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime DeletedOn { get; set; }
        public int DeletedBy { get; set; }
    }
}
