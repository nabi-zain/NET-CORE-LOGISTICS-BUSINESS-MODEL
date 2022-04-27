using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblSupplierDocumentCategory")]
    public class tblSupplierDocumentCategory
    {
        [Dapper.Contrib.Extensions.Key]
        public int DocumentCategoryID { get; set; }
        [Required]

        public String Description { get; set; }

    }
}

