using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    [Table("Collections")]
    public class Collections
    {
        [Key]
        public int CollectionID { get; set; }
        public string CollectionNo { get; set; }
        public DateTime CollectionSheetDate { get; set; }
        public string CollectionRoute { get; set; }
        public string CollectionVechileRegistration { get; set; }
        public byte UsedMobile { get; set; }
    }
}
