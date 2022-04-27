using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("Customervops")]
    public class Customervops
    {
        [Key]
        public int CustomerVOPID { get; set; }
        public int CustomerVOCID { get; set; }
        public DateTime DateLodged { get; set; }
        public DateTime LastActivityDate { get; set; }
        public string Resolvee { get; set; }
        public int ExecutorID { get; set; }
        public string SolutionDescription { get; set; }
        public byte PhoneCall { get; set; }
    }
}
