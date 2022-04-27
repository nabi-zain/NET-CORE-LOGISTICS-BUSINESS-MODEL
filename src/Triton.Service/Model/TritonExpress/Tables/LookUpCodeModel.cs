using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
    [Table("LookUpCodes")]
    public class LookUpCodeModel
    {
        [Dapper.Contrib.Extensions.Key]
        public long LookupcodeID { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public long LookupcodeCategoryID { get; set; }
        public int Sequence { get; set; }
        public DateTime CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int DeletedByUserID { get; set; }
       public DateTime DeletedOn {get; set;}
    }
}


