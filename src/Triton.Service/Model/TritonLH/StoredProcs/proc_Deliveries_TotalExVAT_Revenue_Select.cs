using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonLH.StoredProcs
{
    public class proc_Deliveries_TotalExVAT_Revenue_Select
    {
        [DisplayName("Year")]
        public int RevenueYear { get; set; }

        [DisplayName("Month")]
        public string RevenueMonth { get; set; }

        [DisplayName("Subby")]
        public decimal SubbyTotalExVAT { get; set; }

        [DisplayName("FTL")]
        public decimal TritonTotalExVAT { get; set; }

        [DisplayName("Subby Cost")]
        public decimal SubbyCostTotalExVAT { get; set; }

        [DisplayName("Subby Margin")]
        public decimal SubbyMargin { get; set; }

        [DisplayName("Subby Margin %")]
        public decimal SubbyMarginPerc { get; set; }

        [DisplayName("Routing")]
        public decimal TLHRouting { get; set; }

        [DisplayName("Locals")]
        public decimal TLHLocals { get; set; }
    }
}
