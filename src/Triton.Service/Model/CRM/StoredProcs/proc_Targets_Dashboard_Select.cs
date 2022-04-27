namespace Triton.Service.Model.CRM.StoredProcs
{
    public class proc_Targets_Dashboard_Select
    {
        public string Period { get; set; }
        public decimal Target { get; set; }
        public decimal FreightBilling { get; set; }
        public decimal Percentage { get; set; }
        public int Variance { get; set; }
        public string TargetType { get; set; }
        public bool IsSouthAfrican { get; set; }
    }

    public class TargetTotal
    {
        public bool IsSouthAfrican { get; set; }
        public string Period { get; set; }
        public decimal Target { get; set; }
        public decimal FreightValue { get; set; }
        public decimal Variance { get; set; }
        public decimal PercentageTotal { get; set; }
        public decimal OutstandingPerc { get; set; }
    }
}
