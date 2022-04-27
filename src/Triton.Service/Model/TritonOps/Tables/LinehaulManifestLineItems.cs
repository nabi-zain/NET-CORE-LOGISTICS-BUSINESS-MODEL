namespace Triton.Model.TritonOps.Tables
{
    public class LinehaulManifestLineItems
    {
        public int LinehaulManifestLineItemID { get; set; }
        public int? LineNumber { get; set; }
        public string FWWaybillNo { get; set; }
        public long? WaybillID { get; set; }
        public int? ManifestedQty { get; set; }
        public decimal? ManifestedMass { get; set; }
        public decimal? ManifestedValue { get; set; }
        public decimal? ManifestedVolume { get; set; }
        public int? ReceivedQty { get; set; }
        public string Notes { get; set; }
        public string LineType { get; set; }
        public string DiscrepancyReason { get; set; }
    }
}
