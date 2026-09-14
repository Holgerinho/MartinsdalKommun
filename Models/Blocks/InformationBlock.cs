using EPiServer.Core.Internal;
using System.ComponentModel.DataAnnotations;

namespace MartinsdalKommun.Models.Blocks
{
    [ContentType(
        DisplayName = "Informationsblock",
        GUID = "2e067829-8f7f-482c-a1f1-b92a3223652c",
        Description = "Informationsruta",
        AvailableInEditMode = true)]
    public class InformationBlock : BlockData
    {
        [Display(
            Name = "Rubrik",
            Description = "Informationsrutans rubrik",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string? Heading { get; set; }

        [Display(
            Name = "Informationstext",
            Description = "Informationsrutans innehåll",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString? Text { get; set; }
    }
}
