using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;

namespace Triton.Model.CRM.Tables
{
    [Dapper.Contrib.Extensions.Table("CustomerAdjustmentSheet")]
    public class CustomerAdjustSheet
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("ACC NO")]
        public string ACC_NO { get; set; }
        public string Name { get; set; }
        [DisplayName("LAST EFFECTIVE DATE")]
        public DateTime LAST_EFFECTIVE_Date { get; set; }
        [DisplayName("REP CODE")]
        public string REP_CODE { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }

        public string F7 { get; set; }
        public string F8 { get; set; }
        public string F9 { get; set; }
        public string F10 { get; set; }
        public string F11 { get; set; }
        public string F12 { get; set; }
        public string F13 { get; set; }
        public string F14 { get; set; }
        public string F15 { get; set; }
        public string F16 { get; set; }
        public string F17 { get; set; }
        public string F18 { get; set; }
        public string F19 { get; set; }
        public string F20 { get; set; }
    }
}
