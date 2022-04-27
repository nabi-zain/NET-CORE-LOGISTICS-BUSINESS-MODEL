using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonInternalOrders.Tables
{
    [Table("ItemSizeLinks")]
    public class ItemSizeLinks
    {
        [Dapper.Contrib.Extensions.Key]
        public int ItemSizeLinkID { get; set; }
        public long ItemLookupCodeID { get; set; }
        public long SizeLookupCodeID { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        [DisplayName("Size")]
        [Write(false)]
        [Computed]
        public string SizeName { get; set; }
        [DisplayName("Item")]
        [Write(false)]
        [Computed]
        public string ItemName { get; set; }
        [DisplayName("Created By")]
        [Write(false)]
        [Computed]
        public string CreatedByName { get; set; }
    }
}
