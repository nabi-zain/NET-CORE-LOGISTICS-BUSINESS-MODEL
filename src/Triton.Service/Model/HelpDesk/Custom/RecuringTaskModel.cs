using Triton.Model.HelpDesk.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.HelpDesk.Custom
{
    public class RecuringTaskModel
    {
        public RecuringTaskModel RecuringTasks { get; set; }
        public TimeFrequency TimeFrequency { get; set; }
        public Engineers Engineers { get; set; }
        public Branches Branches { get; set; }
        public Priority Priority { get; set; }
        public Categorys Categorys { get; set; }
        public Status Status { get; set; }
        public Engineers Engineer { get; set; }
    }
}
