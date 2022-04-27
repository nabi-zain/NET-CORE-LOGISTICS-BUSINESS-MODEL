using System.ComponentModel;

namespace Triton.Model.CRM.StoredProcs
{
    public class proc_Waybills_ServiceType_Count_Select
    {
        [DisplayName("Transport Type")]
        public string TransportType { get; set; }

        [DisplayName("Due Today")]
        public int DueToday { get; set; }

        [DisplayName("O/S Due Today")]
        public int OSDueToday { get; set; }
    }
}
