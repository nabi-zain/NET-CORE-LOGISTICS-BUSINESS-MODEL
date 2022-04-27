namespace Triton.Model.CRM.Custom
{
    public class CreditNoteUploadModel
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public string CreditSheetName { get; set; }
        public string CreditSheetColumns { get; set; }
        public string DebitSheetName { get; set; }
        public string DebitSheetColumns { get; set; }
        public string BadSheetName { get; set; }
        public string BadSheetColumns { get; set; }
        public string FilePath { get; set; }
        public int UserID { get; set; }
    }
}
