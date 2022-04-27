using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("LeadImages")]
    public class LeadImages
    {
        [Key]
        public int LeadImageID { get; set; }
        public byte[] FileData { get; set; }
        public int? LeadID { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public  long? Length { get; set; }
        public DateTime? TimeUploaded { get; set; }
        public int? UserUploadedID { get; set; }
    }
}
