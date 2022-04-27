using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonSecurity.StoredProcs
{
    public class proc_Branch_Contact_Info : Branches
    {

        public string Name { get; set; } // varchar(100), not null
        public string EmailAddress { get; set; } // varchar(100), null


    }
}