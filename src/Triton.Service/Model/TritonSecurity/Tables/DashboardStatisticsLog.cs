using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("DasboardStatisticsLog")]
   public class DashboardStatisticsLog
    {
        public int id { get; set; }
        public string StatName { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Value { get; set; }
        public string UnitType { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]

        public DateTime DisplayDate { get; set; }
        public string url { get; set; }
        public string Direction { get; set; }
        public int Decimals { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]

        public DateTime DateChanged { get; set; }
        public string ChangedType { get; set; }
        public int PrevValue { get; set; }
        public int PrevYear { get; set; }
        public int PrevMonth { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]

        public DateTime PrevDisplayDate { get; set; }


    }
}
