using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("Fines")]
    public class Fines
    {
        [Key]
        public int ID { get; set; }
        public int? EmployeeID { get; set; }
        public string FineRef { get; set; }
        public decimal? Amount { get; set; }
        public string Comment { get; set; }
        public string Category { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EventDate { get; set; }
        public string GlCode { get; set; }
        public decimal? FineExpense { get; set; }
        public decimal? AodStaffAdvance { get; set; }
        public decimal? ThirdPartyLiable { get; set; }
        public decimal? Postage { get; set; }
        public decimal? PayfineAdminFee { get; set; }
        public decimal? Total { get; set; }
        public string Court { get; set; }
        public string RegistrationNumber { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentReceiptNumber { get; set; }
        public DateTime? PaymentDate { get; set; }
    }
}
