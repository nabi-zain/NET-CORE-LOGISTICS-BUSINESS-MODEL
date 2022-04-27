using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("InsuranceOptions")]
    public class InsuranceOptions
    {
        [Key]
        public int InsuranceOptionId { get; set; }
        public string Description { get; set; }
    }
}
