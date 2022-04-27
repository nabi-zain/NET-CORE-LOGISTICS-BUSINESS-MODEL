using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.TritonFleetManagement.StoredProcs
{
    public class proc_Bookings_BookingReasons_Customers_Select
    {
        public string CreatedBy { get; set; }
        public int BookingsID { get; set; }
        public string OrderNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime EstimatedArrival { get; set; }
        public DateTime ActualArrival { get; set; }
        public string CustomerName { get; set; }
        public string RegistrationNumber { get; set; }
        public string BookingReasons { get; set; }
    }
}
