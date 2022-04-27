using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.CRM.StoredProcs
{
    public class proc_Customer_UpDownTrader
    {
        public DateTime YearMonth { get; set; }
        public decimal WaybillFigure { get; set; }
        public decimal Change { get; set; }
        public string Color { get; set; }
    }
}
