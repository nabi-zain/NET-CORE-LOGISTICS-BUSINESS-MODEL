using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    [Table("DimDate")]
    public class DimDate
    { 
        public DateTime PK_Date { get; set; }
        public string Date_Name { get; set; }
        public DateTime Year { get; set; }
        public string Year_Name { get; set; }
        public DateTime Half_Year { get; set; }
        public string Half_Year_Name { get; set; }
        public string Quarter { get; set; }
        public string Quarter_Name { get; set; }
        public DateTime Trimester { get; set; }
        public string Trimester_Name { get; set; }
        public DateTime Month { get; set; }
        public string Month_Name { get; set; }
        public DateTime Ten_Days { get; set; }
        public string Ten_Days_Name { get; set; }
        public DateTime Week { get; set; }
        public string Week_Name { get; set; }
        public int Day_Of_Year { get; set; }
        public string Day_OF_YEar_Name { get; set; }
        public int Day_Of_Half_Year { get; set; }
        public string Day_Of_Half_Year_Name { get; set; }
        public int Day_Of_Trimester { get; set; }
        public string Day_Of_Trimester_Name { get; set; }
        public int Day_Of_Quarter { get; set; }
        public string Day_Of_Quarter_Name { get; set; }
        public int Day_Of_Month { get; set; }
        public string Day_Of_Month_Name { get; set; }
        public int Day_Of_Ten_Days { get; set; }
        public string Day_Of_Ten_Days_Name { get; set; }
        public int Day_Of_Week { get; set; }
        public string Day_Of_Week_Name { get; set; }
        public int Week_Of_Year { get; set; }
        public string Week_Of_Year_Name { get; set; }
        public int Ten_Days_Of_Year { get; set; }
        public string Ten_Days_Of_Year_Name { get; set; }
        public int Ten_Days_Of_Half_Year { get; set; }
        public string Ten_Days_Of_Half_Year_Name { get; set; }
        public int Ten_Days_Of_Trimester { get; set; }
        public string Ten_Days_Of_Trimester_Name { get; set; }
        public int Ten_Days_Of_Quarter { get; set;}
        public string Ten_Days_Of_Quarter_Name { get; set; }
        public int Ten_Days_Of_Month { get; set; }
        public string Ten_Days_Of_Month_Name { get; set; }
        public int Month_Of_Year { get; set; }
        public string Month_Of_Year_Name { get; set; }
        public int Month_Of_Half_Year { get; set; }
        public string Month_Of_Half_Year_Name { get; set; }
        public int Month_Of_Trimester { get; set; }
        public string Month_Of_Trimester_Name { get; set; }
        public int Month_Of_Quarter { get; set; }
        public string Month_Of_Quarter_Name { get; set; }
        public int Quarter_Of_Year { get; set; }
        public string Quarter_Of_Year_Name { get; set; }
        public int Quarter_Of_Half_Year { get; set; }
        public string Quarter_Of_Half_Year_Name { get; set; }
        public int Trimester_Of_Year { get; set; }
        public string Trimester_Of_Year_Name { get; set; }
        public int Half_Year_Of_Year { get; set; }
        public string Half_Year_Of_Year_Name { get; set; }
        public DateTime Fiscal_Year { get; set; }
        public string Fiscal_Year_Name { get; set; }
        public DateTime Fiscal_Half_Year { get; set; }
        public string Fiscal_Half_Year_Name { get; set; }
        public DateTime Fiscal_Quarter { get; set; }
        public string Fiscal_Quarter_Name { get; set; }
        public DateTime Fiscal_Trimester { get; set; }
        public string Fiscal_Trimester_Name { get; set; }
        public DateTime Fiscal_Month { get; set; }
        public string Fiscal_Month_Name { get; set; }
        public DateTime Fiscal_Week { get; set; }
        public string Fiscal_Week_Name { get; set; }
        public DateTime Fiscal_Day { get; set; }
        public string Fiscal_Day_Name { get; set; }
        public int Fiscal_Day_Of_Year { get; set; }
        public string Fiscal_Day_Of_Year_Name { get; set; }
        public int Fiscal_Day_Of_Half_Year { get; set; }
        public string Fiscal_Day_Of_Half_Year_Name { get; set; }
        public int Fiscal_Day_Of_Trimester { get; set; }
        public string Fiscal_Day_Of_Trimester_Name { get; set; }
        public int Fiscal_Day_Of_Quarter { get; set; }
        public string Fiscal_Day_Of_Quarter_Name { get; set; }
        public int Fiscal_Day_Of_Month { get; set; }
        public string Fiscal_Day_Of_Month_Name { get; set; }
        public int Fiscal_Day_Of_Week { get; set; }
        public string Fiscal_Day_Of_Week_Name { get; set; }
        public int Fiscal_Week_Of_Year { get; set; }
        public string Fiscal_Week_Of_Year_Name { get; set; }
        public int Fiscal_Month_Of_Year { get; set; }
        public string Fiscal_Month_Of_Year_Name { get; set; }
        public int Fiscal_Month_Of_Half_Year { get; set; }
        public string Fiscal_Month_Of_Half_Year_Name { get; set; }
        public int Fiscal_Month_Of_Trimester { get; set; }
        public string Fiscal_Month_Of_Trimester_Name { get; set; }
        public int Fiscal_Month_Of_Quarter { get; set; }
        public string Fiscal_Month_Of_Quarter_Name { get; set; }
        public int Fiscal_Trimester_Of_Year { get; set; }
        public string Fiscal_Trimester_Of_Year_Name { get; set; }
        public int Fiscal_Quarter_Of_Year { get; set; }
        public string Fiscal_Quarter_Of_Year_Name { get; set; }
        public int Fiscal_Quarter_Of_Half_Year { get; set; }
        public string Fiscal_Quarter_Of_Half_Year_Name { get; set; }
        public int Fiscal_Half_Year_Of_Year { get; set; }
        public string Fiscal_Half_Year_Of_Year_Name { get; set; }
    }
}
