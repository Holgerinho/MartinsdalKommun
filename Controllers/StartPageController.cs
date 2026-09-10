using EPiServer.Web.Mvc;
using MartinsdalKommun.Models.Pages;
using MartinsdalKommun.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
