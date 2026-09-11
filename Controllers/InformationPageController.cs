using EPiServer.Web.Mvc;
using MartinsdalKommun.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace MartinsdalKommun.Controllers
{
    public class InformationPageController : PageController<InformationPage>
    {
        public IActionResult Index(InformationPage currentPage)
        {
            return View(currentPage);
        }
    }
}