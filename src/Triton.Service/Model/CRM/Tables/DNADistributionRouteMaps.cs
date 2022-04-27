using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("DNADistributionRouteMaps")]
    public class DNADistributionRouteMaps

    {

        public long DNADistributionRouteMapID { get; set; }
        public long DNAID { get; set; }
        public int DistributionRouteID { get; set; }
        public decimal Percentage { get; set; }
        public int FromDistributionRouteID { get; set; }
    }
}
