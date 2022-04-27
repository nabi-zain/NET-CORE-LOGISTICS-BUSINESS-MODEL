using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("BranchTypes")]
    public class BranchTypes
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int BranchTypeID { get; set; }

        [Required]
        public string BranchTypeDescription { get; set; }

        [Required]
        public int SortOrder { get; set; } 

    }
}
