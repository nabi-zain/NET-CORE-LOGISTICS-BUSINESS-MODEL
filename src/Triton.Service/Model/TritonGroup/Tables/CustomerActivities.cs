using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("CustomerActivities")]
    public class CustomerActivities
    {
        [Key]
        public int CustomerActivityID { get; set; }
        [DisplayName("Customer")]
	    public int CustomerID { get; set; }
        [DisplayName("Type")]
	    public int ActivityTypeLCID { get; set; }
        [DisplayName("Event Date")]
	    public DateTime TimeStamp { get; set; }
        [DisplayName("Creator")]
	    public int CreatedByUserID { get; set; }
        [DisplayName("Created")]
	    public DateTime CreatedOn { get; set; }
        [DisplayName("Deletor")]
	    public int? DeletedByUserID { get; set; }
        [DisplayName("Deleted")]
	    public DateTime? DeletedOn { get; set; }
	    public String Details { get; set; }
        public String Subject { get; set; }
        
    }
}
