using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.CRM.Tables
{
    [Dapper.Contrib.Extensions.Table("CustRevisedRepSheet")]
    public class CustRevisedRepSheet
    {
        public string ACC { get; set; }
        [Column( "[ADJ REP]")]
        public string ADJREP { get; set; }
        public string F3 { get; set; }

        


    }
}
