using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.StoredProcs
{
    public class proc_WaybillTrackandTraces_CustomerDesc_Select
    {
        public int WaybillTrackandTranceID { get; set; }
        public int WaybillID { get; set; }
        public string NoteNo { get; set; }
        public int FWEventCodeID { get; set; }
        public string FWEventDescription { get; set; }
        public  DateTime EventDate { get; set; }
        public DateTime EventDatTimeStamp { get; set; }
        public string FWEventLocation { get; set; }
        public string FWEventUser { get; set; }
        public string CrossRef1 { get; set; }
        public string CrossRef2 { get; set; }
        public string CrossRef3 { get; set; }
        public string NoteDetails { get; set; }
        public byte isMail { get; set; }
        public int notificationID { get; set; }
        public int NotificationtypeID { get; set; }
        public string Longtide { get; set; }
        public string Latitide { get; set; }
        public byte SMSSent { get; set; }
        public  string PlulsITLongitude { get; set; }
        public string PulsITLatitude { get; set; }
        public DateTime PulsDatetimeStamp { get; set; }
     
        public string Code { get; set; }
        public string ShortDesc { get; set; }
        public string LongDescription { get; set; }
        public string CustomerDesc { get; set; }
        public byte CustomerActive { get; set; }
        public int BranchID { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string BranchFullName { get; set; }
        public string BranchAdd1 { get; set; }
        public string BranchAdd2 { get; set; }
        public string BranchAdd3 { get; set; }
        public string BranchAdd4 { get; set; }
        public string BRancTel { get; set; }
        public string BranchFax { get; set; }
        public string BranchDailySaleOrder { get; set; }
        public string BranchRepOrder { get; set; }
        public byte isCoastal { get; set; }
        public int BranchCategoryID { get; set; }
        public int RegionID { get; set; }
        public int LocationID { get; set; }
        public string WaybillPDF { get; set; }
        public byte Active { get; set; }
        public string BranchAlias { get; set; }
        public int CompanyID { get; set; }
        public string FWDepotCode { get; set; }
        public int BranchTypeID { get; set; }
        public string TotalScanners { get; set; }
        public string TotalSpaceScanners { get; set; }
        public int ContactUserID { get; set; }
    }
}
