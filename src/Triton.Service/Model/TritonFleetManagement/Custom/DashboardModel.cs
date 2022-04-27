using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.TritonFleetManagement.Custom
{
    public class DashboardModel
    {
        public List<GeneralRepairsModel> GeneralRepairsModelList { get; set; }
        public BookingsStatisticsModel BookingsStatisticsModel { get; set; }
        public List<BookingsBarGraphModel> BookingsBarGraphModelList { get; set; }
    }
}
