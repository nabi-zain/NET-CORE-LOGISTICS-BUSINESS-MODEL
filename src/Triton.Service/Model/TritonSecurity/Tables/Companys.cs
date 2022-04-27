using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("Companys")]
    public class Companys
    {

        [Dapper.Contrib.Extensions.Key]
        public int CompanyID { get; set; }
        public string Description { get; set; }
        [Required]
        public string VatNo { get; set; }
        [Required]
        public string Contact { get; set; }
        [Required]
        public string ContacNumber { get; set; }
        [Required]
        public string RegNo { get; set; }
        [Required]
        [DisplayName("Shorty Company Name")]
        public string  ShortCompanyName {get;set;}
        [Required]
        public string CompanyLogo { get; set; }

        [Required]
        [DisplayName("Bulk Email Address")]
        public string BulkEmailAddress { get; set; }

        public string HasVehicle { get; set; }

    }
}
