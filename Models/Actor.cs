using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Smusic.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="ProfilePictureURL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="FullName")]
        public string FullName { get; set; }
        [Display(Name ="Biography")]
        public string Bio { get; set; }
        //relationships
            
        public List<Album_Actor> Albums_Actors { get; set; }
    }
}
