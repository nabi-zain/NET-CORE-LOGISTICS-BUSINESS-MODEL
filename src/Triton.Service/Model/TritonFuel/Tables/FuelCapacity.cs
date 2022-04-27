using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonFuel.Tables
{
    [Table("FuelCapacity")]
    public class FuelCapacity
    {
        [Dapper.Contrib.Extensions.Key] public long FuelCapacityID { get; set; }
        [Required] public long OpeningReading { get; set; }
        [Required] public long ClosingReading { get; set; }
        [Required, Range(1, int.MaxValue)] public int BranchID { get; set; }
        [Required, DisplayName("Created By"), Range(1, int.MaxValue)] public int CreatedByUserID { get; set; }
        [Required, DisplayName("Created On")] public DateTime CreatedOn { get; set; } = DateTime.Now;
        [DisplayName("Deleted By"), Range(1, int.MaxValue)] public int? DeletedByUserID { get; set; }
        [DisplayName("Deleted On")] public DateTime? DeletedOn { get; set; }
    }
}
