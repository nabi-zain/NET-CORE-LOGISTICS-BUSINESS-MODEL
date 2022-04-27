using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("CompanyCostCenterMaping")]
 public   class CompanyCostCentreMapping
    {
        [Key]
        public int CompanyCostCentreMappingID { get; set; }
        public int CompanyID { get; set; }
        public int CostCentreID { get; set; }

    }
}
