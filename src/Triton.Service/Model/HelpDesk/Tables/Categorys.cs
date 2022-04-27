using System.ComponentModel;
using Dapper.Contrib.Extensions;

namespace Triton.Model.HelpDesk.Tables
{
    [Table("Category")]
    public class Categorys
    {
        [Key]
        public int CategoryID { get; set; }
        [DisplayName("Category")]
        public string Description { get; set; }
    }
}
