using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.Tables
{
    [Table("SiteContacts")]
    public class SiteContacts
    {
        [Dapper.Contrib.Extensions.Key]
        public int SiteContactID { get; set; }

        public string ContactName { get; set; }
        public string ContactCell { get; set; }
        public string ContactSalesRep  { get; set; }
        public string ContactSalesRepCell { get; set; }
        public int SiteID { get; set; }
        public string ArNumber { get; set; }


        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? LastUpdatedByUserID { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
    }
}
