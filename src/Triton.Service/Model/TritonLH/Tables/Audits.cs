using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;

namespace Triton.Model.TritonLH.Tables
{
    [Table("Audits")]
    public class Audits
    {
        [Key]
        public long AuditID { get; set; }

        public string Type { get; set; }
        public string TableName { get; set; }
        public string PKColumnName { get; set; }
        public long? PK { get; set; }

        [DisplayName("Field Name")]
        public string FieldName { get; set; }

        [DisplayName("Old Value")]
        public string OldValue { get; set; }

        [DisplayName("New Value")]
        public string NewValue { get; set; }

        [DisplayName("Created On")]
        public DateTime? CreatedOn { get; set; }

        [DisplayName("Created By")]
        public int? CreatedByUserID { get; set; }
    }
}