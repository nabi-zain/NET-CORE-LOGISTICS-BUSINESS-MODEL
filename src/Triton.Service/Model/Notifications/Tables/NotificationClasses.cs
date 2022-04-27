using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Notifications.Tables
{
    [Table("NotificationClasses")]
  public class NotificationClasses
    {
        public int NotificationClassID { get; set; }
        public string Description { get; set; }

    }
}
