using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Triton.Service.Model.TritonFleetManagement.Custom
{
    public class CustomerDocumentRepositoryModel
    {
        public int DocumentRepositoryID { get; set; }
        public string ImgName { get; set; }
        public byte[] ImgData { get; set; }
        public string ImgContentType { get; set; }
        public int ImgLength { get; set; }
        public string DocumentSize { get; set; }
        public string ImgDataStr { get; set; }
        public FileInfo fileExtension { get; set; }
        public int customerID { get; set; }
        public int DeletedByUserID { get; set; }
        public int CreatedByUserID { get; set; }
        public int DocumentCategoryLCID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
