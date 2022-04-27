using Dapper.Contrib.Extensions;

namespace Triton.Service.Model.TFFDAT.Tables
{
    [Table("ICCATG")]
    public class ICCATG
    {
        public string CATEGORY { get; set; }
        public decimal AUDTDATE { get; set; }
        public decimal AUDTTIME { get; set; }
        public string AUDTUSER { get; set; }
        public string AUDTORG { get; set; }
        public string DESC { get; set; }
        public string COGSACCT { get; set; }
        public string REVENUACCT { get; set; }
        public string RETURNACCT { get; set; }
        public string VARIANACCT { get; set; }
        public short COMMSNPAID { get; set; }
        public decimal COMMSNRATE { get; set; }
        public short INACTIVE { get; set; }
        public decimal DATELASTMN { get; set; }
        public string DEFPRICLST { get; set; }
        public decimal DATEINACTV { get; set; }
        public string DAMAGEACCT { get; set; }
        public string ICSEXPACCT { get; set; }
    }
}
