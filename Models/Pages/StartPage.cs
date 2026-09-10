using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace MartinsdalKommun.Models.Pages
{
    [ContentType(
        DisplayName = "Startsida", 
        GUID = "f3c1e2b0-4d5a-4c6b-9f1e-2a3b4c5d6e7f", 
        Description = "The start page of the website.",
        AvailableInEditMode = true)]
    public class StartPage : PageData
    {
        [Display(
            Name = "Main Content Area",
            Description = "The main content area of the start page.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual ContentArea? MainContentArea { get; set; }
    }
}
