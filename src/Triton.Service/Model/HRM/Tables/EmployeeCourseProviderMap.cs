using Dapper.Contrib.Extensions;
using System;

namespace Triton.Service.Model.HRM.Tables
{
    [Table("EmployeeCourseProviderMap")]
    public class EmployeeCourseProviderMap
    {
        [Key]
        public int EmployeeCourseProviderMapID { get; set; }
        public int EmployeeId { get; set; }
        public int CourseLCID { get; set; }
        public int ProviderLCID { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal CostPerLearnerTraining { get; set; }
        public decimal CostPerLearnerCatering { get; set; }
        public decimal CostPerLearnerTravelFlightAccomodation { get; set; }
        public decimal CostPerLearnerOther { get; set; }
        public decimal TotalCost { get; set; }
        public decimal VATAmt { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompleteDate { get; set; }
        public DateTime? CertificateIssuedDate { get; set; }
        public int CreateByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
