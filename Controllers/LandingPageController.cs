using EPiServer.Web.Mvc;
using MartinsdalKommun.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace MartinsdalKommun.Controllers
{
    public class LandingPageController : PageController<LandingPage>
    {
        public IActionResult Index(LandingPage currentPage)
        {
            return View(currentPage);
        }
    }
}