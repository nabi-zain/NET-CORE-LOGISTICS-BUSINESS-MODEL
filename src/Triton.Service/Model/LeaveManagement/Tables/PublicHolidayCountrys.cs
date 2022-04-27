using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("PublicHolidayCountrys")]
    public class PublicHolidayCountrys
    {
        [Key]
        public int PublicHolidayID { get; set; }
        public DateTime? PublicHolidayDate { get; set; }
        public  string Description { get; set; }
        public int CountryID { get; set; }
    }
}
