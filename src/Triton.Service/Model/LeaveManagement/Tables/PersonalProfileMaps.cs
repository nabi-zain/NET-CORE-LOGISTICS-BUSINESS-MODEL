using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("PersonalProfileMaps")]
    public class PersonalProfileMaps
    {
        [Key]
        public int PersonalProfileMapId { get; set; }
        public int UserId { get; set; }
        public  int JobProfileId { get; set; }
    }
}
