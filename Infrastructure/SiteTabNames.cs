using EPiServer.DataAbstraction;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MartinsdalKommun.Infrastructure
{
    [GroupDefinitions]
    public static class SiteTabNames
    {
        [Display(
            Name = "Sidhuvud",
            Order = 40)]
        public const string Header = "Sidhuvud";
        [Display(
            Name = "Sidfot",
            Order = 50)]
        public const string Footer = "Sidfot";
    }
}
