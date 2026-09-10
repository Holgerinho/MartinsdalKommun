using EPiServer.Web.Mvc;
using MartinsdalKommun.Models.Blocks;
using Microsoft.AspNetCore.Mvc;

namespace MartinsdalKommun.Components
{
    public class ContactBlockViewComponent : BlockComponent <ContactBlock>
    {
        protected override IViewComponentResult InvokeComponent(ContactBlock currentBlock)
        {
            return View(currentBlock);

        }
    }
}

  
