using Dapper.Contrib.Extensions;
using System;
using TableAttribute = Dapper.Contrib.Extensions.TableAttribute;

namespace Triton.Model.CRM.Tables
{
    [Table("BranchCPKs")]
    public class BranchCPKS
    {
        public long BranchCPKID { get; set; }
        public int BranchID { get; set; }
        public DateTime ActiveMonth { get; set; }
        public decimal BranchCostExcCDFuel { get; set; }
        public decimal BranchCDActual { get; set; }
        public decimal BranchMarkUp { get; set; }
        public int BranchLHRoutesatTime { get; set; }
        [Computed]
        public decimal FixedCost { get; set; }
        [Computed]
        public decimal CDSell { get; set; }
        public byte EngineActive { get; set; }
    }
}
