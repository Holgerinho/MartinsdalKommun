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
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "The title of the start page.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Title { get; set; }
        
        [CultureSpecific]
        [Display(
            Name = "Main Body",
            Description = "The main body of the start page.",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual XhtmlString MainBody { get; set; }
    }
}
