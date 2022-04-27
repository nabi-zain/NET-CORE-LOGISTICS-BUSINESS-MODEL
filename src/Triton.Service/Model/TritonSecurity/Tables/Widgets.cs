using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonSecurity.Tables
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

        public int WidgetStatusID { get; set; }

        public int SystemID { get; set; }

        public bool iGlobal { get; set; }

        public string Scrolling { get; set; }

        public Systems System { get; set; }
    }
}