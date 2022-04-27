namespace Triton.Service.Utils
{
    public interface ILocalisationService
    {
        string HtmlTemplate { get; }
        string HtmlRoot { get; }
    }

    public class LocalisationService : ILocalisationService
    {
        public string HtmlTemplate => "front/front-v3.2.1";
        public string HtmlRoot => "";
    }
}
