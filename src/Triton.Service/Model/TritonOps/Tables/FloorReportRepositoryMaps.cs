using System;
using System.ComponentModel.DataAnnotations.Schema;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonOps.Tables
{
    [Dapper.Contrib.Extensions.Table("FloorReportRepositoryMaps")]
    public class FloorReportRepositoryMaps
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FloorReportRepositoryMapID { get; set; } // int, not null
        public int BranchID { get; set; } // int, not null
        public long DocumentRepositoryID { get; set; } // bigint, not null
        public int? DocumentTypeLCID { get; set; }
        public DateTime CreatedOn { get; set; } // datetime, not null
        public int CretedByUserID { get; set; } // int, not null
        public DateTime? DeletedOn { get; set; } // datetime, null
        public int? DeletedByUserID { get; set; } // int, null
    }

}
