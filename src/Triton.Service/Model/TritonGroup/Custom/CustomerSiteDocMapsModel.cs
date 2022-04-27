using System.Collections.Generic;
using Triton.Model.TritonGroup.Tables;

namespace Triton.Model.TritonGroup.Custom
{
    public class CustomerSiteDocMapsModel
    {
        public CustomerSiteDocMaps CustomerSiteDocMaps { get; set; }
        public CustomerSiteMaps CustomerSiteMaps { get; set; }
        public LookUpCodes DocumentCategory { get; set; }
    }

    public class CustomerSiteDocMapsEditModel
    {
        public CustomerSiteMapsModel CustomerSiteMapModel { get; set; }
        public List<DocumentCategoriesCheckBox> DocumentCategoriesCheckBoxes { get; set; }

        
    }

    public class DocumentCategoriesCheckBox
    {
        public LookUpCodes DocumentCategory { get; set; }
        public CustomerSiteDocMaps CustomerSiteDocMapResult { get; set; }
        public bool Checked { get; set; }

    }
}
