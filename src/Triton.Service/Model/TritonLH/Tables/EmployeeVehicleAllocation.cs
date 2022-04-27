using System;

namespace Triton.Model.TritonLH.Tables
{
    public class EmployeeVehicleAllocation
    {
        public int EmployeeVehicleAllocationID { get; set; }
        public int Employeeid { get; set; }
        public string HorseRegistration { get; set; }
        public string Trailer1Registration { get; set; }
        public string Trailer2Registration { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int CreatedByUserID { get; set; }
    }
}
