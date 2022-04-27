using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("CostCentres")]
   public class CostCentres
    {
        [Key]
        public int CostCentreID { get; set; }
        [Required]
        [DisplayName("Branch Code")]
        public int BranchCode { get; set; }

        [DisplayName("Branch Name")]
        [Required]
        public string BranchName { get; set; }

        [DisplayName("Branch Full Name")]
        [Required]
        public string BranchFullName { get; set; }

        [DisplayName("Branch Add 1 ")]
        [Required]
        public string BranchAdd1 { get; set; }

        [DisplayName("Branch Add 2")]
        [Required]
        public string BranchAdd2 { get; set; }


        [DisplayName("Branch Add 3")]
        [Required]
        public string BranchAdd3 { get; set; }

        [DisplayName("Branch Add 4 ")]
        [Required]
        public string BranchAdd4 { get; set; }

        [Required]
        public string BranchTel { get; set; }

        [Required]
        public string BranchFax { get; set; }

        [DisplayName("Branch Daily Sales Order")]
        [Required]
        public string BranchDailySalesOrder { get; set; }

        [Required]
        public string VipCode { get; set; }

        [DisplayName("Cost Centre Active")]
        public string CostCentreActive { get; set; }

        [DisplayName("Branch Category")]
        [Required]
        public int BranchCategoryID { get; set; }

        [Required]
        public int RegionID { get; set; }

        [Required]
        public int LocationID { get; set; }

        [DisplayName("Bbit Cost Centre Code")]
        [Required]
        public string DbitCostCentreCode { get; set; }

        [DisplayName(" Is Triton Company ")]
        public string IsTritonCompany { get; set; }

        [Required]
        public int CompanyID { get; set; }

        [DisplayName("Is South African ")]
        [Required]
        public string IsSouthAfrican { get; set; }

        [Required]
        public int CountryID { get; set; }

    }
}
