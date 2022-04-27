namespace Triton.Model.CRMSCS.Tables
{
    public class ExpectedDeliveriesTotal
    {
        public int PreviouslyUndelivered { get; set; }

        public int Overdue { get; set; }

        public int StoredAtDepot { get; set; }

        public int AgentOverdue { get; set; }

        public int Retained { get; set; }

        public int Bookings { get; set; }

        public int AirFreight { get; set; }

        public int WaybillIssues { get; set; }

        public int OSPODNormal { get; set; }

        public int OSPODAgent { get; set; }

        public int DelQuery { get; set; }

        public int ChainStore { get; set; }

        public int LoadVariance { get; set; }

        public int AwaitingDel { get; set; }

        public int Suspended { get; set; }

        public int COD { get; set; }

        public int TotalOSPOD { get; set; }

        public int Total { get; set; }
    }
}