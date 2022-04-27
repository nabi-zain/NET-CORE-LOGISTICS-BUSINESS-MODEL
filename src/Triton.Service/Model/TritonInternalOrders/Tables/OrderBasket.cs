using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonInternalOrders.Tables
{
    [Table("OrderBasket")]
    public class OrderBasket
    {
        [Dapper.Contrib.Extensions.Key]
        public long OrderBasketID { get; set; }
        public long CategoryLookupID { get; set; }
        public long GenderTypeLookupID { get; set; }
        public long ItemTypeLookupID { get; set; }
        public long SizeLookupID { get; set; }
        public long Quantity { get; set; }
        public string Description { get; set; }
        public long CreatedByUserID { get; set; }
        public DateTime? CreatedOn { get; set; }

        [DisplayName("Price")]
        [Write(false)]
        [Computed]
        public decimal Price { get; set; }
        [DisplayName("Category")]
        [Write(false)]
        [Computed]
        public string Category { get; set; }

        [DisplayName("Gender")]
        [Write(false)]
        [Computed]
        public string Gender { get; set; }

        [DisplayName("Item")]
        [Write(false)]
        [Computed]
        public string Item { get; set; }

        [DisplayName("Size")]
        [Write(false)]
        [Computed]
        public string Size { get; set; }

        [DisplayName("Name")]
        [Write(false)]
        [Computed]
        public string Name { get; set; }

    }
}
