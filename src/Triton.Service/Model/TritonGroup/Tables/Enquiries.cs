using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("Enquiries")]
    public class Enquiries 
    {
       
        public Enquiries()
        {
        }
        
        public int BranchID { get; set; }
        [DisplayName("Email")]
        public String CompanyEmail { get; set; }
        [DisplayName("Company")]
        public String CompanyName { get; set; }
        [DisplayName("Phone")]
        public String ContactNumber { get; set; }
        [DisplayName("Contact")]
        public String ContactPerson { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64 CreatorID { get; set; }
        [Dapper.Contrib.Extensions.Key]
        public Int64 EnquiryID { get; set; }
        [DisplayName("Industry")]
        public int IndustryLCID { get; set; }
        public Boolean Killed { get; set; }
        [DisplayName("Location")]
        public String Location { get; set; }
        public String Remarks { get; set; }
        [DisplayName("Rep")]
        public Int64? RepID { get; set; }
        [DisplayName("Vertical Market")]
        public Int32 VerticalMarketLCID { get; set; }
        [DisplayName("Sub-Vertical Market")]
        public Int32 SubVerticalMarketLCID { get; set; }
        public Int32 SystemID { get; set; }
    }
}