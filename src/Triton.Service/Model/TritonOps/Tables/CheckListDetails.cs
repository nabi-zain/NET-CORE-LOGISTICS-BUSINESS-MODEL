using System;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonOps.Tables
{
    [Table("CheckListDetails")]

    public class CheckListDetails
    {
        [Dapper.Contrib.Extensions.Key]
        public int CheckListDetailID { get; set; }
        public int CheckListID { get; set; }
        public int Amount { get; set; }
        public bool? Checked { get; set; } 
        public string Name { get; set; }
      
    
    }
}
