using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.StoredProcs
{
    public class proc_Deliveries_ByDeliveryID_Select
    {
        public proc_Deliveries_ByDeliveryID_Select()
        {
            IsTritonVehicle = true;
        }
        public Int64 DeliveryID { get; set; }

        [DisplayName("Delivery Note No")]
        public string DeliveryNoteNo { get; set; }

        public int CustomerID { get; set; }

        [DisplayName("Contact")]
        public int CustomerAdditionalContactID { get; set; }

        [DisplayName("From Site")]
        public int FromSiteID { get; set; }

        [DisplayName("To Site")]
        public int ToSiteID { get; set; }

        [DisplayName("Scheduled Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ScheduledDate { get; set; }

        [DisplayName("Vehicle")]
        public int? VehicleID { get; set; }

        [DisplayName("Driver")]
        public int? EmployeeID { get; set; }

        [DisplayName("Trailer 1")]
        public int? Trailer1VehicleID { get; set; }

        [DisplayName("Trailer 2")]
        public int? Trailer2VehicleID { get; set; }

        [DisplayName("Dep Date")]
        public DateTime? DepartureDateTime { get; set; }

        [DisplayName("Arr Date")]
        public DateTime? ArrivalDateTime { get; set; }

        [DisplayName("Is TLH Vehicle")]
        public bool IsTritonVehicle { get; set; }

        [DisplayName("Trip Type")]
        public int TripTypeLCID { get; set; }

        [DisplayName("Tariff Type")]
        public int? TarrifTypeLCID { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.##}", ApplyFormatInEditMode = true)]
        public decimal? Tonnage { get; set; }

        [DisplayName("Tonnage Amount"), DisplayFormat(DataFormatString = "{0:0.##}", ApplyFormatInEditMode = true)]
        public decimal? TonnageAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.##}", ApplyFormatInEditMode = true)]
        [DisplayName("Total Ex VAT")]
        public decimal? TotalExVAT { get; set; }

        [DisplayName("Order No")]
        public string CustomerOrderNo { get; set; }

        [Required]
        [DisplayName("Created By")]
        public int CreatedByUserID { get; set; }

        [Required]
        [DisplayName("Created On")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("Deleted By")]
        public int? DeletedByUserID { get; set; }

        [DisplayName("Deleted On")]
        public DateTime? DeletedOn { get; set; }

        [DisplayName("Deleted Reason")]
        public int? DeleteReasonLCID { get; set; }

        [DisplayName("Acc Code")]
        public string AccountCode { get; set; }

        [DisplayName("Cust Name")]
        public string Name { get; set; }

        [DisplayName("Veh Reg")]
        public string VehicleReg { get; set; }

        [DisplayName("Emp Code")]
        public string CurrentEmployeeCode { get; set; }

        [DisplayName("Emp Name")]
        public string LeaveDisplayName { get; set; }

        [DisplayName("DOB")]
        public DateTime? DateOFBirth { get; set; }

        [DisplayName("Alias")]
        public string Alias { get; set; }

        [DisplayName("Emp Status")]
        public string EmployeeStatus { get; set; }

        [DisplayName("Emp Type")]
        public string EmployeeType { get; set; }

        [DisplayName("Trailer1 Reg")]
        public string Trailer1Reg { get; set; }

        [DisplayName("Trailer2 Reg")]
        public string Trailer2Reg { get; set; }

        [DisplayName("Horse Type")]
        public string HorseType { get; set; }

        [DisplayName("Trailer1 Type")]
        public string Trailer1Type { get; set; }

        [DisplayName("Trailer2 Type")]
        public string Trailer2Type { get; set; }

        [DisplayName("UserID")]
        public int UserID { get; set; }

        [DisplayName("User name")]
        public string Username { get; set; }

        [DisplayName("Employee Image")]
        public byte[] EmployeeImage { get; set; }

        [DisplayName("Vehicle Image")]
        public byte[] VehicleImage { get; set; }

        public int PurchaseOrderID { get; set; }

        [DisplayName("Subby Reg")]
        public string Registration { get; set; }

        [DisplayName("Purchase No")]
        public string PurchaseOrderRef { get; set; }

        [DisplayName("Supplier Name")]
        public string SupplierName { get; set; }

        public long DeliveryScheduleID { get; set; }

        [DisplayName("Estimated Dep")]
        public DateTime? EstimatedDepartureDateTime { get; set; }

        [DisplayName("Estimated Arr")]
        public DateTime? EstimatedArrivalDateTime { get; set; }

        [DisplayName("Actual Dep")]
        public DateTime? ActualDepartureDateTime { get; set; }

        [DisplayName("Actual Arr")]
        public DateTime? ActualArrivalDateTime { get; set; }

        [DisplayName("Chep/Eprn")]
        public string CHEPNo { get; set; }

        [DisplayName("To Collect")]
        public int? ToCollect { get; set; }

        [DisplayName("Collected")]
        public int? Collected { get; set; }

        public int? InvoiceID { get; set; }

        [DisplayName("Invoice No")]
        public string InvoiceNo { get; set; }

        [DisplayName("Invoice Date")]
        public DateTime? InvoiceDate { get; set; }

        [DisplayName("Start ODO")]
        public long? StartODO { get; set; }

        [DisplayName("End ODO")]
        public long? EndODO { get; set; }

        public int? Sequence { get; set; }

        [DisplayName("Fuel Litres")]
        public decimal? ActualFuelLitre { get; set; }

        [DisplayName("Fuel Value (R)")]
        [DisplayFormat(DataFormatString = "{0:0.##}")]
        public decimal? FuelValue { get; set; }

        [DisplayName("Trip Fuel")]
        public decimal? TripFuel { get; set; }

        public long? DeliveriesLegID { get; set; }

        public long? ChildDeliveryID { get; set; }

        public DateTime? LegDeletedOn { get; set; }

        public string JobProfileDescription { get; set; }

        public string BranchFullName { get; set; }

        [DisplayName("Trip Delivery ID")]
        public long TripDeliveryID { get; set; }

        [DisplayName("Total excl VAT")]
        public decimal TripTotalExVat { get; set; }
        public string TripDeliveryNote { get; set; }
        public int TripDeliveryTypeLCID { get; set; }

        [DisplayName("Base Rate")]
        public decimal? BaseRate { get; set; }
        public decimal TripTonnage { get; set; }

        [DisplayName("Trip Type")]
        public string TripDeliveryTypeDetail { get; set; }
        public decimal? RatePerTon { get; set; }

        public int? LineHaulTrailerTypeLCID { get; set; } // int, null
        public decimal? Kilometers { get; set; }

        [DisplayName("Waybill No")]
        public string WaybillNo { get; set; } // varchar(50), null

        [DisplayName("Waybill Date")]
        public DateTime? WaybillDate { get; set; } // datetime, null

        [DisplayName("Load Con No")]
        public string LoadConNo { get; set; } // varchar(50), null

        [DisplayName("Leg Date")]
        public DateTime? LegDate { get; set; } // varchar(50), null

        [DisplayName("Salary Date")]
        public DateTime? SalaryDate { get; set; } // varchar(50), null

        [DisplayName("From Address1")]
        public string FromAddress1 { get; set; }

        [DisplayName("From Address2")]
        public string FromAddress2 { get; set; }

        [DisplayName("From City")]
        public string FromCity { get; set; }

        [DisplayName("To Address1")]
        public string ToAddress1 { get; set; }

        [DisplayName("To Address2")]
        public string ToAddress2 { get; set; }

        [DisplayName("To City")]
        public string ToCity { get; set; }

        [DisplayName("Pevious Delivery")]
        public long? PreviousDeliveryID { get; set; }

        [DisplayName("Previous Fuel Delivery")]
        public long? PreviousFuelDeliveryID { get; set; }

        [DisplayName("Financial Status")]
        public string FinancialStatus { get; set; }

    }
}