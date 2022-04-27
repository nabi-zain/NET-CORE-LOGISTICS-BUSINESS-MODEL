using System;

namespace Triton.Model.TritonSecurity.StoredProcs
{
    public class proc_WidgetUserMapsByColumnIDAndUserID_Select
    {
        public int WidgetUserMapID { get; set; }

        public int WidgetID { get; set; }

        public int ColumnID { get; set; }

        public int SortNo { get; set; }

        public bool Collapsed { get; set; }

        public int UserID { get; set; }

        public int OwnerSystemID { get; set; }

        public DateTime? DeletedOn { get; set; }

        public int WidgetWidgetID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string URL { get; set; }

        public string Width { get; set; }

        public string Height { get; set; }

        public string Icon { get; set; }

        public string Scrolling { get; set; }

        public int SystemID { get; set; }

        public string SystemDescription { get; set; }

        public string ShortDescription { get; set; }

        public string DatabaseName { get; set; }

        public string PrimaryObjectUrl { get; set; }

        public int? HelpDeskEngineerID { get; set; }

        public bool Active { get; set; }

        public string Colour { get; set; }
    }
}