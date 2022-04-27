using System;
using System.Collections.Generic;
using System.ComponentModel;
using Triton.Model.TritonGroup.Tables;
using Triton.Model.TritonLH.Tables;

namespace Triton.Model.TritonLH.Custom
{

    public class SiteGPSEditModels
    {
        public List<Sites> Sites { get; set; }
        public Sites SelectedSite { get; set; }

        public int? CustomerID { get; set; }

       // public List<StoredProcs.proc_GetSiteGPS_Waybill_Tracking> Tracking { get; set; }
    }
    public class SitesModels
    {
        public Sites Sites { get; set; }
        public Triton.Model.TritonLH.Tables.Customers Customers { get; set; }
        public CustomerSiteMaps CustomerSiteMaps { get; set; }
        public bool Success { get; set; }
        public RateAreas RateArea { get; set; }
        public RateAreas CustomerRateArea { get; set; }
        public List<RateAreas> RateAreaList { get; set; }
        public List<TritonGroup.Tables.LookUpCodes> Provinces { get; set; }
        public LookUpCodes Province { get; set; }
    }

    public class SitesLinkModels
    {
        public List<Sites> SiteList { get; set; }
        public Sites Sites { get; set; }
        public Triton.Model.TritonLH.Tables.Customers Customers { get; set; }
        public CustomerSiteMaps CustomerSiteMaps { get; set; }
        public List<RateAreas> RateAreaList { get; set; }
        public bool Success { get; set; }
    }

    public class FromToSitesModel
    {
        public int FromSiteID { get; set; }
        public int ToSiteID { get; set; }
        public string FromSiteCustomerName { get; set; }
        public string ToSiteCustomerName { get; set; }
    }

    public class FromToSitesListModel
    {
        [DisplayName("Customers")]
        public List<Tables.Customers> Customers { get; set; }

        public int? SelectedCustomer { get; set; }


        [DisplayName("Total Ex VAT")]
        public decimal? TotalExVAT { get; set; }
        public decimal? Tonnage { get; set; }

        [DisplayName("Tonnage Amount")]
        public decimal? TonnageAmount { get; set; }

        [DisplayName("Trip Type")]
        public List<TritonGroup.Tables.LookUpCodes> TripType { get; set; }

        [DisplayName("Tariff Type")]
        public List<TritonGroup.Tables.LookUpCodes> TarrifType { get; set; }

        public int SelectedTripType { get; set; }
        public int SelectedTarrifType { get; set; }

        public string CustomerOrderNo { get; set; }

        [DisplayName("Invoice No")]
        public int? InvoiceID { get; set; }

        [DisplayName("Estimated Departure")]
        public DateTime? EstimatedDepartureDateTime { get; set; }

        [DisplayName("Estimated Arrival")]
        public DateTime? EstimatedArrivalDateTime { get; set; }

        [DisplayName("CHEP No")]
        public string CHEPNo { get; set; }

        [DisplayName("To Collect")]
        public int? ToCollect { get; set; }
        public int ControlInstance { get; set; }

        public DateTime ScheduledDate { get; set; }
    }
}
