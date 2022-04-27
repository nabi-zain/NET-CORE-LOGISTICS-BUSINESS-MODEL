using System;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("WaybillQueryMaster")]
    public class WaybillQueryMaster
    {
        [Key]
        public long WaybillQueryMasterID { get; set; }
        public long WaybillID { get; set; }
        public int QueryStatusLCID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
