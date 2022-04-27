using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonGroup.Tables;
using Triton.Model.TritonLH.StoredProcs;
using Triton.Model.TritonLH.Tables;
using Triton.Model.TritonLH.Views;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonGroup.Custom
{
    public class LookUpCodesModel
    {
        public List<LookUpCodes> ListLookUpCodes { get; set; }

        public LookUpCodes LookUpCodes { get; set; }

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
        public LookupCodeCategories LookupCodeCategories { get; set; }
        public LookUpCodeCategorySystemMaps LookUpCodeCategorySystemMaps { get; set; }

        
    }

    public class LCCodesAndCategoryModel
    {
        public int LookupCodeCategoryID { get; set; }
        public string Category { get; set; }
        public int Total { get; set; }

    }

    public class LookUpCodeSearchModel
    {
        public List<LookUpCodesModel> LookUpCodesModels { get; set; }
        public List<Systems> Systemses { get; set; }
        public List<LookupCodeCategories> LookupCodeCategorieses { get; set; }
    }

    public class LookUpCodeEditModel
    {
        public LookUpCodesModel LookUpCodesModel { get; set; }
        public LookUpCodes LookUpCodes { get; set; }
        public LookupCodeCategories LookupCodeCategories { get; set; }
        public LookUpCodeCategorySystemMaps LookUpCodeCategorySystemMaps { get; set; }
        public Systems Systems { get; set; }
        public List<LookupCodeCategories> LookupCodeCategorieses { get; set; }
        public List<LookUpCodeCategorySystemMaps> LookUpCodeCategorySystemMapses { get; set; }

    }


}
