using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.TritonOps.Tables
{
    [Table("PageLog")]
    public class PageLog
    {
        [Dapper.Contrib.Extensions.Key]
        public Int64 LogID { get; set; }

        public string PageName { get; set; }

        public int UserID { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}