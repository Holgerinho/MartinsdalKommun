using EPiServer.Core;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using EPiServer.Web;

namespace MartinsdalKommun.Models.Blocks
{
    public class ContactBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Bild",
            Description = "Bild för kontaktblocket",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference? Image { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Rubrik",
            Description = "Rubrik för kontaktblocket",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string? Heading { get; set; }
        
        [CultureSpecific]
        [Display(
            Name = "Underrubrik",
            Description = "Underrubrik för kontaktblocket",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string? Subheading { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Text",
           Description = "Text för kontaktblocket",
           GroupName = SystemTabNames.Content,
           Order = 30)]
        public virtual string? Text { get; set; }

        [CultureSpecific]
        [Display(
         Name = "Telefon",
         Description = "Telefonnummer för kontaktblocket",
         GroupName = SystemTabNames.Content,
         Order = 40)]
        public virtual string? Phone { get; set; }

        [CultureSpecific]
        [Display(
            Name = "E-post",
            Description = "E-postadress för kontaktblocket",
            GroupName = SystemTabNames.Content,
            Order = 50)]
        public virtual string? Email { get; set; }

    }
}
