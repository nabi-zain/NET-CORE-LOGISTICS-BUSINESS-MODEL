using System;
using System.ComponentModel;

namespace Triton.Model.TritonOps.StoredProcs
{
    public class proc_TLH_LateLineHaul_Waybills_Select
    {
        public int SiteID { get; set; }

        public String SiteName { get; set; }

        [DisplayName("Customer")]
        public String SiteCustomerName { get; set; }

        public String Address1 { get; set; }

        public String Address2 { get; set; }

        public String Address3 { get; set; }

        public String Address4 { get; set; }

        public String PostalCode { get; set; }

        public Int64 WaybillID { get; set; }

        public string WaybillNo { get; set; }

        public int CustomerID { get; set; }

        [DisplayName("Acc Code")]
        public string AccountCode { get; set; }

        [DisplayName("Sender Name")]
        public string SenderName { get; set; }

        [DisplayName("WB Status")]
        public string WaybillStatus { get; set; }

        public DateTime WaybillDate { get; set; }

        public DateTime DelExpectedDateTimeStamp { get; set; }

        [DisplayName("Manifest No")]
        public string LinehaulManifestNo { get; set; }

        [DisplayName("From Branch")]
        public string FromBranch { get; set; }

        [DisplayName("To Branch")]
        public string ToBranch { get; set; }

        public string Email { get; set; }

        public string Cell { get; set; }

        public string Phone { get; set; }

        public Int64 CCLID { get; set; }

        public int ToBranchID { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public bool CheckBoxSend { get; set; }
    }
}