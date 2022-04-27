using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonLH.Tables
{
    [Table("FinanceInvoiceDeliveryMaps")]
    public class FinanceInvoiceDeliveryMaps
    {
        [Dapper.Contrib.Extensions.Key]
        public int FinanceInvoiceDeliveryMapID { get; set; }

        public int FinanceInvoiceID { get; set; }

        [DisplayName("Delivery")]
        public int DeliveryID { get; set; }

      [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }" ,ApplyFormatInEditMode=true)]
        [DisplayName("Created On")]
        public DateTime? CreatedOn { get; set; }


        [DisplayName("Created By")]
        public int? CreatedByUserID { get; set; }


        [DisplayName("Deleted On")]
      [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }" ,ApplyFormatInEditMode=true)]
        public DateTime? DeletedOn { get; set; }

        [DisplayName("Deleted By")]
        public int? DeletedByUserID { get; set; }

        [DisplayName("Comment")] 
        public string DeletedComment { get; set; }

    }
}
