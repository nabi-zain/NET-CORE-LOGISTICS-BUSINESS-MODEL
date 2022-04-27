using System.ComponentModel;

namespace Triton.Model.TritonLH.StoredProcs
{
    public class proc_Customer_Montly_Revenue_Select
    {
        public int CurrentYear { get; set; }
        public string CurrentMonth { get; set; }

        [DisplayName("Total Ex VAT")]
        public decimal TotalEXVAT { get; set; }
    }
}
