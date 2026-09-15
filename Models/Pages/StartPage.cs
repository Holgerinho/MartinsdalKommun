using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using MartinsdalKommun.Infrastructure;
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
            Name = "Innehållsområde",
            Description = "Innehållsområdet på startsidan.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual ContentArea? MainContentArea { get; set; }

        [Display(
            Name = "Rubrik sidhuvud",
            Description = "Rubriken för sidhuvudet.",
            GroupName = SiteTabNames.Header,
            Order = 20)]
        [CultureSpecific]
        public virtual string? HeaderTitle { get; set; }

        [Display(
            Name = "Sidhuvud",
            Description = "Sidhuvudets innehål.",
            GroupName = SiteTabNames.Header,
            Order = 30)]
        [CultureSpecific]
        public virtual string? HeaderText { get; set; }

        [Display(
            Name = "Sidfot",
            Description = "Sidfotens innehål.",
            GroupName = SiteTabNames.Footer,
            Order = 40)]
        public virtual XhtmlString? FooterText { get; set; }

        [Display(
            Name = "Innehållsnod",
            Description = "Välj nod som du vill hämta sidor som ska arkiveras från.",
            GroupName = SystemTabNames.Content,
            Order = 50)]
        public virtual ContentReference? LandingPageRoot { get; set; }
        //[ScaffoldColumn(false)]

        [Display(
            Name = "Arkivnod",
            Description = "Välj nod som du vill arkivera sidor till.",
            GroupName = SystemTabNames.Content,
            Order = 60)]
        public virtual ContentReference? ArchiveRoot { get; set; } 
    }
}
