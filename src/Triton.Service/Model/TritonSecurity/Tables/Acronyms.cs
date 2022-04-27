using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("Acronyms")]
   public class Acronyms
    {
        [Key]
         public int AcronymID { get; set; }
         public  string Term { get; set; }
         public string Definition { get; set; }

    }
}
