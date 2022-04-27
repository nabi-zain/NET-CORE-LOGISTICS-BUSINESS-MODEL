using Dapper.Contrib.Extensions;
using TableAttribute = Dapper.Contrib.Extensions.TableAttribute;

namespace Triton.Model.CRM.Tables
{
    [Table("AccountsOpenedTargets")]
    public class AccountsOpenedTargets
    {
        [Key]
        public int AccountsOpenedTargetID { get; set; }
        public int BranchSizeID { get; set; }
        public int FinanceMonth { get; set; }
        public int FinanceYear { get; set; }
        public int Target { get; set; }
        public decimal CommValue { get; set; }
    }
}
