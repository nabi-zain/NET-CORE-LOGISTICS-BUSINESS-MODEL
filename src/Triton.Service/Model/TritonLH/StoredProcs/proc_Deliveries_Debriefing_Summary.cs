using System.ComponentModel;
namespace Triton.Model.TritonLH.StoredProcs
{
    public class proc_Deliveries_Debriefing_Summary
    {
        #region Properties

        [DisplayName("Actual Arrival")]
        public int ActualArrivalDateTime { get; set; }

        [DisplayName("Actual Departure")]
        public int ActualDepartureDateTime { get; set; }

        [DisplayName("Customer Order No")]
        public int CustomerOrderNo { get; set; }

        [DisplayName("Month")]
        public int DeliveryMonth { get; set; }

        [DisplayName("Delivery Note")]
        public int DeliveryNoteNo { get; set; }

        [DisplayName("Year")]
        public int DeliveryYear { get; set; }

        [DisplayName("End ODO")]
        public int EndODO { get; set; }

        [DisplayName("Start ODO")]
        public int StartODO { get; set; }

        #endregion Properties
    }
}