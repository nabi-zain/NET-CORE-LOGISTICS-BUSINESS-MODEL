namespace Triton.Model.TritonOps.StoredProcs
{
    public class proc_CSA_Customer_Select
    {
        public int PreviouslyDelivered { get; set; }
        public int Failed { get; set; }
        public int ExpectedForToday { get; set; }
        public int DueInHour { get; set; }
        public int Depot { get; set; }
        public int Overdue { get; set; }
        public int TotalDeliveries { get; set; }
        public int Delivered { get; set; }
        public int PreviouslyUndelivered { get; set; }
        public int Retained { get; set; }
        public int Bookings { get; set; }
        public int FutureDel { get; set; }
        public int NoDelSheet { get; set; }
        public int InTransit { get; set; }
        public int OutstandingToday { get; set; }
        public int Agent { get; set; }
        public decimal PercDelivered { get; set; }
        public decimal PercOutstanding { get; set; }
        public decimal PercFailed { get; set; }
    }
}
