using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.CRM.StoredProcs
{
    public class proc_Waybills_ByMonthSelect
    {
        public decimal WayBillFigure { get; set; }
        public decimal FreightValue { get; set; }
        public decimal RepBilling { get; set; }
        public string YearMonth { get; set; }
        public string Color { get; set; }
    }
}
