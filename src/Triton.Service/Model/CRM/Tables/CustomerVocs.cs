using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerVocs")]
    public class CustomerVocs
    {
        [Key]
        public int CustomerVOCID { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public DateTime DateLodged { get; set; }
        public int CustomerAddititionalContactID { get; set; }
        public decimal SnapshotSpend { get; set; }
        public decimal SnapshotAvg { get; set; }
        public decimal SnapsotCompliance { get; set; }
        public string Complaint { get; set; }
        public string Comments { get; set; }
        public string Waybillnumbers { get; set; }
        public byte PriorIssues { get; set; }
        public byte PriorVOC { get; set; }
        public string PriorAddressee { get; set; }
        public DateTime PriorVOCDate { get; set; }
        public DateTime LastActionDate { get; set; }
        public byte Locked { get; set; }
        public int LinkedMeetingID { get; set; }


    }
}
