using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.CRM.Tables
{
    [Table("Payments")]
    public class Payments
    {
        [Dapper.Contrib.Extensions.Key]
       
        public Guid PaymentID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        [DisplayName("Payment Date")]
        public DateTime PaymentDate { get; set; }
        public int TransactionTypeLCID { get; set; }
        public long TransactionFKID { get; set; }
        public decimal SubmittedAmount { get; set; }
        public int SubmittedByUserID { get; set; }
        public DateTime SubmittedOn { get; set; }
        public DateTime? ResponseOn { get; set; }
        public string TransactionID { get; set; }
        public string PaymentStatus { get; set; }
        public string ReturnedItemDescription { get; set; }
        public string ReturnedItemName { get; set; }
        public Decimal? Amount_Gross { get; set; }
        public Decimal? Amount_Fee { get; set; }
        public Decimal? Amount_Net { get; set; }
        public string CustomString1 { get; set; }
        public int? CustomInteger { get; set; }
        public DateTime? BillingDate { get; set; }
        public string PaymentToken { get; set; }
        public string SecuritySignatureMD5 { get; set; }

    }
}
