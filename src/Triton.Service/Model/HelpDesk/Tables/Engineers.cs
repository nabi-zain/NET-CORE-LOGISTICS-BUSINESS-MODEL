using Dapper.Contrib.Extensions;

namespace Triton.Model.HelpDesk.Tables
{
    [Table("Enginners")]
    public class Engineers
    {
        public int EngineerID { get; set; }
        public string EngineerName { get; set; }
        public string EmailAddress { get; set; }
        public int UserID { get; set; }
        public byte Active { get; set; }
        public byte Payroll { get; set; }
    }
}
