using Dapper.Contrib.Extensions;

namespace Triton.Service.Model.TFFDAT.Tables
{
    [Table("ICLOC")]
    public class ICLOC
    {
        public string LOCATION { get; set; }
        public decimal AUDTDATE { get; set; }
        public decimal AUDTTIME { get; set; }
        public string AUDTUSER { get; set; }
        public string AUDTORG { get; set; }
        public string DESC { get; set; }
        public string ADDRESS1 { get; set; }
        public string ADDRESS2 { get; set; }
        public string ADDRESS3 { get; set; }
        public string ADDRESS4 { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string ZIP { get; set; }
        public string COUNTRY { get; set; }
        public string PHONE { get; set; }
        public string FAX { get; set; }
        public string CONTACT { get; set; }
        public short SEGOVERRD { get; set; }
        public decimal DATELASTMN { get; set; }
        public short INACTIVE { get; set; }
        public decimal DATEINACTV { get; set; }
        public string SEGNUM1 { get; set; }
        public string SEGVAL1 { get; set; }
        public string SEGNUM2 { get; set; }
        public string SEGVAL2 { get; set; }
        public string SEGNUM3 { get; set; }
        public string SEGVAL3 { get; set; }
        public string SEGNUM4 { get; set; }
        public string SEGVAL4 { get; set; }
        public string SEGNUM5 { get; set; }
        public string SEGVAL5 { get; set; }
        public string SEGNUM6 { get; set; }
        public string SEGVAL6 { get; set; }
        public string SEGNUM7 { get; set; }
        public string SEGVAL7 { get; set; }
        public string SEGNUM8 { get; set; }
        public string SEGVAL8 { get; set; }
        public string SEGNUM9 { get; set; }
        public string SEGVAL9 { get; set; }
        public string EMAIL { get; set; }
        public string PHONEC { get; set; }
        public string FAXC { get; set; }
        public string EMAILC { get; set; }
        public short LOCTYPE { get; set; }
    }
}
