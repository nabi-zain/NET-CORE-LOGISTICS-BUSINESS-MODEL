using System;

namespace Triton.Model.TritonLH.StoredProcs
{
    public class proc_Deliveries_By_Driver_Select
    {
        public int EmployeeID { get; set; }
        public string LeaveDisplayName { get; set; }
        public DateTime ScheduledDate { get; set; }
        public int Scheduled { get; set; }
        public int DeliveryID { get; set; }
        public string LeaveType { get; set; }
    }
}
