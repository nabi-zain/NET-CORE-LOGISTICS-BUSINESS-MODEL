using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblSupplierTerms")]
    public class tblSupplierTerms 
    {
        [Dapper.Contrib.Extensions.Key]
        public int SupplierTermID { get; set; }

        [Required]
        public string SupplierTerm { get; set; }
        [Required]
        public string SupplierTermDesc { get; set; }
        [Required]
        public int StatusID { get; set; }
        [Required]

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime StatusDate { get; set; }


    }
}

