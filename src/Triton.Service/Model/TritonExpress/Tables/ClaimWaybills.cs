using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
    [Table("ClaimWaybills")]
    public class ClaimWaybills
    {
        [Dapper.Contrib.Extensions.Key]
        public long ClaimWaybillID { get; set; }
        public long ClaimID { get; set; }
        public long WaybillID { get; set; }

        [DisplayName("ClientEmailAddress")]
        [Write(false)]
        [Computed]
        public string ClientEmailAddress { get; set; }

        [DisplayName("From")]
        [Write(false)]
        [Computed]
        public string FromBranch { get; set; }

        [DisplayName("From")]
        [Write(false)]
        [Computed]
        public int BranchID { get; set; }

        [DisplayName("To")]
        [Write(false)]
        [Computed]
        public string ToBranch { get; set; }

        [DisplayName("Total Qty")]
        [Write(false)]
        [Computed]
        public int TotalQty { get; set; }

        [DisplayName("Freight Value")]
        [Write(false)]
        [Computed]
        public decimal FreightValue { get; set; }
        [DisplayName("Total Value")]
        [Write(false)]
        [Computed]
        public decimal TotalValue { get; set; }

        [DisplayName("Customer Code")]
        [Write(false)]
        [Computed]
        public string AccountCode { get; set; }


        [DisplayName("Current Status")]
        [Write(false)]
        [Computed]
        public string Status { get; set; }

        [DisplayName("Waybill No.")]
        [Write(false)]
        [Computed]
        public string WaybillNo { get; set; }
    }
}
