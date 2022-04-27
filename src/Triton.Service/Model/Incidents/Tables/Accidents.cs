using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Incidents.Tables
{
    [Table("Accidents")]

    public class Accidents
    {
        [Dapper.Contrib.Extensions.Key]

        public int AccidentID { get; set; }
        public string AccidentCaseNo { get; set; }
        public bool NotificationEnabled { get; set; }
        public DateTime AccidentDateg { get; set; }
        public bool HiredVehicle { get; set; }
        public string HiredVRegistration { get; set; }
        public string HiredVMakeModel { get; set; }
        public int HiredVSupplier { get; set; }
        public string HiredVDetails { get; set; }
        public int BranchID { get; set; }
        public bool HiredDriver { get; set; }
        public int HiredFrom { get; set; }
        public int DriverID { get; set; }
        public string DriverName { get; set; }
        public int DriverCellNo { get; set; }
        public DateTime PDPExpiryDate { get; set; }
        public DateTime LicenceExpiryDate { get; set; }
        public int AssistantID { get; set; }
        public string EmployeeDescription { get; set; }
        public bool EmployeeInjuries { get; set; }
        public string EmployeeInjuriesDetails { get; set; }
        public string AccidentLocation { get; set; }
        public string Liable { get; set; }
        public string Name3P { get; set; }
        public string ContactNo3P { get; set; }
        public string IDNumber3P { get; set; }
        public string DriverLicenceNumber3P { get; set; }
        public string VehicleReg3P { get; set; }
        public string MakeModel3P { get; set; }
        public string DamageDetails3P { get; set; }
        public bool Injuries3P { get; set; }
        public string InjuryDetails3P { get; set; }
        public bool Incident { get; set; }
        public bool Saved { get; set; }
        public long UserIDBasic { get; set; }
        public DateTime DateCapturedBasic { get; set; }
        public int VehicleMileage { get; set; }
        public string SAPSCase { get; set; }
        public string PoliceStation { get; set; }
        public string Responsible { get; set; }
        public bool Hearing { get; set; }
        public DateTime HearingDate { get; set; }
        public string DamagePaying { get; set; }
        public bool PhotosTaken { get; set; }
        public string PhotosNotTakenReason { get; set; }
        public int SelectedQuoteID { get; set; }
        public long UserIDAdvanced { get; set; }
        public DateTime DateCapturedAdvanced { get; set; }
        public string ClaimNo { get; set; }
        public long UserIDClaimNo { get; set; }
        public DateTime DateCapturedClaimNo { get; set; }
        public decimal ExcessValue { get; set; }
        public bool AssessorAppointed { get; set; }
        public string AssessorName { get; set; }
        public DateTime AssessorAppointment { get; set; }
        public long UserIDExcess { get; set; }
        public DateTime DateCapturedExcess { get; set; }
        public DateTime DateOffRoadFrom { get; set; }
        public DateTime DateOffRoadTo { get; set; }
        public  bool VehicleHireRequired { get; set; }
        public string VehicleHirePONumber { get; set; }
        public long UserIDClaimApproved { get; set; }
        public DateTime DateCapturedClimApproved { get; set; }
        public bool PoCreateNew { get; set; }
        public bool POExists { get; set; }
        public string PONumber1 { get; set; }
        public string PONumber2 { get; set; }
        public string PONumber3 { get; set; }
        public string PONumber4 { get; set; }
        public string PONumber5 { get; set; }
        public long POUserID { get; set; }
        public DateTime PODateCaptured { get; set; }
        public decimal FinalInvAmount { get; set; }
        public decimal TowingCost { get; set; }
        public decimal AssessorCost { get; set; }
        public decimal InvestigatorCost { get; set; }
        public decimal OtherCost { get; set; }
        public string OtherCostDetails { get; set; }
        public DateTime DateCapturedInspection { get; set; }
        public long UserIDInspection { get; set; }
        public  int DrivecamID { get; set; }


    }
}
