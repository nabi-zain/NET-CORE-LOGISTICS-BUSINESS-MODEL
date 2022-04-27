using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CRDRNoteReasonCodes")]
    public class CRDRNoteReasonCodes
    {
        [Key]
        public int CRDRNoteReasonCodeID { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
    }
}
