using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.CRM.StoredProcs
{
    public class proc_Waybills_TransportType_Select
    {
        public string TransportType { get; set; }
        [Column("Due Today")]
        public string DueToday { get; set; }
        [Column("ODSDue Today")]
        public string OSDueToday { get; set; }
    }
}
