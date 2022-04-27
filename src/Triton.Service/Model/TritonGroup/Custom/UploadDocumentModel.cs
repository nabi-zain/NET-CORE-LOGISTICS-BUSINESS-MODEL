using System.Collections.Generic;
using Triton.Model.CRM.Tables;

namespace Triton.Service.Model.TritonGroup.Custom
{
    public class UploadDocumentModel
    {
        public IncreaseDocuments IncreaseDocuments { get; set; }
        public List<DocumentCategorys> DocumentCategorys { get; set; }
        public int DocumentCategoryID { get; set; }
        public string ErrorMessage { get; set; }
    }
}
