using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonGroup.Tables
{
    public class LookUpCodeCategorySystemMaps
    {
        [Key]
        public long LookUpCodeCategorySystemMapID { get; set; }
        public int LookUpCodeCategoryID { get; set; }
        public int SystemID { get; set; }
    }
}
