using Dapper.Contrib.Extensions;
using System;

namespace Triton.Service.Model.HRM.Tables
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeCode { get; set; }
        public string Initials { get; set; }
        public string FirstName { get; set; }
        public string MaidenName { get; set; }
        public string KnownName { get; set; }
        public string Surname { get; set; }
        public string IdentityNumber { get; set; }
        public int GenderLCID { get; set; }
        public int MaritalStatusLCID { get; set; }
        public int TitleLCID { get; set; }
        public int EmployeeTypeLCID { get; set; }
        public DateTime ? StartDate { get; set; }
        public DateTime ? TerminationDate { get; set; }
        public int ? UserID { get; set; }
        public int  RecruitmentID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime ? DeletedOn { get; set; }
        public int ? DeletedByUserID { get; set; }
    }
}
