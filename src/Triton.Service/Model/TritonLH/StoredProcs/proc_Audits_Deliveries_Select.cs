using System;
using System.ComponentModel;

namespace Triton.Model.TritonLH.StoredProcs
{
    public class proc_Audits_Deliveries_Select
    {
        [DisplayName("Type")]
        public string Type { get; set; }

        [DisplayName("Old Value")]
        public string OldValue { get; set; }

        [DisplayName("New Value")]
        public string NewValue { get; set; }

        [DisplayName("Created On")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("Created By")]
        public string CreatedBy { get; set; }

        [DisplayName("Desc")]
        public string TypeDesc { get; set; }

    }
}
