using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace MartinsdalKommun.Models.Blocks
{
    [ContentType(DisplayName = "Puffblock", 
        GUID = "f1c2e3d4-5678-90ab-cdef-1234567890ab", 
        Description = "Ett puffblock med en bild, rubrik och beskrivning.", 
        AvailableInEditMode = true)]
    public class TeaserBlock
    {
        [Display(
            Name = "Rubrik",
            Description = "Rubriken på puffblocket.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string? Heading { get; set; }

        [Display(
            Name = "Text",
            Description = "Texten i puffblocket.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string? Text { get; set; }

        [Display(
            Name = "Bild",
            Description = "Bilden i puffblocket.",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference? Image { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 40)]
        public virtual PageReference Link { get; set; }
    }
}
