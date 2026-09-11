using EPiServer.Web.Mvc;
using MartinsdalKommun.Models.Blocks;
using MartinsdalKommun.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MartinsdalKommun.Components
{
    public class ContactBlockViewComponent : BlockComponent <ContactBlock>
    { 
        protected override IViewComponentResult InvokeComponent(ContactBlock currentBlock)
        {
            var model = new ContactBlockViewModel
            {
                Image = currentBlock.Image,
                Heading = currentBlock.Heading,
                Subheading = currentBlock.Subheading,
                Text = currentBlock.Text,
                Phone = currentBlock.Phone,
                Email = currentBlock.Email
            };

            return View(model);
        }
    }
}

  
