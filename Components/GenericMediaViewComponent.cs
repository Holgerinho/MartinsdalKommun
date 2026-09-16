using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using MartinsdalKommun.Models.Media;
using Microsoft.AspNetCore.Mvc;

namespace MartinsdalKommun.Components
{
    public class GenericMediaViewComponent : PartialContentComponent<GenericMedia>
    {
        private readonly UrlResolver _urlResolver;

        public GenericMediaViewComponent(UrlResolver urlResolver)
        {
            _urlResolver = urlResolver;
        }

        protected override IViewComponentResult InvokeComponent(GenericMedia currentContent)
        {
            return View(currentContent);
        }
    }
}
