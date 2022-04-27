using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using  Triton.Model.CRM.Tables;
using  Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.CRM.Custom
{
    public class WaybillFWCreateModel
    {
        public WaybillFW WaybillFW { get; set; }

        public List<Customers> Customers { get; set; }

        public List<Sites> SenderSite { get; set; }

        public List<Sites> ReceiverSite { get; set; }

        public List<TransportTypes> TransportTypes { get; set; }

        public List<Branches> Branches { get; set; }

        public int? SelectedTransportTypes { get; set; }

        public int? SelectedCustomerID { get; set; }

        public int? SelectedSenderSite { get; set; }

        public int? SelectedReceiverSite { get; set; }

        public ManifestFW ManifestFW { get; set; }

        public List<WaybillSearchModel> WaybillSearchModel { get; set; }
    }

    public class WaybillSearchModel
    {
        public WaybillFW WaybillFW { get; set; }

        public Customers Customers { get; set; }

        public TransportTypes TransportTypes { get; set; }
    }
     public class TritonWaybillSubmitModels:CustomerWaybillSubmitModels
    {
        [DisplayName("Customer")]
        public int? CustomerID { get; set; }
        public List<Customers> AllowedCustomerList { get; set; }
        public List<TransportTypes> TransportTypes { get; set; }
        public string LinesJson { get; set; }
        public string CreatorName { get; set; }
        public int CreatedByUserID { get; set; }
    }
    public class CustomerWaybillSubmitModels : TransportPriceSubmitModels
    {
        public string CustXRef { get; set; }
        [Required]
        public string SenderName { get; set; }
        public string SenderCode { get; set; }
        public string SenderAddress1 { get; set; }
        public string SenderAddress2 { get; set; }
        public string SenderAddress3 { get; set; }
        public string SenderContactName { get; set; }
        public string SenderContactCell { get; set; }
        public string SenderContactEmail { get; set; }
        
        [Required]
        public string ReceiverName { get; set; }
        public string ReceiverCode { get; set; }
        public string ReceiverAddress1 { get; set; }
        public string ReceiverAddress2 { get; set; }
        public string ReceiverAddress3 { get; set; }
        public string ReceiverContactName { get; set; }
        public string ReceiverContactCell { get; set; }
        public string ReceiverContactEmail { get; set; }
        //[Required]
        public string WaybillNo { get; set; }
        public string SenderInstructions { get; set; }
        public string ReceiverInstructions { get; set; }
    }

}
