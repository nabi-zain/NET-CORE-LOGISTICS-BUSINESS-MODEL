using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerAdjustments")]
    public class CustomerAdjustments
    {
        public int CustomerAdjustmentID { get; set; }
        public int CustomerID { get; set; }
        public DateTime DateInitiated { get; set; }
        public byte HasManualRates { get; set; }
        public int NewRateClassID { get; set; }
        public string Ref { get; set; }
        public DateTime DateEffective { get; set; }
        public int SpecificOutSiteID { get; set; }
        public byte isDepottoDepot { get; set; }
        public int newVolume { get; set; }
        public string NewVolumeReason { get; set; }

        public int FinalStageID { get; set; }
        public string OutCome { get; set; }
        public DateTime NextIncreaseDate { get; set; }
    }
}
