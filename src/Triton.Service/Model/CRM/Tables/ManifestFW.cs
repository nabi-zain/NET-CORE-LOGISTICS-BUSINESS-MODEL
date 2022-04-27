using System;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("ManifestFW")]
    public class ManifestFW
    {
        [Key]
        public long ManifestFWID { get; set; }
        public string ManifestNo { get; set; }
        public DateTime Manifestdate { get; set; }
        public string Frombranch { get; set; }
        public string Tobranch { get; set; }
        public int? FromBranchID { get; set; }
        public int? ToBranchID { get; set; }
        public string Driver { get; set; }
        public string Vehicle { get; set; }

        public string Subcontactorname { get; set; }
        public string Docno { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID{ get; set; }
    }
}
