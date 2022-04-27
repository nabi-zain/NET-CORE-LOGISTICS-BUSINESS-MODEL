using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("DNAInsuranceMaps")]
    public class DNAInsuranceMaps
    {
        public long DNAInsuranceMapID { get; set; }

        public long DNAID { get; set; }
        public int InsuranceID { get; set; }
    }
}
