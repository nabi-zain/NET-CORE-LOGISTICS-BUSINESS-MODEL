using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonInternalOrders.Tables
{
    [Table("ItemPrices")]
    public class ItemPrices
    {
        [Dapper.Contrib.Extensions.Key]
        public int ItemPriceID { get; set; }
        public int ItemLookUpCodeID { get; set; }

        [DisplayName("Item")]
        [Write(false)]
        [Computed]
        public string ItemName { get; set; }
       
        public decimal? Price { get; set; }
        public DateTime PriceCreatedOn { get; set; }
        public int PriceCreatedBy { get; set; }

        [DisplayName("Created By")]
        [Write(false)]
        [Computed]
        public string CreatedBy { get; set; }

    }
}
