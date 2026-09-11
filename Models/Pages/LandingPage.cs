using System.ComponentModel.DataAnnotations;

namespace MartinsdalKommun.Models.Pages
{
    [ContentType(
        DisplayName = "Landningssida",
        GUID = "4f5f742a-622b-43ae-97b0-eef74c7bca3f",
        Description = "En landningssida för webbplatsen.",
        AvailableInEditMode = true)]
    public class LandingPage : PageData
    {
        [Display(
            Name = "Titel",
            Description = "Titeln på landningssidan.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string? Title { get; set; }

        [Display(
            Name = "Huvudinnehållsområde",
            Description = "Behållare för huvudinnehåll.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual ContentArea? MainContentArea { get; set; }
    }
}
