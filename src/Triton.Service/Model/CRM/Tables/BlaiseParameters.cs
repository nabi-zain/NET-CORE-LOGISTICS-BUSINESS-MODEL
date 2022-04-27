
using TableAttribute = Dapper.Contrib.Extensions.TableAttribute;

namespace Triton.Model.CRM.Tables
{
    [Table("BlaiseParameters")]
    public class BlaiseParameters
    {
        public string Parameter1 { get; set; }
        public string Parameter2 { get; set; }

    }
}
