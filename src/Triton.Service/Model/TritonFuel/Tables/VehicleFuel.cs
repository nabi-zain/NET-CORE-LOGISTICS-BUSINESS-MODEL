using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonFuel.Tables
{
    [Table("VehicleFuel")]
    public class VehicleFuel
    {
        [Dapper.Contrib.Extensions.Key]
        public long VehicleFuelID { get; set; }
        [Required] public string Registration { get; set; }
        public string DriverName { get; set; }
        [Required] public int FillTypeLCID { get; set; }
        public int? VehicleID { get; set; }
        public int? EmployeeID { get; set; }
        public string CurrentEmployeeCode { get; set; }
        [Required] public int BowserLCID { get; set; }
        public int? VehicleMileage { get; set; }
        [Required, Range(1, int.MaxValue)] public long OpeningPump { get; set; }
        [Required, Range(1, int.MaxValue)] public long ClosingPump { get; set; }
        [Required, Range(1, int.MaxValue)] public int CapturedLitres { get; set; }
        [Computed] public int CalculatedLitres { get; set; }
        public bool Variance { get; set; }
        [Required, Range(1, int.MaxValue)] public int BranchID { get; set; }
        [Required, DisplayName("Created By"), Range(1, int.MaxValue)] public int CreatedByUserID { get; set; }
       
        [Required, DisplayName("Created On")] public DateTime CreatedOn { get; set; } = DateTime.Now;
        [DisplayName("Deleted By"), Range(1, int.MaxValue)] public int? DeletedByUserID { get; set; }
        [DisplayName("Deleted On")] public DateTime? DeletedOn { get; set; }
        public string DeletedOnReason { get; set; }
    }
}
