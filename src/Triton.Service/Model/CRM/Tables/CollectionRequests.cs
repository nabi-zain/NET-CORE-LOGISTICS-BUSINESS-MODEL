using Dapper.Contrib.Extensions;
using System;
using TableAttribute = Dapper.Contrib.Extensions.TableAttribute;

namespace Triton.Model.CRM.Tables
{
    [Table("CollectionRequests")]
    public class CollectionRequests
    {
        [Key]
        public long CollectionRequestID { get; set; }
        public string CollectionrequestNumber { get; set; }
        public int CollectionRequestStatus { get; set; }
        public int CustomerID { get; set; }
        public int ServiceTypeID { get; set; }

        public DateTime DateCollReq { get; set; }
        public string TimeCollAfter { get; set; }
        public string TimeCollBefore { get; set; }
        public bool CollFromSecurity { get; set; }
        public string SpecialInstructions { get; set; }
        public string CollManNo { get; set; }
        public int CollectionManifestID { get; set; }
        public DateTime DateCollMan { get; set; }
        public int BranchID { get; set; }
        public int RouteID { get; set; }
        public int OriginBranchID { get; set; }
        public string FWIDCapture { get; set; }
        public string FWIDModify { get; set; }
        public DateTime Captured { get; set; }
        public string CallerRelationship { get; set; }
        public string CallerName { get; set; }
        public string CallerSureName { get; set; }
        public string CallerContactInfo { get; set; }
        public decimal EstMass { get; set; }
        public int EstQty { get; set; }
        public decimal EstVolume { get; set; }
        public string SendSite { get; set; }
        public string SendName { get; set; }
        public string SendAdd1 { get; set; }
        public string SendAdd2 { get; set; }
        public string SendAdd3 { get; set; }
        public string SendAdd4 { get; set; }
        public string SendAddPostalCode { get; set; }
        public string SendContact { get; set; }
        public string SendTelNo { get; set; }
        public string SendInstructions1 { get; set; }
        public string SendInstructions2 { get; set; }
        public string RecSite { get; set; }
        public string RecName { get; set; }
        public string RecAdd1 { get; set; }
        public string RecAdd2 { get; set; }
        public string RecAdd3 { get; set; }
        public string RecAdd4 { get; set; }
        public string RecAddPostalCode { get; set; }
        public string RecContact { get; set; }
        public string recTellNo { get; set; }
        public string RecInstructions1 { get; set; }
        public string RecInstructions2 { get; set; }
        public DateTime DateRec { get; set; }
        public string TimeRec { get; set; }
        public string TimeCancelled { get; set; }
        public string Remarks { get; set; }
        public string OutsourceXref { get; set; }
        public string CustomerXref { get; set; }
        public string CustAuthNo { get; set; }
        public string UserRec { get; set; }
        public DateTime LastUpdated { get; set; }
        public string ExporterCode { get; set; }
        public string ImporterCode { get; set; }


        }


    }

