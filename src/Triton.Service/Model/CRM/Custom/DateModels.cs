using System.ComponentModel;

namespace  Triton.Model.CRM.Custom
{
    public class DateModels
    {
        [DisplayName("Day Number")]
        public int Week_Day_Number { get; set; }

        [DisplayName("Day Name")]
        public string Week_Day_Name { get; set; }

        [DisplayName("Total")]
        public int ScheduleTotal { get; set; }
    }
}
