using Dapper.Contrib.Extensions;
using System;
using TableAttribute = Dapper.Contrib.Extensions.TableAttribute;

namespace Triton.Model.CRM.Tables
{
    [Table("CollectionManifests")]
    public class CollectionManifests
    {
        [Key]
        public long CollectionManifestID { get; set; }
        public string CollectionManifesrNumber { get; set; }
        public DateTime CollectionManifestDate { get; set; }
        public int BranchID { get; set; }
        public int RouteID { get; set; }
        public string FWZoneController { get; set; }
        public string FWDriver { get; set; }
        public string FWVechileReg { get; set; }
        public int CollectionManifestStatusID { get; set; }
        public string FWIDCapture { get; set; }
        public decimal TotalMass { get; set; }
        public int TotalQty { get; set; }
        public decimal TotalValue { get; set; }

        public decimal TotalVolume { get; set; }
        public int SubContractorID { get; set; }
        public string subContractorDocNo { get; set; }
    }
}
