using System;
using System.Collections.Generic;
using Triton.Model.CRM.Tables;

namespace Triton.Model.CRM.Custom
{
    public class CountryCurrencyTargetsModel
    {
        public int CountryCurrencyTargetID { get; set; }
        public int CountryID { get; set; }
        public decimal Amount { get; set; }
        public int CalMonth { get; set; }
        public int CalYear { get; set; }
        public decimal AmountExFreight { get; set; }
        public decimal AmountNewFreight { get; set; }
        public decimal AmountTransFreight { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Code { get; set; }
        public string Country { get; set; }
        public string Icon { get; set; }
        public string  ErrorMessage { get; set; }
        public bool FutureMonthAndYear { get; set; }
        public bool CurrentMonthAndYear { get; set; }
        public int CalMonthFuture { get; set; }
        public int CalMonthCurrent { get; set; }
        public int CalYearFuture { get; set; }
        public int CalYearCurrent { get; set; }
        public List<CountryCurrencyTargetsModel> CountryCurrencyTargetsModels { get; set; }
        public List<Dates> Dates { get; set; }
        public decimal AmountInclFuel { get; set; }
    }
}
