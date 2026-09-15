using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using MartinsdalKommun.Models.Media;
using Microsoft.AspNetCore.Mvc;

namespace MartinsdalKommun.Components
{
    public class ImageFileViewComponent : PartialContentComponent<ImageFile>
    {
        private readonly UrlResolver _urlResolver;

        public ImageFileViewComponent(UrlResolver urlResolver)
        {
            _urlResolver = urlResolver;
        }

        protected override IViewComponentResult InvokeComponent(ImageFile currentContent)
        {
            return View(currentContent);
        }
    }

}
