using ArtWebshop.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ArtWebshop.Data
{
    public static class SeedingProducts
    {
        private static string dirPaintings = "/Images/Originals/Paintings/";
        private static string dirThumbnails = "/Images/Originals/Thumbnails/";
        public static void seed(ModelBuilder modelBuilder)
        {
            string artistId = Guid.NewGuid().ToString();
            SetArtist(artistId, "Leonardo da Vinci", modelBuilder);
            string monaLisaPictLink = dirPaintings + "Mona Lisa.jpg";
            string monaLisaThumbLink = dirThumbnails + "/Mona Lisa (thumb).jpg";
            string monaLisaLongDesc = "Mona Lisa, also called Portrait of Lisa Gherardini, wife of Francesco del Giocondo, Italian La Gioconda, or French La Joconde, oil painting on a poplar wood panel by Leonardo da Vinci, probably the world’s most famous painting.";
            modelBuilder = SetProduct("Mona Lisa", 77, 53, "A mysterious woman", monaLisaLongDesc, "Print", "Oil on wood Panel",
                "1503", 50.50M, monaLisaPictLink, monaLisaThumbLink, false, 15, artistId, modelBuilder);

            artistId = Guid.NewGuid().ToString();
            SetArtist(artistId, "Leonardo da Vinci", modelBuilder);
            string lastSupperPictLink = dirPaintings + "The Last Supper.jpg";
            string lastSupperThumbLink = dirThumbnails + "Nattvarden (thumb).jpg";
            string lastSupperLongDesc = "Long, long, long description";
            modelBuilder = SetProduct("The Last Supper", 880, 460, "Short description", lastSupperLongDesc, "Print", "Olja på duk",
                "1495", 33.00M, lastSupperPictLink, lastSupperThumbLink, false, 3, artistId, modelBuilder);

            artistId = Guid.NewGuid().ToString();
            SetArtist(artistId, "Edvard Munch", modelBuilder);
            string skrietPictLink = dirPaintings + "Skriet.jpg";
            string skrietThumbLink = dirThumbnails + "Skriet (thumb).";
            string skrietLongDesc = "Long, long, long description";
            modelBuilder = SetProduct("Skriet", 880, 460, "Short description", skrietLongDesc, "Print", "Olja, tempera och pastell på papp",
                "1903", 15.505M, skrietPictLink, skrietThumbLink, true, 150, artistId, modelBuilder);

            artistId = Guid.NewGuid().ToString();
            SetArtist(artistId, "Vincent van Gogh", modelBuilder);
            string utslitenPictLink = dirPaintings + "Utsliten.jpg";
            string utslitenThumbLink = dirThumbnails + "Utsliten (thumb).jpg";
            string utslitenLongDesc = "Long, long, long description";
            modelBuilder = SetProduct("Utsliten", 880, 460, "Short description", utslitenLongDesc, "Print", "Postexpressionism: Teckning penna på vattenfärgat papper",
                "1882", 18.505M, utslitenPictLink, utslitenThumbLink, false, 5, artistId, modelBuilder);

            artistId = Guid.NewGuid().ToString();
            SetArtist(artistId, "Sandro Botticelli", modelBuilder);
            string birthOfVenusPictLink = dirPaintings + "Venus Födelse.jpg";
            string birthOfVenusThumbLink = dirThumbnails + "Venus Födelse (thumb).jpg";
            string birthOfVenusLongDesc = "Long, long, long description";
            modelBuilder = SetProduct("Venus Födelse", 880, 460, "Kort beskrivning", birthOfVenusLongDesc, "Print", "Tempera på duk",
                "1485", 89.50M, birthOfVenusPictLink, birthOfVenusThumbLink, false, 53, artistId, modelBuilder);
        }

        public static ModelBuilder SetArtist(string artistId, string artistName, ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(
            new Artist
            {
                ArtistId = artistId,
                ArtistName = artistName
            });

            return modelBuilder;
        }
        public static ModelBuilder SetProduct(string title, int width, int height, string shortDesc, string longDesc, string category, 
            string style, string createDate, decimal price, string pictLink, string thumbLink, bool isPaintingOfTheWeek, int inStock, 
            string artistId, ModelBuilder modelBuilder)
        {
            string productId = Guid.NewGuid().ToString();

            Product product = new Product
            {
                ProductId = productId,
                Title = title,
                Width = width,      // cm
                Height = height,    // cm
                ShortDescription = shortDesc,
                LongDescription = longDesc,
                Category = category,
                Style = style,
                CreationDate = createDate,
                Price = price,
                PictureLink = pictLink,
                ThumbnailLink = thumbLink,
                IsPaintingOfTheWeek = false,
                Stock = inStock,
                ArtistId = artistId 
            };

            modelBuilder.Entity<Product>().HasData(product);

            return modelBuilder;
        }
    }
}