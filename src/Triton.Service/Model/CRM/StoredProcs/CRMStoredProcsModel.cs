using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Triton.Model.CRM.Custom;
using Triton.Model.CRM.Tables;
using Triton.Model.LeaveManagement.Tables;

namespace Triton.Model.CRM.StoredProcs
{
    public class proc_Waybills_CSA_Dashboard_Select
    {
        public int CustomerID { get; set; }

        [DisplayName("Acc Code")]
        public string AccountCode { get; set; }

        [DisplayName("Customer")]
        public string CustomerName { get; set; }

        [DisplayName("Due Today")]
        public int DueToday { get; set; }

        public int Delivered { get; set; }
        public int Outstanding { get; set; }

        [DisplayName("Prev Not Del")]
        public int PreviouslyNotDel { get; set; }

        [DisplayName("On Hold")]
        public int OnHold { get; set; }
        public int Late { get; set; }

        [DisplayName("Late 10am")]
        public int Late10 { get; set; }

        [DisplayName("Late 12pm")]
        public int Late12 { get; set; }

        [DisplayName("Late 2pm")]
        public int Late14 { get; set; }

        [DisplayName("Late 3pm")]
        public int Late15 { get; set; }

        [DisplayName("Late 5pm")]
        public int Late17 { get; set; }

        [DisplayName("MisRoute")]
        public int MisRoute { get; set; }

        [DisplayName("Outlying due today")]
        public int OutlyingDueToday { get; set; }
    }

    public class proc_CSA_WaybillList_Select
    {
        public long WaybillID { get; set; }
        public string WaybillNo { get; set; }
        public int WaybillStatusID { get; set; }
        public string CustomerName { get; set; }
        public string FromRateArea { get; set; }
        public string ToRateArea { get; set; }
        public string ServiceLevel { get; set; }
        public string Route { get; set; }
        public string RouteName { get; set; }
        public string ShortDesc { get; set; }
        public DateTime WaybillDate { get; set; }
        public DateTime DelExpectedDateTimeStamp { get; set; }
        public string SiteCustomerName { get; set; }
        public string Comment { get; set; }
        public DateTime? PODDateTimeStamp { get; set; }
        public string FWCurrentBranch { get; set; }
        public int CustomerID { get; set; }
    }

    public class proc_DepotToDepotSearch
    {
        [DisplayName("Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime RequestDate { get; set; }
        [DisplayName("Reference")]
        public String DTDRequestRef { get; set; }
        [DisplayName("Status")]
        public String StatusName { get; set; }
        public String UserName { get; set; }
        [DisplayName("First Name")]
        public String FirstName { get; set; }
        [DisplayName("Last Name")]
        public String LastName { get; set; }
        public long DTDRequestID { get; set; }
        public int CustomerID { get; set; }
        [DisplayName("Acc Code")]
        public string AccountCode { get; set; }
        [DisplayName("Customer")]
        public string Name { get; set; }
        [DisplayName("From Depot")]
        public string FromBranch { get; set; }
        [DisplayName("To Depot")]
        public string ToBranch { get; set; }
        public string AdditionalField1Name { get; set; }
        public string AdditionalField1Value { get; set; }
        public long CreatedByUserID { get; set; }


    }

    public class proc_WaybillStickerGenerator
    {
        public int N { get; set; }
        public string FWDepotCode { get; set; }
        public string BayCode { get; set; }
        public string BayNo { get; set; }
        public string ParcelPrefix { get; set; }
        public string WaybillNo { get; set; }
        public int WaybillDate { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string PostalCode { get; set; }
        public string Description { get; set; }
        public int TotalQty { get; set; }
        public string ParcelRef { get; set; }
    }

    public class CustomerAssessment
    {
        public decimal SalesIncFuel { get; set; }
        public decimal SalesExFuel { get; set; }
        public decimal ExVat { get; set; }
        public int NoofWaybills { get; set; }
        public int NoOfParcels { get; set; }
        public decimal ActualTotal { get; set; }
        public decimal VolumetricTotal { get; set; }
        public decimal ChargableTotal { get; set; }
        public decimal TotalBilling { get; set; }
        public decimal AvgNoDeliveries { get; set; }
        public decimal AvgNoParcels { get; set; }
        public decimal Swat { get; set; }
        public decimal Compliance { get; set; }
        public decimal AvgDelMainCenterActual { get; set; }
        public decimal AvgDelMainCenterVolumetric { get; set; }
        public decimal AvgDelMainCenterChargeable { get; set; }
        public decimal AvgDelOutlyingCenterChargeable { get; set; }
        public decimal PercDelMainCenter { get; set; }
        public decimal PercDelOutCenter { get; set; }
        public decimal AvgInvValue { get; set; }
        public int AvgCentsperKG { get; set; }
        public int CustomerID { get; set; }
    }


    public class CreditNotePageModel
    {
        public WaybillCreditModel WaybillCreditModel { get; set; }
        public List<Employees> Employees { get; set; }
        public CRNoteTemp CRNoteTemp { get; set; }
        public List<TritonGroup.Tables.LookUpCodes> ReasonCodeList { get; set; }
    }

    public class proc_Rates_Matrix_Select
    {
        public string FromArea { get; set; }
        public string ToArea { get; set; }
        public string TransportType { get; set; }
        public decimal Rate { get; set; }
        public decimal MinValue { get; set; }
        public decimal MinKg { get; set; }
        public bool Special { get; set; }
        public bool isCrossBorder { get; set; }
        public int TransportTypeID { get; set; }
        public int FromRatesSiteID { get; set; }
        public int ToRatesSiteID { get; set; }
    }

    public class proc_Rates_Outlying_SlidingScale_Select
    {
        public int CustomerUniqueRateID { get; set; }
        public int FromRateSiteID { get; set; }
        public int ToRateSiteID { get; set; }
        public decimal QtyFrom { get; set; }
        public decimal QtyTo { get; set; }
        public int RateDirectionID { get; set; }
        public int FromRateAreaID { get; set; }
        public int ToRateAreaID { get; set; }
        public string FromShortCode { get; set; }
        public string ToShortCode { get; set; }
        public string FromArea { get; set; }
        public string ToArea { get; set; }
        public decimal T4UniqueRate { get; set; }
        public decimal T4Minumum { get; set; }
        public decimal T5UniqueRate { get; set; }
        public decimal T5Minumum { get; set; }
        public string CurrencySymbol { get; set; }
    }

    public class proc_Increase_Matrix_Select
    {
        public int ID { get; set; }
        public string WorkFlowStage { get; set; }
        public int WorkFlowStageID { get; set; }
        public int OrderBy { get; set; }
        public string Name { get; set; }
        public int Total { get; set; }      
    }

    public class proc_Rep_Customers_Dashboard_Select
    {
        public int CustomerID { get; set; }
        public string AccountCode { get; set; }
        public string CustomerName { get; set; }
        public string Visited { get; set; }
        public bool VisitedInd { get; set; }
        public string Branch { get; set; }
        public string RepCode { get; set; }
        public decimal AmountTraded { get; set; }
        public decimal FreightValue { get; set; }
        public decimal PreviousDay { get; set; }
        public decimal DailyAverage { get; set; }
        public decimal Forecast { get; set; }
        public int UserID { get; set; }
        public string RepName { get; set; }
    }
}
