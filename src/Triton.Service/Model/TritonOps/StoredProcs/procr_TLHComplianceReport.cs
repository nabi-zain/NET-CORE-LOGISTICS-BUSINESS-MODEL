using System;
using System.ComponentModel;

namespace Triton.Model.TritonOps.StoredProcs
{
    public class procr_TLHComplianceReport
    {
        public Int64 CCLID { get; set; }

        public string CurrentEmployeeCode { get; set; }

        public string LeaveDisplayName { get; set; }

        public string EmployeeAlias { get; set; }

        public int EmployeeID { get; set; }

        public string Registration { get; set; }

        public string VehicleType { get; set; }

        public string BranchAlias { get; set; }

        public string Division { get; set; }

        public int BranchID { get; set; }

        [DisplayName("Routes")]
        public string Routes { get; set; }

        public DateTime RouteDate { get; set; }

        public int SecondsLateDeparting { get; set; }

        public string DepartureStatus { get; set; }

        public string DepartureStatusOrder { get; set; }

        public string ComplianceStatus { get; set; }

        [DisplayName("Expected Dep Time")]
        public DateTime ExpectedDepartureDateTime1 { get; set; }

        public TimeSpan ExpectedDepartureTime1 { get; set; }

        public TimeSpan DepartureTime1 { get; set; }

        [DisplayName("Dep Date/Time")]
        public DateTime DepartureDateTime1 { get; set; }

        public DateTime ArrivalDateTime1 { get; set; }

        public DateTime DepartureDateTime2 { get; set; }

        public DateTime ArrivalDateTime2 { get; set; }

        public string SubContractorNo { get; set; }

        public int CCLRouteID { get; set; }

        public int DocumentRepositoryID { get; set; }

        public int SupplierID { get; set; }

        public string SupplierName { get; set; }

        public bool Debriefed { get; set; }

        public int DebriefedBy { get; set; }

        public DateTime DebriefedOn { get; set; }

        public int TrailerLookUpCodeID { get; set; }

        public int CCLRouteDailyValidationID { get; set; }

        public DateTime DeletedOn { get; set; }

        public int DeletedByUserID { get; set; }

        public bool FTL { get; set; }

        public string Comment { get; set; }

        public string Company { get; set; }

        public string OriginatingBranch { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int CustomerID { get; set; }

        public string AccountCode { get; set; }

        public string CustomerName { get; set; }

        //public Int64? WaybillID { get; set; }

        //public string WaybillNo { get; set; }
    }
}