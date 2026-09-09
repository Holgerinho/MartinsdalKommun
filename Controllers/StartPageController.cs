using MartinsdalKommun.Models.Pages;
using Microsoft.AspNetCore.Mvc;
using EPiServer.Web.Mvc;

namespace MartinsdalKommun.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public IActionResult Index(StartPage currentPage)
        {
            return View(currentPage);
        }
    }
}
