using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonStaging.StoredProcs
{
    [Table("proc_FMOEndorsements_Signature_Select")]
    public class proc_FMOEndorsements_Signature_Select
    {
        [DisplayName("FMO EndorsmentID")]
        public Int64 FMOEndorsementID { get; set; }

        [DisplayName("Endorsment ID")]
        public string Endorsement_Id { get; set; }

        [DisplayName("Exception Type ID")]
        public int Exception_Type_Id { get; set; }

        [DisplayName("Endorser Name")]
        public string Endorser_Name { get; set; }

        [DisplayName("Signature")]
        public byte[] Signature { get; set; }

        [DisplayName("Signature Image Location")]
        public string Signature_Image_Location { get; set; }

        [DisplayName("Signature Download Date")]
        public DateTime? Signature_Download_Date { get; set; }

        [DisplayName("Comments")]
        public string Comments { get; set; }

        [DisplayName("Region ID")]
        public int Resgion_Id { get; set; }

        [DisplayName("Route Id")]
        public int Route_Id { get; set; }

        [DisplayName("Signature Image Fullpath")]
        public string Signature_Image_FullPath { get; set; }

        [DisplayName("Waybill ID")]
        public Int64 WaybillID { get; set; }
    }
}
