using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.StoredProcs
{
    public class proc_ExpectedDeliveries_Totals_Select
    {
        [DisplayName("Previously Undelivered")]
        public int PreviouslyUndelivered { get; set; }

        [DisplayName("Overdue")]
        public int Overdue { get; set; }

        [DisplayName("Depot")]
        public int StoredAtDepot { get; set; }

        [DisplayName("Agent Overdue")]
        public int AgentOverdue { get; set; }

        [DisplayName("Failed")]
        public int Failed { get; set; }

        [DisplayName("Agent")]
        public int Agent { get; set; }

        [DisplayName("Retained")]
        public int Retained { get; set; }

        [DisplayName("Bookings")]
        public int Bookings { get; set; }

        [DisplayName("Air Freight")]
        public int AirFreight { get; set; }

        [DisplayName("Waybill Issues")]
        public int WaybillIssues { get; set; }

        [DisplayName("OS POD Normal")]
        public int OSPODNormal { get; set; }

        [DisplayName("OS POD Agent")]
        public int OSPODAgent { get; set; }

        [DisplayName("Delivery Query")]
        public int DelQuery { get; set; }

        [DisplayName("Chain Store")]
        public int ChainStore { get; set; }

        [DisplayName("Load Variance")]
        public int LoadVariance { get; set; }

        [DisplayName("Awaiting Delivery")]
        public int AwaitingDel { get; set; }

        [DisplayName("Suspended")]
        public int Suspended { get; set; }

        [DisplayName("Tracers")]
        public int Tracers { get; set; }

        [DisplayName("Endorsements")]
        public int Endorsements { get; set; }

        [DisplayName("COD")]
        public int COD { get; set; }

        [DisplayName("Total OS POD")]
        public int TotalOSPOD { get; set; }
    }
}
