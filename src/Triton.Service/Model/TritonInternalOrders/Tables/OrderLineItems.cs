using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonInternalOrders.Tables
{
    [Table("OrderLineItems")]
    public class OrderLineItems
    {
        [Dapper.Contrib.Extensions.Key]
        public long OrderLineItemID { get; set; }
        public long OrderID { get; set; }
        public long CategoryLookupID { get; set; }
        public long GenderTypeLookupID { get; set; }
        public long ItemTypeLookupID { get; set; }
        public long SizeLookupID { get; set; }
        public long Quantity { get; set; }
        public bool Procurement { get; set; }
        [DisplayName("Price")]
        [Write(false)]
        [Computed]
        public decimal Price { get; set; }
        public string Description { get; set; }
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
        [DisplayName("Enployee Code")]
        [Write(false)]
        [Computed]
        public string CurrentEmployeeCode { get; set; }

        [DisplayName("Department")]
        [Write(false)]
        [Computed]
        public string Department { get; set; }
        [DisplayName("Name")]
        [Write(false)]
        [Computed]
        public string Name { get; set; }

        [DisplayName("Branch")]
        [Write(false)]
        [Computed]
        public string BranchFullName { get; set; }

        [DisplayName("BranchName")]
        [Write(false)]
        [Computed]
        public string BranchName { get; set; }

    }
}
