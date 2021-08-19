using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArtWebshop.Models
{
    public class Artist
    {
        [Key]
        public string ArtistId { get; set; }
        public string UserId { get; set; }

        [Display(Name ="Konstnär")]
        public string ArtistName { get; set; }
        
        [Display(Name ="Profilbild")]
        public string ProfilePicture { get; set; }
        
        [Display(Name ="Presentation")]
        public string Presentation { get; set; }

        public List<ArtistRow> ArtistRows { get; set; }
    }
}