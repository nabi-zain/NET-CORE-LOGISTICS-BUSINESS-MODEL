using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblSupplierDocuments")]
    public class tblSupplierDocuments
    {
        [Dapper.Contrib.Extensions.Key]
        public int DocumentID { get; set; }

        [Required]
        public int SupplierID { get; set; }
        [Required]

        public string ImgName { get; set; }
        [Required]
        public Byte[] ImgData { get; set; }
        [Required]
        public string ImgContentType { get; set; }
        [Required]
        public string ImgLength { get; set; }

        [Required]

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime DateUploaded { get; set; }
        public int DocumentCategoryID { get; set; }
        // nullable ExpirationDate
        [Required]

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? ExpirationDate { get; set; }
    }
}

