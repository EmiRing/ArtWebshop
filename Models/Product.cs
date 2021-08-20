using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Models
{
    public class Product
    {
        [Key]
        public string ProductId { get; set; }
        
        [Required]        
        [Display(Name = "Tavla")]
        public string Title { get; set; }
        
        [Required]
        [Display(Name = "Bredd")]
        public int Width { get; set; }
        
        [Required]
        [Display(Name = "Höjd")]
        public int Height { get; set; }
        
        [Required]
        [Display(Name ="Sammanfattning")]
        public string ShortDescription { get; set; }
        
        [Display(Name = "Beskrivning")]
        public string LongDescription { get; set; }
        
        [Required]
        [Display(Name ="Kategori")]
        public string Category { get; set; }
        
        [Display(Name ="Stil")]
        public string Style { get; set; }

        [Display(Name = "Skapad år")]
        public string CreationDate { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name ="Pris")]
        public decimal Price { get; set; }

        [MaxLength(260)]         // Max path length in Windows 260 char
        public string PictureLink { get; set; }
        
        [MaxLength(260)]         // Max path length in Windows 260 char
        public string ThumbnailLink { get; set; }

        public bool IsPaintingOfTheWeek { get; set; }
        
        [Display(Name ="I lager")]
        public int Stock { get; set; }

        public bool IsPublic { get; set; }

        [ForeignKey("ArtistId")]
        public string ArtistId { get; set; }
        public Artist Artist { get; set; }
        public List<ArtistRow> ArtistRows { get; set; }
        public List<OrderRow> OrderRows { get; set; }

        public static implicit operator Product(List<Product> v)
        {
            throw new NotImplementedException();
        }
    }
}