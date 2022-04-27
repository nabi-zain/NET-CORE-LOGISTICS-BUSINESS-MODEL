using Dapper.Contrib.Extensions;

namespace Triton.Model.HelpDesk.Tables
{
    [Table("Status")]
    public class Status
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }

    }
}
