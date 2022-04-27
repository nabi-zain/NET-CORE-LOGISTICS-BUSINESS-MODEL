using System;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonLH.Tables
{
    [Table("VehicleVerification")]
    public class VehicleVerification
    {
        [Dapper.Contrib.Extensions.Key] [Required] public int VehicleVerificationID { get; set; }

        [Required, Range(1, int.MaxValue)] public int CurrentVehicleID { get; set; }
        [Required, Range(1, int.MaxValue)] public int NewVehicleID { get; set; }
        [Range(1, int.MaxValue)] public int? CurrentTrailer1VehicleID { get; set; }
        [Range(1, int.MaxValue)] public int? NewTrailer1VehicleID { get; set; }
        [Range(1, int.MaxValue)] public int? CurrentTrailer2VehicleID { get; set; }
        [Range(1, int.MaxValue)] public int? NewTrailer2VehicleID { get; set; }
        [Required, Range(1, int.MaxValue)] public int StatusLCID { get; set; }
        [Required, Range(1, int.MaxValue)] public int CreatedByUserID { get; set; }
        [Required] public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
