using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerAnalysisResults")]
    public class CustomerAnalysisResultS
    {
        [Key] public int CustomerAnalysisResultID { get; set; }
        public int CustomerAnalysisID { get; set; }
        public string Recomendation { get; set; }
        public byte Overridden { get; set; }
        public int OverRateClass { get; set; }
        public int OverVolID { get; set; }

        public int OverMinKg { get; set; }

        public string OverDocFee { get; set; }

        public string OverFuelSurc { get; set; }
        public string Overlns { get; set; }
        public string OverDiscount { get; set; }
        public string OverIncrease { get; set; }
        public string OverRemoveUniques { get; set; }
        public string OverMinRands { get; set; }
        public string OverCentralPerc { get; set; }
        public string OverOutlyingPerc { get; set; }
 
}
}
