using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonStaging.Tables
{
    [Table("FMOEndorsements")]
    public class FMOEndorsements
    {
        [Dapper.Contrib.Extensions.Key, Required]
        public long FMOEndorsementID { get; set; }
        public string Endorsement_Id { get; set; }
        public int? Exception_Type_Id { get; set; }
        public string Endorser_Name { get; set; }
        public byte[] Signature { get; set; }
        public string Signature_Image_Location { get; set; }
        public DateTime? Signature_Download_Date { get; set; }
        public string Comments { get; set; }
        public int? Region_Id { get; set; }
        public int? Route_Id { get; set; }
        public string Signature_Image_FullPath { get; set; }
        public long? WaybillID { get; set; }
    }
}