using EPiServer.Web;

namespace MartinsdalKommun.Models.ViewModels
{
    public class TeaserBlockViewModel
    {
        public string? Heading { get; set; }

        public string? Text { get; set; }

        public ContentReference? Image { get; set; }

        public Url? Link { get; set; }
    }
}
