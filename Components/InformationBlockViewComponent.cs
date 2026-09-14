using EPiServer.Web.Mvc;
using MartinsdalKommun.Models.Blocks;
using MartinsdalKommun.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MartinsdalKommun.Components
{
    public class InformationBlockViewComponent : BlockComponent<InformationBlock>
    {
        protected override IViewComponentResult InvokeComponent(InformationBlock currentBlock)
        {
            var model = new InformationBlockViewModel
            {
                Heading = currentBlock.Heading,
                Text = currentBlock.Text
            };

            return View(model);
        }
    }
}
