using ArtWebshop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Data
{
    public static class SeedingProducts
    {
        public static void seed(ModelBuilder modelBuilder)
        {
            string dirPaintings = "Images/Paintings/";
            string dirThumbnails = "Images/Thumbnails/";

            string monaLisaPictLink = dirPaintings + "Prints/Mona Lisa.jpg";
            string monaLisaThumbLink = dirThumbnails + "Prints/Mona Lisa (thumb).jpg";
            string monaLisaLongDesc = "Mona Lisa, also called Portrait of Lisa Gherardini, wife of Francesco del Giocondo, Italian La Gioconda, or French La Joconde, oil painting on a poplar wood panel by Leonardo da Vinci, probably the world’s most famous painting. It was painted sometime between 1503 and 1519, when Leonardo was living in Florence, and it now hangs in the Louvre Museum, Paris, where it remained an object of pilgrimage in the 21st century. The sitter’s mysterious smile and her unproven identity have made the painting a source of ongoing investigation and fascination.";
            modelBuilder = SetProduct("Mona Lisa", 77, 53, "A mysterious woman", monaLisaLongDesc, "Print", "Oil on wood Panel",
                new DateTime(1503), 50.50M, monaLisaPictLink, monaLisaThumbLink, modelBuilder);

            string nattvardenPictLink = dirPaintings + "Prints/Nattvarden.jpg";
            string nattvardenThumbLink = dirThumbnails + "Prints/Nattvarden (thumb).jpg";
            string nattvardenLongDesc = "Leonardo Da Vinci";
            modelBuilder = SetProduct("Nattvarden", 880, 460, "The last supper", nattvardenLongDesc, "Print", "Olja på duk",
                new DateTime(1495), 33.00M, nattvardenPictLink, nattvardenThumbLink, modelBuilder);

            string skrietPictLink = dirPaintings + "Prints/Skriet.jpg";
            string skrietThumbLink = dirThumbnails + "Prints/Skriet (thumb).jpg";
            string skrietLongDesc = "";
            modelBuilder = SetProduct("Nattvarden", 880, 460, "Edvard Munch", skrietLongDesc, "Print", "Olja, tempera och pastell på papp",
                new DateTime(1903), 15.505M, skrietPictLink, skrietThumbLink, modelBuilder);

            string utslitenPictLink = dirPaintings + "Prints/Utsliten.jpg";
            string utslitenThumbLink = dirThumbnails + "Prints/Utsliten (thumb).jpg";
            string utslitenLongDesc = "";
            modelBuilder = SetProduct("Utsliten", 880, 460, "Edvard Munch", utslitenLongDesc, "Print", "Postexpressionism: Teckning penna på vattenfärgat papper",
                new DateTime(1882), 18.505M, utslitenPictLink, utslitenThumbLink, modelBuilder);



        }
        public static ModelBuilder SetProduct(string title, int width, int height, string shortDesc, string longDesc, string category, 
            string style, DateTime createDate, decimal price, string pictLink, string thumbLink, ModelBuilder modelBuilder)
        {
            string productId = Guid.NewGuid().ToString();

            Product product = new Product
            {
                ProductId = productId,
                Title = title,
                Width = width,     // cm
                Height = height,    // cm
                ShortDescription = shortDesc,
                LongDescription = longDesc,
                Category = category,
                Style = style,
                CreationDate = createDate,
                Price = price,
                PictureLink = pictLink,
                ThumbnailLink = thumbLink
            };

            modelBuilder.Entity<ApplicationUser>().HasData(product);

            return modelBuilder;
        }
    }
}