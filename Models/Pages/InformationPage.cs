using System.ComponentModel.DataAnnotations;

namespace MartinsdalKommun.Models.Pages
{
    [ContentType(
        DisplayName = "Informationssida",
        GUID = "094ffa90-a4cd-40ab-ba85-bfe473df4e01",
        Description = "En informationssida för webbplatsen.",
        AvailableInEditMode = true)]
    public class InformationPage : PageData
    {
        [Display(
            Name = "Titel",
            Description = "Titeln på informationssidan.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string? Title { get; set; }

        [Display(
            Name = "Huvudtext",
            Description = "Huvudtexten på informationssidan.",
            GroupName = SystemTabNames.Content,
            Order = 15)]
        public virtual XhtmlString? MainText { get; set; }

        [Display(
            Name = "Huvudinnehållsområde",
            Description = "Behållare för huvudinnehåll.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual ContentArea? MainContentArea { get; set; }
    }
}
