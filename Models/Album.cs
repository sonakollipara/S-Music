using System.ComponentModel.DataAnnotations;

namespace Smusic.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Descrption { get; set; }
    }
}
