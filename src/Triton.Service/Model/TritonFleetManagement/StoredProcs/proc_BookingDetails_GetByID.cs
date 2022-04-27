using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.TritonFleetManagement.StoredProcs
{
    public class proc_BookingDetails_GetByID
    {
        public int BookingsID { get; set; }
        public int BookingsCustomerID { get; set; }
        public int VehicleID { get; set; }
        public int ServiceCategoryTypesLCID { get; set; }
        public int MileAgeOrHourLCID { get; set; }
        public int MileAge { get; set; }
        public int MileAgeHour { get; set; }
        public DateTime EstimatedArrival { get; set; }
        public DateTime ActualArrival { get; set; }
        public bool Authorisation { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime DeletedOn { get; set; }
        public int DeletedByUserID { get; set; }
        public int QuotationsLCID { get; set; }
        public int BranchID { get; set; }
        public string OrderNumber { get; set; }
        public bool isJobCard { get; set; }
        public int StatusLCID { get; set; }
        public int MechanicEmployeeID { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string RegistrationNumber { get; set; }
        public string Name { get; set; }
    }
}

