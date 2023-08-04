using Smusic.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Smusic.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Logo")]
        public string Logo { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name ="Description")]
        public string Descrption { get; set; }
        [Display(Name = "AlbumCategory")]
        public Albumcategory AlbumCategory { get; set; }
        [Display(Name="ActorName")]
        public string ActorName { get; set; }
        [Display(Name ="SongName")]
        public string SongName { get; set; }


        //relationships
        public List<Album_Actor> Albums_Actors { get; set; }
        //songs
        public int SongId { get; set; }
        [ForeignKey("SongId")]
        public Song Songs { get; set; }
    }
}
