using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.CRM.Custom
{
    public class CustomerMeetingsViewModel
    {
        public int CustomerMeetingID { get; set; }
        public string Name { get; set; }
        public DateTime LoggedOn { get; set; }
        public string Purpose { get; set; }
        public int CustomerVOCID { get; set; }
        public string Status { get; set; }
    }
}
