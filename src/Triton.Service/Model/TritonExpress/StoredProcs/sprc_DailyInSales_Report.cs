using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.StoredProcs
{
    public class sprc_DailyInSales_Report
    {
        public Decimal BudgetTotal { get; set; }
        public Decimal dailysalestargetTotal { get; set; }
        public Decimal DailySalesTarget { get; set; }
        public String dspSubCat { get; set; }
        public String mydate { get; set; }
        public Decimal salesperkg { get; set; }
        public Decimal roundKG { get; set; }
        public Int32 one { get; set; }
        public Decimal myAvg { get; set; }
        public Decimal DailyBudget { get; set; }
        public Decimal OnTarget { get; set; }
        public Int32 ID { get; set; }
        public String ProdCat { get; set; }
        public String SubCat { get; set; }
        public String OrderYear { get; set; }
        public String OrderQtr { get; set; }
        public Int32 Waybills { get; set; }
        public Decimal Sales { get; set; }
        public Decimal KG { get; set; }
        public Decimal Avg { get; set; }
        public String Day { get; set; }
        public Boolean Actual { get; set; }
        public Int32 FinYear { get; set; }
        public Int32 BranchID { get; set; }
        public String BranchCode { get; set; }
        public String BranchName { get; set; }
        public Int32 DailySalesOrder { get; set; }
        public Decimal Longitude { get; set; }
        public Decimal Latitude { get; set; }
        public Int32 RS_Month_No { get; set; }
        public String RS_Month { get; set; }
        public DateTime RS_StartDate { get; set; }
        public DateTime RS_EndDate { get; set; }
        public Int32 RS_MonthDescription { get; set; }
        public Decimal DailySalesTargetQuarter { get; set; }
        public String Branch { get; set; }
        public String Month { get; set; }
        public String SalesType { get; set; }
        public Int32 TargetYear { get; set; }
        public Decimal Budget { get; set; }
        public Int32 ID2 { get; set; }
        public DateTime DateParm { get; set; } 	
    }
}
