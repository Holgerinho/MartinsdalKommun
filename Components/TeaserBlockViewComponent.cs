using EPiServer.Web.Mvc;
using MartinsdalKommun.Models.Blocks;

using MartinsdalKommun.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MartinsdalKommun.Components
{
    public class TeaserBlockViewComponent : BlockComponent <TeaserBlock> 
    {
        protected override IViewComponentResult InvokeComponent(TeaserBlock currentBlock)
        {
            var model = new TeaserBlockViewModel
            {
                Heading = currentBlock.Heading,
                Text = currentBlock.Text,
                Image = currentBlock.Image,
                Link = currentBlock.Link
            };

            return View(model);
        }

    }
}
