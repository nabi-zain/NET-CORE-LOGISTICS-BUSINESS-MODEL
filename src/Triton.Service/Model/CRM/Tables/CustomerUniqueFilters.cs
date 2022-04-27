using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerUniqueFilters")]
    public class CustomerUniqueFilter
    {
        [Key]
        public int CustomerUniqueFilters { get; set; }
        public int CustomerID { get; set; }
        public byte OnlyUniques { get; set; }
        public byte HasUniques { get; set; }
        public string UniquesType { get; set; }
        public byte MinValueVarFromStandard { get; set; }
        public byte MinKgsVarFromStandard { get; set; }
        public byte HasNonDepotAreas { get; set; }
        public DateTime LastUpdated { get; set; }

    }
}
