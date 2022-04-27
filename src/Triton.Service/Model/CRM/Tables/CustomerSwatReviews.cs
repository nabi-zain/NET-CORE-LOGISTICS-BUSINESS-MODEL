using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerSwatReviews")]
    public class CustomerSwatReviews
    {
        [Key]
        public int CustomerSwatReviewID { get; set; }
        public int CustomerID { get; set; }
        public int InitiatorUserID { get; set; }
        public DateTime DateInitated { get; set; }
        public string Reason { get; set; }
        public DateTime NextReviewDate { get; set; }
        public string Finding { get; set; }
        public byte isLocked { get; set; }
        public string ReviewAction { get; set; }
        public int CustomerAdjustmentID { get; set; }
    }
}
