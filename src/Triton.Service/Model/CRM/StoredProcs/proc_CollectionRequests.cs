using System;
using System.Runtime.InteropServices;

namespace Triton.Model.CRM.StoredProcs
{
    public class proc_CollectionRequests
    {
        public DateTime DateCollReq { get; set; }
        public string CustomerXRef { get; set; }
        public string SendSite { get; set; }
        public string SendName { get; set; }
        public string RecSite { get; set; }
        public string RecName { get; set; }
        public string ServiceType { get; set; }
        public string CollectionNo { get; set; }
        public string AccountCode { get; set; }
        public string CustomerName { get; set; }
        public string CollectionRequestNumber { get; set; }
        public int CollectionRequestID { get; set; }
        public int customerId { get; set; }
        public int CollectionRequestStatus{get;set;}
        public string ShortDesc{get;set; }
        public int FWeventCodeID{get;set;}
        public string CollectionBefore{get;set;}
        public string CollectionAfter{get;set;}
        public string RecContact{get;set;}
        public string RecTelNo{get;set;}
        public byte CollFromSecurity{get;set;}
    }
}