using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = Dapper.Contrib.Extensions.KeyAttribute;

namespace Triton.Service.Model.TritonFleetManagement.Tables
{
    [Table("Bookings")]
    public class Bookings
    {
        [Key]
        public int BookingsID { get; set; }

        [Required]
        public int CustomerID { get; set; }

        [Required]
        public int VehicleID { get; set; }

        [Required]
        public int ServiceCategoryTypesLCID { get; set; }

        [Required]
        public int MileAgeOrHourLCID { get; set; }

        [Required]
        public int CreatedByUserID { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public string OrderNumber { get; set; }

        [Required]
        public int BranchID { get; set; }

        [Required]
        public int QuotationsLCID { get; set; }
        public int? MileAge { get; set; }
        public int? Hour { get; set; }
        public bool Authorisation { get; set; }
        public string Notes { get; set; }
        public DateTime? EstimatedArrival { get; set; }
        public DateTime? ActualArrival { get; set; }
        [Required]
        public int StatusLCID { get; set; }
        public bool isJobCard { get; set; }
        public int? MechanicEmployeeID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public bool OutworksCommission { get; set; }
    }
}
