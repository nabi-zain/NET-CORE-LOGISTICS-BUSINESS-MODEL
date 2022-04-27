using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.TritonFleetManagement.Custom
{
    public class LookupCodeModel
    {

        public long LookUpCodeID { get; set; }

        public string Name { get; set; }

        public string Detail { get; set; }

        public int LookupcodeCategoryID { get; set; }

        public int Sequence { get; set; }

        public int CreatedByUserID { get; set; }

        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public String FAIconString { get; set; }

        public string AdditionalField1Name { get; set; }
        public string AdditionalField1Value { get; set; }
        public string Category { get; set; }

        public List<LookupCodeModel> LookUpCodes { get; set; }

    }
}
