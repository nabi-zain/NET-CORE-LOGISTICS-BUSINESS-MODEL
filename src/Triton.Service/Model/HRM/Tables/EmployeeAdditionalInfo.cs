using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Triton.Service.Model.HRM.Tables
{
    [Table("EmployeeAdditionalInfo")]
    public class EmployeeAdditionalInfo
    {
        [Dapper.Contrib.Extensions.Key]
        public int EmployeeAdditionalID { get; set; }
        public int EmployeeID { get; set; }
        public int Equity { get; set; }
        public int SocioEconomicStatus { get; set; }
        public int Disability { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedBy { get; set; }
    }
}
