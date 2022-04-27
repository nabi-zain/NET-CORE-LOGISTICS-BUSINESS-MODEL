using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.StoredProcs
{
    public class proc_SupplierBilling
    {
        public DateTime POMonthYear { get; set;}
        public String MonthYear
        {
            get
            {
                return POMonthYear.ToString("MMMM yyyy");
            }
            
        }
        [DataType(DataType.Currency)]
        public Decimal POTotal { get; set; }
    }
}
