using System.Collections.Generic;
using  Triton.Model.CRM.Tables;
using  Triton.Model.CRM.Views;
using  Triton.Model.TritonStaging.Tables;
using  Triton.Model.TritonOps.Tables;
using System;
using Triton.Service.Model.CRM.StoredProcs;

namespace  Triton.Model.CRM.Custom
{
    public class WaybillReceiverModel
    {
        public Waybills Waybills { get; set; }
        public WayBillStatuss WayBillStatuss { get; set; }
        public CustomerSiteMaps ReceiverCustomerSiteMaps { get; set; }
        public Sites ReceiverSites { get; set; }
        public CustomerSiteMaps SenderCustomerSiteMaps { get; set; }
        public Sites SenderSites { get; set; }
        public DeliveryManifestLineItems DeliveryManifestLineItems { get; set; }
        public SubContractors SubContractors { get; set; }
    }

    public class WayBillModel
    {
        public Waybills Waybills { get; set; }
        public Customers Customers { get; set; }
        public List<vwOpsWaybills> vwOpsWayBills { get; set; }
        public FMOEndorsements FmoEndorsements { get; set; }
        public WaybillOpsNotes WaybillOpsNotes { get; set; }
        public int WaybllID { get; set; }
        public int CustXRef { get; set; }
        public string WaybillReferences { get; set; }
        public List<proc_Waybills_ByMonthSelect> WaybillByMonthSelects { get; set; }
    }

    public class WayBillInfoModel
    {
        public Waybills Waybills { get; set; }
        public Customers Customers { get; set; }
        public List<WaybillTrackandTracesModel> WaybillTrackandTracesModel { get; set; }
        public List<WaybillOpsNotes> WaybillOpsNotes { get; set; }
        public List<CustomerSpecialArangements> CustomerSpecialArangements { get; set; }
        public List<WaybillSurchargeModel> WaybillSurchargeModel { get; set; }
        public Sites ReceiverSites { get; set; }
        public Sites SenderSites { get; set; }
        public FMOEndorsements FMOEndorsements { get; set; }
        public WayBillStatuss WayBillStatuss { get; set; }
        public TransportTypes TransportTypes { get; set; }
        public List<WaybillQuery> WaybillQuery { get; set; }
        public WaybillQueryMaster WaybillQueryMaster { get; set; }
    }

    public class WaybillCustomerModel
    {
        public string WaybillNo { get; set; }
        public string AcountCode { get; set; }
        public DateTime WaybillDate { get; set; }
        public string CustXRef { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public Decimal? DiscountValue { get; set; }
        public Decimal? FreightValue { get; set; }
        public string ReceiverCell { get; set; }
        public string ReceiverEmail { get; set; }
        public string ReceiverInstructions { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverAddress1 { get; set; }
        public string ReceiverAddress2 { get; set; }
        public string ReceiverAddress3 { get; set; }
        public string ReceiverSuburbCode { get; set; }
        public string ReceiverPostalCode { get; set; }
        public string ReceiverContact { get; set; }
        public string ReceiverFaxNo { get; set; }
        public string ReceiverTelNo { get; set; }
        public string SenderCell { get; set; }
        public string SenderEmail { get; set; }
        public string SenderInstructions { get; set; }
        public string SenderName { get; set; }
        public string SenderAddress1 { get; set; }
        public string SenderAddress2 { get; set; }
        public string SenderAddress3 { get; set; }
        public string SenderSuburbCode { get; set; }
        public string SenderPostalCode { get; set; }
        public string SenderContact { get; set; }
        public string SenderFaxNo { get; set; }
        public string SenderTelNo { get; set; }
        public string ServiceType { get; set; }
        public Decimal? TotalChargeUnits { get; set; }
        public Decimal? TotalMass { get; set; }
        public Decimal? TotalParcels { get; set; }
        public Decimal? TotalQty { get; set; }
        public Decimal? TotalValue { get; set; }
        public Decimal? TotalVolume { get; set; }
        public Decimal? Vat { get; set; }

    }
}
