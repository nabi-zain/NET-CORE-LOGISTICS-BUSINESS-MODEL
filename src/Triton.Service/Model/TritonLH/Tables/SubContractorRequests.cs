using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.TritonLH.Tables
{
    [Table("SubContractorRequests")]
    public class SubContractorRequests
    {
        [Key]
        public int SubContractorRequestID { get; set; }
        public int DeliveryID { get; set; }
        public int SupplierID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public int LookupcodeID { get; set; }
        public string Note { get; set; }
        public decimal? SubbyCost { get; set; }
        public string SubbyDriver { get; set; }
        public string SubbyCell { get; set; }
        public string ClientName { get; set; }

        public string Registration { get; set; }
    }
}
