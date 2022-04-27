using System;
using Dapper.Contrib.Extensions;
namespace Triton.Model.LeaveManagement.Tables
{
    [Table("recExistingPositions")]
    public class recExistingPositions
    {
        [Key]
        public int extCodeId { get; set; }
        public int UserID { get; set; }
        public int orgID { get; set; }
        public int trmID { get; set; }
        public string extReferenceNo { get; set; }
        public string extMotivation { get; set; }
        public string extShiftDetails { get; set; }
        public string extAdditionalInfo { get; set; }
        public string extSalary { get; set; }
        public string extStatus { get; set; }
        public bool extProcessed { get; set; }
        public bool extCancelled { get; set; }
        public DateTime extEffectiveDate { get; set; }
        public DateTime? extAdvertExpiryDate { get; set; }
        public bool extItAcknowledge { get; set; }
        public string extType { get; set; }
        public bool extSqlProcessed { get; set; }
        public int extDecommOrgID { get; set; }
        public bool extFailed { get; set; }
        public string extFailedReason { get; set; }
        public string extFailedNotes { get; set; }
        public string extFailedStage { get; set; }
        public DateTime? extFailedDate { get; set; }
        public bool extActive { get; set; }
        public DateTime extTimeDateStamp { get; set; }
        public bool extInductionComplete { get; set; }
    }
}
