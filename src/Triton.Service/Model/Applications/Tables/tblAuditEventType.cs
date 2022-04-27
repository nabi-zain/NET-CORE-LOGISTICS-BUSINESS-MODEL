using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblAuditEventType")]
    public class tblAuditEventType
    {


        [Dapper.Contrib.Extensions.Key]
        public int AuditEventTypeID { get; set; }

        [Required]
        [DisplayName("Description")]
        public string EventDescription { get; set; }
        
    }
    }

