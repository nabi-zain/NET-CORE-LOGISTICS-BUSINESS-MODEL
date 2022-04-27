using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("Enquiries")]
    public class Enquiries
    {
        public long EnquiryID { get; set; }
        public string CompanyName { get; set; }
        public int BranchID { get; set; }
        public string Location { get; set; }
        public string ContactPerson { get; set; }
        public string Industry { get; set; }
        public string Remarks { get; set; }
        public long CreatorID { get; set; }
        public long RepID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CompanyEmail { get; set; }
        public byte Killed { get; set; }
        public int IndustryID { get; set; }
        public int VerticalMarketID { get; set; }
        public int SubVerticalMarketID { get; set; }
    }
}
