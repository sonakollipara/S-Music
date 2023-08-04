using System.Collections.Generic;

namespace Smusic.Models
{
    public class Album_Actor
    {
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }

       
    }
}
