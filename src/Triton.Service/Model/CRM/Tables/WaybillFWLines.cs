using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Model.CRM.Tables
{
     public class WaybillFWLine
    {
        [Key]
        public long WaybillFWLineID { get; set; }
        public long WaybillID { get; set; }
        public decimal? LineItemQty { get; set; }
        public decimal? LineLen { get; set; }
        public decimal? LineHgt { get; set; }
        public decimal? LineBth { get; set; }
        public string LineItemType { get; set; }
        public string LineParcelFrom { get; set; }
        public string LineParcelTo { get; set; }
        public decimal? LineChargeableUnits { get; set; }
        public string LineItemDesc { get; set; }
        public decimal? LineItemMass { get; set; }
        public string LineItemLoadType { get; set; }
        public decimal? LineItemChrg { get; set; }
        public decimal? LineNo { get; set; }
        public decimal? LineVolWeight { get; set; }
        public string LineParcelType { get; set; }
        public string LineProdID { get; set; }
        public string LineLabelPrinted { get; set; }

    }
}
