using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblSupplierTypes")]
    public class tblSupplierTypes
    {
        [Dapper.Contrib.Extensions.Key]
        public int SupplierTypeID { get; set; }

        [Required]
        public string SupplierTypeDesc { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime StatusDate { get; set; }


    }
}

