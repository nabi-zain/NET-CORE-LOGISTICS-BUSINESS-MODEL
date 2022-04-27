using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("recEmployees")]
    public class recEmployees
    {
        [Key]
        public int rempID { get; set; }
        public int UserID { get; set; }
        public int rempIdMap { get; set; }
        public string rempType { get; set; }
        public int EmployeeID { get; set; }
        public string rempEmployeeCode { get; set; }
        public string rempOldEmployeeCode { get; set; }
        public string rempEmployeeName { get; set; }
        public string rempEmployeeSurname { get; set; }
        public string rempSAID { get; set; }
        public bool rempLinked { get; set; }
        public bool rempNewEmployee { get; set; }
        public string rempTransferPromotion { get; set; }
        public string rempBand { get; set; }
        public string rempBandReason { get; set; }
        public DateTime? rempActualStartDate { get; set; }
        public string rempTaxNo { get; set; }
        public bool rempActive { get; set; }
        public DateTime? rempTimeDateStamp { get; set; }
        public string rempShift { get; set; }
        public int rempContractTerm { get; set; }
        public DateTime? rempContractEndDate { get; set; }
        public bool rempContractSqlProcessed { get; set; }
        public string rempAdAccount { get; set; }
        public int rempContractTermExtended { get; set; }
        public DateTime? rempContractExtendedDate { get; set; }
        public bool rempAddAsAdditional { get; set; }
        public string FreightWareUsername { get; set; }
    }
}
