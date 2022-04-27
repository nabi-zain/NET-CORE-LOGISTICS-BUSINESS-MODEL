using Dapper.Contrib.Extensions;

namespace Triton.Model.HelpDesk.Tables
{
    [Table("TimeFrequency")]
    public class TimeFrequency
    {
        public int TimeFrequencyID { get; set; }
        public string Description { get; set; }
    }
}
