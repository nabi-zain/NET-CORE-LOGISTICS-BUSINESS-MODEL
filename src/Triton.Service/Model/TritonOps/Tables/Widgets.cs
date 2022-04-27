using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonOps.Tables
{
    [Table("Widgets")]
    public class Widgets
    {
        [Dapper.Contrib.Extensions.Key]
        public int WidgetID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }        
        public string URL { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Icon { get; set; }
    }
}
