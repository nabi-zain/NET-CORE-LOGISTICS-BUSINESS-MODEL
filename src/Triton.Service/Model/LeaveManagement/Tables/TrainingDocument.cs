using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("TrainingDocument")]
    public class TrainingDocument
    {
        [Key]
        public int TrainingDocumentID { get; set; }
        public long UserID { get; set; }
        public int TrainingCategoryID { get; set; }
        public string Description { get; set; }
        public string ContentType { get; set; }
        public string Length { get; set; }
        public byte[] DocumentFile { get; set; }
        public bool Active { get; set; }
        public DateTime TimeDateStamp { get; set; }
    }
}
