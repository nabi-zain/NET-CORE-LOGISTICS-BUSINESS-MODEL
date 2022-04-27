using System;

namespace Triton.Model.TritonLH.StoredProcs
{
    public class proc_DeliveryDelay_App_Select
    {
        public long LookUpCodeID { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public int LookupcodeCategoryID { get; set; }
        public int Sequence { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string FAIconString { get; set; }
        public string AdditionalField1Name { get; set; }
        public string AdditionalField1Value { get; set; }
        public int DeliveryDelayID { get; set; }
        public long DeliveryID { get; set; }
        public int DelayLCID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
