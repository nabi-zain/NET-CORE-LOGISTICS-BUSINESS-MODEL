using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("DebitNotes")]
    public class DebitNotes
    {
        [Key]
        public long DebitNoteID { get; set; }
        public int CUstomerID { get; set; }
        public string WaybillNumber { get; set; }
        public decimal AmountEx { get; set; }
        public string DebitNoteRef { get; set; }
        public int CRDRNoteReasonCodeID { get; set; }
        public string ReMarks { get; set; }
        public int FiancialMonth { get; set; }
        public int FiancialYear { get; set; }
    }
}
