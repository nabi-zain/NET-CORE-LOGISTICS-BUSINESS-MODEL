using System;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("WaybillQuery")]
    public class WaybillQuery
    {
        [Dapper.Contrib.Extensions.Key]
        public long WaybillQueryID { get; set; }
        public long WaybillID { get; set; }
        public int UserID { get; set; }
        public int QueryStatusLCID { get; set; }
        public string Query { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM/dd}")]
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM/dd}")]
        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public string Resolution { get; set; }

    }
}
