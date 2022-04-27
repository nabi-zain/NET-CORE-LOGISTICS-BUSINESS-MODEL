using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonOps.Tables
{
    [Table("CheckListDocuments")]
    public class CheckListDocuments
    {
        [Dapper.Contrib.Extensions.Key]
        public int CheckListDocID { get; set; }
        public string ImgName { get; set; }
        public byte[] ImgData { get; set; }
        public int ImgLength { get; set; }
        public string ImgContentType { get; set; }
        public int LookUpcodeID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int CheckListID { get; set; }


    }
}
