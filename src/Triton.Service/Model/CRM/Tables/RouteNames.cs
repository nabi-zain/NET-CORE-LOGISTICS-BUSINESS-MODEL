using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    public class RouteNames
    {
        public int ID { get; set; }
        public int? BranchID { get; set; }
        public string ROUTE { get; set; }
        public string ROUTENAME { get; set; }
        public bool Agent { get; set; }
        public bool CCL { get; set; }
        public bool Depot { get; set; }
        public bool NoScanner { get; set; }
        public bool Outlying { get; set; }
        public bool ScannerInRepairs { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string DepartureTime { get; set; }
        public bool? Active { get; set; }
        public bool? NoScannerRequired { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }

        //Additional Properties
        [Write(false)]
        public string DropDownListName { get; set; }

        [Computed]
        public string CheckListName
        {
            get { return ROUTE + " - " + ROUTENAME; }

        }
    }
}
