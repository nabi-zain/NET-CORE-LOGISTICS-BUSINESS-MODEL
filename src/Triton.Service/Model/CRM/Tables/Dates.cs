using System;
using System.ComponentModel;

namespace Triton.Model.CRM.Tables
{
    public class Dates
    {
        public int Date_ID { get; set; }
        public DateTime Date { get; set; }
        public int Julian_Date { get; set; }
        public int Calendar_Year { get; set; }
        public int Financial_Year { get; set; }
        public byte Calendar_Quarter { get; set; }
        public short Calendar_Quarter_ID { get; set; }
        public string Calendar_Quarter_Name { get; set; }
        public byte Financial_Quarter { get; set; }
        public int Financial_Quarter_ID { get; set; }
        public string Financial_Quarter_Name { get; set; }
        public string Season { get; set; }
        public int Calendar_Month_ID { get; set; }
        public byte Calendar_Month_Number { get; set; }
        public string Month_Name { get; set; }
        public string Month_Abbreviation { get; set; }
        public int Financial_Month_ID { get; set; }
        public byte Financial_Month_Number { get; set; }
        public int Calendar_Week_ID { get; set; }
        public byte Calendar_Week { get; set; }
        public int Financial_Week_ID { get; set; }
        public byte Financial_Week { get; set; }
        public short Day_of_Calendar_Year { get; set; }
        public short Day_of_Financial_Year { get; set; }
        public byte Day_of_Month { get; set; }

        [DisplayName("Day Number")]
        public byte Week_Day_Number { get; set; }

        [DisplayName("Day Name")]
        public string Week_Day_Name { get; set; }
        public string Week_Day_Abbreviation { get; set; }
        public bool Is_a_Weekend_day { get; set; }
        public bool Is_a_Public_Holiday { get; set; }
        public bool Is_a_Leap_Year { get; set; }
        public bool Is_a_Special_day { get; set; }
        public short Days_In_Calendar_Year { get; set; }
        public short Days_In_Financial_Year { get; set; }
        public short Weekdays_In_Calendar_Year { get; set; }
        public short Weekdays_In_Financial_Year { get; set; }
        public short Workdays_In_Calendar_Year { get; set; }
        public short Workdays_In_Financial_Year { get; set; }
        public short Days_In_Calendar_Year_Sofar { get; set; }
        public short Days_In_Financial_Year_Sofar { get; set; }
        public short Weekdays_In_Calendar_Year_Sofar { get; set; }
        public short Weekdays_In_Financial_Year_Sofar { get; set; }
        public short Workdays_In_Calendar_Year_Sofar { get; set; }
        public short Workdays_In_Financial_Year_Sofar { get; set; }
        public short Days_In_Month { get; set; }
        public short Weekdays_In_Month { get; set; }
        public short Workdays_In_Month { get; set; }
        public short Days_In_Month_Sofar { get; set; }
        public short Weekdays_In_Month_Sofar { get; set; }
        public short Workdays_In_Month_Sofar { get; set; }
        public string Processed { get; set; }
        public string GraphicalLateVSEarly { get; set; }
    }
}
