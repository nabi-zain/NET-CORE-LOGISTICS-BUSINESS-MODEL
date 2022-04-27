using System.ComponentModel;

namespace Triton.Model.CRM.StoredProcs
{
    public class proc_Deliveries_Total_By_ZoneController_Select
    {
        public int UserID { get; set; }

        [DisplayName("Prev Undelivered")]
        public int? PreviouslyUndelivered { get; set; }

        public int? Overdue { get; set; }

        [DisplayName("Depot")]
        public int? StoredAtDepot { get; set; }

        [DisplayName("Overdue By Agent")]
        public int? AgentOverdue { get; set; }

        public int? Agent { get; set; }

        public int? Retained { get; set; }

        public int? Bookings { get; set; }

        public int? AirFreight { get; set; }

        [DisplayName("Waybill Issues")]
        public int? WaybillIssues { get; set; }

        [DisplayName("Outstanding POD")]
        public int? OSPODNormal { get; set; }

        [DisplayName("Outstanding POD By Agent")]
        public int? OSPODAgent { get; set; }

        [DisplayName("Delivery Query")]
        public int? DelQuery { get; set; }

        [DisplayName("Chain Store")]
        public int? ChainStore { get; set; }

        [DisplayName("Load Variance")]
        public int? LoadVariance { get; set; }

        [DisplayName("Awaiting Delivery")]
        public int? AwaitingDel { get; set; }

        public int? Suspended { get; set; }

        public int? Tracers { get; set; }

        public int? Endorsements { get; set; }

        public int? COD { get; set; }

        [DisplayName("Failed")]
        public int Failed { get; set; }

        [DisplayName("Delivered")]
        public int Delivered { get; set; }

        [DisplayName("DueToday")]
        public int DueToday { get; set; }
        
        [DisplayName("Name")]
        public string ZoneController { get; set; }

        [DisplayName("Total Outstanding POD")]
        public int? TotalOSPOD { get; set; }
    }
}