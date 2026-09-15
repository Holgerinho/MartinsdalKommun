using EPiServer.Framework.DataAnnotations;

namespace MartinsdalKommun.Models.Media
{

    [ContentType(
        DisplayName = "Bild",
        GUID = "8c9e4f5a-6b7c-4d8e-9f01-2a3b4c5d6e7f",
        Description = "Bildfiler som används på webbplatsen.")]
  //  [MediaDescriptor(ExtensionString = ".png, .webp")]
    public class ImageFile : ImageData
    {

    }
}