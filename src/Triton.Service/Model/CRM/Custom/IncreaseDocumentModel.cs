using System;

namespace Triton.Service.Model.CRM.Custom
{
    public class IncreaseDocumentModel
    {
        public int DocumentID { get; set; }
        public int AnalysisID { get; set; }
        public string ImgName { get; set; }
        public byte[] ImgData { get; set; }
        public DateTime DateUploaded { get; set; }
        public string Description { get; set; }
        public string WorkflowName { get; set; }
        public string ImgContentType { get; set; }
        public int DocumentCategoryID { get; set; }
    }
}
