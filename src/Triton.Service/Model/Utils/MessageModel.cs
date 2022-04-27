using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Utils
{
    public class MessageModel
    {
        [Required] public string Title { get; set; }

        [Required] public string Message { get; set; }

        public string Icon { get; set; }

        [Required] public string Controller { get; set; }

        [Required] public string Route { get; set; }

        public string ButttonText { get; set; } = "Continue";

        public string Type { get; set; }

        public string Url { get; set; }
        public string RootPath { get; set; }
        public string ScientificNotionMessage { get; set; }
    }
}
