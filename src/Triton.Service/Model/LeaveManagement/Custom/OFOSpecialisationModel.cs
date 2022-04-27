using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.LeaveManagement.Custom
{
    public class OFOSpecialisationModel
    {
        public int OFOSpecializationID { get; set; }
        public int OFOCodeID { get; set; }
        public string OFOCode { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public string CreatedBy { get; set; }
        public string OFOCodeDescription { get; set; }
    }
}
