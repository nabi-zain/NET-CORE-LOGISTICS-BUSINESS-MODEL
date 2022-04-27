using System.ComponentModel;
using Dapper.Contrib.Extensions;

namespace Triton.Model.HelpDesk.Tables
{
    [Table("Priority")]
    public class Priority
    {
        [Key]
        public int PriorityID { get; set; }
        [DisplayName("Priority Level")]
        public string Description { get; set; }
    }
}
