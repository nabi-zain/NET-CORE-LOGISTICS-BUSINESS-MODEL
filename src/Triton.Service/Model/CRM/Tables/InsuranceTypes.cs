using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("InsuranceTypes")]
    public class InsuranceTypes
    {
        [Key]
        public int InsuranceTypeID { get; set; }
        public string Description { get; set; }
        public string Wording { get; set; }
    }
}
