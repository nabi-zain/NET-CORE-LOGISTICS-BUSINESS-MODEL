using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("InsuranceWaivers")]
    public class InsuranceWaivers
    {
        [Key]
        public int InsuranceWaiverID { get; set; }
        public string Note { get; set; }
    }
}
