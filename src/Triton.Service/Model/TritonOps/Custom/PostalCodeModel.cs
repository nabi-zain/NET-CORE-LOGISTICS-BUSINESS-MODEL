using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Model.TritonExpress.Tables;
using Triton.Model.TritonOps.Views;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonOps.Custom
{
    public class PostalCodeModel
    {
        public vw_PostalCodeSearch vw_PostalCodeSearch { get; set; }

        public PostalCodes PostalCodes { get; set; }

        [DisplayName("Collection Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime? CollectionDate { get; set; }

        public List<Customers> Customers { get; set; }

        public List<TransportTypes> TransportTypes { get; set; }

        public int CustomerName { get; set; }

        public int TransportType { get; set; }

        public string SenderPostName { get; set; }

        public string ReceiverPostName { get; set; }

        public int SenderID { get; set; }

        public int ReceiverID { get; set; }

        [DisplayName("Sender Post Code")]
        public string SenderPostCode { get; set; }

        [DisplayName("Receiver Post Code")]
        public string ReceiverPostCode { get; set; }

        [DisplayName("From Branch")]
        public string FromBranch { get; set; }

        [DisplayName("To Branch")]
        public string ToBranch { get; set; }

        [DisplayName("Expected Delivery Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? ExpectedDeliveryDate { get; set; }

        [DisplayName("Expected Delivery Time")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? ExpectedDeliveryTime { get; set; }

        [DisplayName("Name Of Day")]
        public string NameOfDay { get; set; }

        [DisplayName("Number of Days from Collection Date")]
        public int NumberOfDaysFromCollectionDate { get; set; }

        [DisplayName("From Rate Area")]
        public string FromRateArea { get; set; }

        [DisplayName("To Rate Area")]
        public string ToRateArea { get; set; }

    }
}
