
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("Branches")]
    public class Branches
    {
        [Dapper.Contrib.Extensions.Key]
        public int BranchID { get; set; }

        [DisplayName("Code")]
        public int? BranchCode { get; set; }
        [DisplayName("Branch")]
        public string BranchName { get; set; }
        public string BranchFullName { get; set; }
        public string BranchAdd1 { get; set; }
        public string BranchAdd2 { get; set; }
        public string BranchAdd3 { get; set; }
        public string BranchAdd4 { get; set; }
        public string BranchTel { get; set; }
        public string BranchFax { get; set; }
        public int? BranchDailySalesOrder { get; set; }
        public int? RepSalesOrder { get; set; }
        public bool? isCoastal { get; set; }
        public int? BranchCategoryID { get; set; }
        public int? RegionID { get; set; }
        public int? LocationID { get; set; }
        public bool? WaybillPDF { get; set; }
        public bool Active { get; set; }
        public string BranchAlias { get; set; }
        public int? CompanyID { get; set; }
        public string FWDepotCode { get; set; }
        public int? BranchTypeID { get; set; }
        public int? TotalScanners { get; set; }
        public int? TotalSpareScanners { get; set; }
        public int? DeletedByUserID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? DeletedOn { get; set; }
        public int CreatedByUserID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime CreatedOn { get; set; }
    }
}
