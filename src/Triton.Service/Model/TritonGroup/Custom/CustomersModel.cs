using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Triton.Service.Model.TritonGroup.Custom
{
    public class CustomersModel
    {
        public int CustomerID { get; set; }
        public string AccountCode { get; set; }
        public int BranchID { get; set; }

        [DisplayName("Status")]
        public int? CustomerStatusID { get; set; }
        public string Name { get; set; }
        public bool LinkedAccount { get; set; }
        public int? LinkedCustomerID { get; set; }
        public bool FWSystemAccount { get; set; }
        public bool InternalAccount { get; set; }
        [DisplayName("Last Increased")]
        public DateTime? LastIncreaseDate { get; set; }
        [DisplayName("Next Increase")]
        public DateTime? NextIncreaseDate { get; set; }
        public string Contact { get; set; }
        public string TelNo { get; set; }
        public string FaxNo { get; set; }
        public string Email { get; set; }
        public string CellNo { get; set; }
        public string AddLine1 { get; set; }
        public string AddLine2 { get; set; }
        public string AddLine3 { get; set; }
        public string AddLine4 { get; set; }
        public string PostalCode { get; set; }
        public bool? MarkforClosure { get; set; }
        public int? StatusID { get; set; }
        public int CustomerAccountTypeID { get; set; }
        public string FWRateAccCode { get; set; }
        public string FWRepCode { get; set; }
        public bool? HasUniques { get; set; }
        public decimal? Insurance { get; set; }
        public int VolRatio { get; set; }
        public string Swat { get; set; }
        public decimal? Avg { get; set; }
        public decimal? Compliance { get; set; }
        public int? RateClassID { get; set; }
        [DisplayName("Created")]
        public DateTime? AccountCreatedDate { get; set; }
        public decimal? SixMonthCompliance { get; set; }
        public int? InternalDepartmentID { get; set; }
        public string RevisedAnvDate { get; set; }
        public bool Exclusion { get; set; }
        public bool hasFuelOnSundries { get; set; }
        public string PropAddress1 { get; set; }
        public string PropAddress2 { get; set; }
        public string PropAddress3 { get; set; }
        public string PropAddress4 { get; set; }
        public string PropTel { get; set; }
        public string PropFax { get; set; }
        public string PropPostalCode { get; set; }
        public int CustomerCommisionTypeID { get; set; }
        public bool hasFixedPerc { get; set; }
        public decimal? FixedPerc { get; set; }
        public int? PaymentProfileID { get; set; }
        public bool ExcludeTargetCorrection { get; set; }
        public bool? PODVerify { get; set; }
        public int? VerticalMarketID { get; set; }
        public int? SubVerticalMarketID { get; set; }
        public int? CustomerTradeStatusID { get; set; }
        public int? SaleTypeID { get; set; }

        [Computed]
        public string CustomerName => AccountCode + " - " + Name;

        public bool? ExcludeFromDeliveries { get; set; }
        public int FuelSurchargeClassID { get; set; }
        public string FWCreditController { get; set; }
        public int? CreditControllerEmployeeID { get; set; }
        public string Country { get; set; }
        public string StatementEmailAdd { get; set; }
        public bool? isDelayed { get; set; }
        public string FWPriceCheckQuoteNo { get; set; }

        public string CustomerAccountCodeName { get; set; }
        public DateTime? SitesLastUpdated { get; set; }

        public int CustomerAnalysisID { get; set; }
        public string BranchFullName { get; set; }
        public int RateClassesID { get; set; }

        [DisplayName("RateClasses Description")]
        public string Description { get; set; }
        public int RateClassesRateCycleID { get; set; }
        public bool RateClassesActive { get; set; }
        public bool RateClassesCanQuote { get; set; }
        public bool RateClassesCanAdjust { get; set; }
        public int CustomerStatusCustomerStatusID { get; set; }
        public string CustomerStatusFWCode { get; set; }
        public string CustomerStatusShortDescription { get; set; }
        public string CustomerStatusLongDescription { get; set; }
        public string CustomerStatusColour { get; set; }
        public int WorkFlowStageID { get; set; }
        public int WorkFlowID { get; set; }
        public string RepName { get; set; }
        public bool IsChecked { get; set; }

        public DateTime? IncreaseDate { get; set; }
        public bool ProcessCompleted { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Ref { get; set; }
        public bool HasOpsNote { get; set; }
        public string OpsNote { get; set; }
        public int RateIncreaseID { get; set; }
        public bool IsManual { get; set; }
        public int FinalStageID { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string OutCome { get; set; }
        public bool ExcludeFromReview { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CustomerAccountType { get; set; }
        public string RepCode { get; set; }
    }
}