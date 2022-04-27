using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonOps.Tables
{
    [Table("VehicleBags")]
    public class VehicleBags
    {
        [Dapper.Contrib.Extensions.Key]
        public int BagID { get; set; }
        [DisplayName("Bag Number")]
        public string BagNumber { get; set; }
        public int CreatedByUserID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedOn { get; set; }
        public int DeletedByUserID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime DeletedOn { get; set; }
    }
}
