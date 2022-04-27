using System.Collections.Generic;
using Triton.Model.LeaveManagement.Tables;
using Triton.Service.Model.TritonFleetManagement.StoredProcs;
using Triton.Service.Model.TritonFleetManagement.Tables;

namespace Triton.Service.Model.TritonFleetManagement.Custom
{
    public class BookingsModel
    {
        public Bookings Bookings { get; set; }
        public List<CustomersModels> Customers { get; set; }
        public List<VehiclesModel> Vehicles { get; set; }
        public CustomersModels Customer { get; set; }
        public VehiclesModel Vehicle { get; set; }
        public LookupCodeModel LookupCodeModel { get; set; }
        public LookupCodeModel LookupCodeVehicleClass { get; set; }
        public List<LookupCodeModel> BookingReasons { get; set; }
        public List<LookupCodeModel> MileAgeOrHour { get; set; }
        public List<LookupCodeModel> ServiceCategoryTypes { get; set; }
        public List<LookupCodeModel> Quotations { get; set; }
        public List<LookupCodeModel> MechanicTypes { get; set; }
        public BookingReason BookingReason { get; set; }
        public List<BookingReason> BookingsReasons { get; set; }
        public int SelectedBookingReasons { get; set; }
        public int SelectedCustomer { get; set; }
        public int SelectedVehicles { get; set; }
        public int? SelectedMileAge { get; set; }
        public int? SelectedHour { get; set; }
        public int SelectedMileAgeOrHour { get; set; }
        public int SelectedQuotations { get; set; }
        public string ErrorMessage { get; set; }
        public string BookingReasonLCID { get; set; }
        public string DeleteBookingReasonLCID { get; set; }
        public string DeletedPartReasonLCID { get; set; }
        public List<BranchesModel> Branches { get; set; }
        public int SelectedBranch { get; set; }
        public BranchesModel Branch { get; set; }
        public List<Employees> MechanicalEmployees { get; set; }
        public int ExistingBookingsID { get; set; }
        public string BookingExistMessage { get; set; }
        public List<LookupCodeModel> LookupCodesPerCategory { get; set; }
        public string PartReasonLCID { get; set; }
        public string LabourReasonLCID { get; set; }
        public string ConsumableReasonLCID { get; set; }
        public string TyreReasonLCID { get; set; }
        public List<LookupCodeModel> Parts { get; set; }
        public OutworksCommission OutworksCommission { get; set; }
        public List<PartReason> PartReasons { get; set; }
        public List<PartReason> PartsList { get; set; }
        public List<LabourReason> LabourList { get; set; }
        public List<ConsumableReason> ConsumablesList { get; set; }
        public List<TyreReason> TyresList { get; set; }
    }
}
