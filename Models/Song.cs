using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Smusic.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Title")]
        public string Title { get; set; }
        [Display(Name ="Language")]
        public string Language { get; set; }
        [Display(Name ="SongURL")]
        public string SongURL { get; set; }
        //relationships
        public List<Album> Albums { get; set; }
    }
}
