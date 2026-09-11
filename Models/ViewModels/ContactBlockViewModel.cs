using System.ComponentModel.DataAnnotations;
using MartinsdalKommun.Models.Pages;
using EPiServer.Web;
using Microsoft.AspNetCore.Html;

namespace MartinsdalKommun.Models.ViewModels
{
    public class ContactBlockViewModel
    {

        public ContentReference? Image { get; set; }

        public string? Heading { get; set; }

        public string? Subheading { get; set; }

        public string? Text { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }



    }
}
