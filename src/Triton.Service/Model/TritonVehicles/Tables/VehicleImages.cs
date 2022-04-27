using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonVehicles.Tables
{
    [Table("VehicleImages")]
    public class VehicleImages
    {
        [Required]
        [Dapper.Contrib.Extensions.Key]
        public int VehicleImageID { get; set; }

        public byte[] FileData { get; set; }
        public int? VehicleID { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public long? Length { get; set; }
        public DateTime? TimeUploaded { get; set; }
        public int? UserUploadedID { get; set; }
        public string ImageNote { get; set; }
        public int? VehicleImageCategoryID { get; set; }
    }
}