using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triton.Service.Model.TritonFleetManagement.Custom
{
    public class DocumentVehicleModel
    {
        public int DocumentRepositoryID { get; set; }
        public string ImgName { get; set; }
        public byte[] ImgData { get; set; }
        public string ImgDataStr { get; set; }
        public string ImgContentType { get; set; }
        public int ImgLength { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int VehicleDocumentID { get; set; }
        public int BookingID { get; set; }
    }
}
