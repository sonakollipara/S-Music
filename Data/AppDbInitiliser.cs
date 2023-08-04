using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Smusic.Models;
using System.Collections.Generic;
using System.Linq;

namespace Smusic.Data
{
    public class AppDbInitiliser
    {
        public static void seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var _dbContext = serviceScope.ServiceProvider.GetService<AppDbContext>();
                _dbContext.Database.EnsureCreated();

                //for songs
                if(!_dbContext.Songs.Any())
                {
                   _dbContext.Songs.AddRange(new List<Song>()
                    {
                        new Song() 
                        { 
                            Language = "English", 
                            Title = "let me down", 
                            SongURL ="https://github.com/sonakollipara/S-Music/blob/main/shewasonlynineteen.mp3"
                        },
                        new Song() 
                        { 
                            Language = "English", 
                            Title = "let me tell slowly", 
                            SongURL = "https://github.com/sonakollipara/S-Music/blob/main/letmetellslowly.mp3" 
                        },
                        new Song() 
                        { 
                            Language = "English", 
                            Title = "shadow of mine", 
                            SongURL = "https://github.com/sonakollipara/S-Music/blob/main/shadow.mp3"
                        },
                        new Song() 
                        { 
                            Language = "Russian", 
                            Title = "dikaya d'vitsa",
                            SongURL = "https://github.com/sonakollipara/S-Music/blob/main/alexandrus.mp3" 
                        },
                        new Song() 
                        { 
                            Language = "English", 
                            Title = "i want it that way", 
                            SongURL = "https://github.com/sonakollipara/S-Music/blob/main/iwantitthatway.mp3"
                        },
                        new Song() 
                        { 
                            Language = "English", 
                            Title = "show me the meaning", 
                            SongURL = "https://github.com/sonakollipara/S-Music/blob/main/showmethemeaning.mp3"
                        },
                        new Song() 
                        { 
                            Language = "English", 
                            Title = "as long as you", 
                            SongURL = "https://github.com/sonakollipara/S-Music/blob/main/shewasonlynineteen.mp3"
                        }                       
                        
                    });
                    _dbContext.SaveChanges();

                }
                //for albums
                if (!_dbContext.Albums.Any())
                {
                      _dbContext.Albums.AddRange(new List<Album>()
                    {
                        new Album() 
                        { 
                            Logo = "https://github.com/sonakollipara/S-Music/blob/main/letmedownslowly.jpeg", 
                            Name = "LET ME DOWN", 
                            Descrption = "let me down by ab", 
                            AlbumCategory = Albumcategory.pop, 
                            ActorName = "alec", 
                            SongName="let me down", 
                            SongId = 1
                        },
                        new Album() 
                        { 
                            Logo = "https://github.com/sonakollipara/S-Music/blob/main/letmetellyou.jpeg", 
                            Name = "LET ME TELL YOU SLOWLY", 
                            Descrption = "let me tell you by ab", 
                            AlbumCategory = Albumcategory.pop, 
                            ActorName="alec", 
                            SongName = "let me tell",
                            SongId = 2 
                        },
                        new Album() 
                        { 
                            Logo = "https://github.com/sonakollipara/S-Music/blob/main/shadowofmine.jpeg", 
                            Name = "SHADOW OF MINE", 
                            Descrption = "shadow of mine by ab", 
                            AlbumCategory = Albumcategory.pop, 
                            ActorName = "banjamin", 
                            SongName="shadow", 
                            SongId = 3
                        },
                        new Album() 
                        { 
                            Logo = "https://github.com/sonakollipara/S-Music/blob/main/dikayadvitsa.jpeg", 
                            Name = "DIKAYA D'VITSA", 
                            Descrption = "dikaya d'vitsa by ar", 
                            AlbumCategory = Albumcategory.pop, 
                            ActorName = "alexandrus", 
                            SongName ="dikaya", 
                            SongId = 7
                        },
                        new Album() 
                        { 
                            Logo = "https://github.com/sonakollipara/S-Music/blob/main/iwantitthatway.jpeg", 
                            Name = "I WANT IT THAT WAY", 
                            Descrption = "i want it that way by bsb",
                            AlbumCategory = Albumcategory.pop, 
                            ActorName = "bsb", 
                            SongName="i want",
                            SongId = 6 
                        },
                        new Album() 
                        { 
                            Logo = "https://github.com/sonakollipara/S-Music/blob/main/showmethemeaning.jpeg", 
                            Name = "SHOW ME THE MEANING", 
                            Descrption = "show me the meaning by bsb", 
                            AlbumCategory = Albumcategory.pop, 
                            ActorName = "bsb", 
                            SongName ="show me",
                            SongId = 4 
                        },
                        new Album() 
                        { 
                            Logo= "https://github.com/sonakollipara/S-Music/blob/main/aslongasyou.jpeg", 
                            Name="AS LONG AS YOU LOVE ME",
                            Descrption="as long as you love by bsb", 
                            AlbumCategory = Albumcategory.pop, 
                            ActorName = "bsb", 
                            SongName = "as long", 
                            SongId = 5
                        }
                    });
                    _dbContext.SaveChanges();
                }
                //for actors in albums
                if (!_dbContext.Actors.Any())
                {
                    _dbContext.Actors.AddRange(new List<Actor>()
                    {
                        new Actor() 
                        { 
                            ProfilePictureURL = "https://github.com/sonakollipara/S-Music/blob/main/alecbenjaminphoto.jpeg", 
                            FullName = "Alec Benjamin", 
                            Bio = "He is an American Pop singer" 
                        },
                        new Actor() 
                        { 
                            ProfilePictureURL = "https://github.com/sonakollipara/S-Music/blob/main/alexandrus.jpg", 
                            FullName="Alex and Rus",
                            Bio="He is a Pop singer from Russia" 
                        },
                        new Actor() 
                        { 
                            ProfilePictureURL = "https://github.com/sonakollipara/S-Music/blob/main/backstrretboysphoto.jpeg", 
                            FullName = "Back Street Boys", 
                            Bio = "It is a troop of Pop singers from America" 
                        }
                    });
                    _dbContext.SaveChanges();
                }
                //for albums and actors
                if(!_dbContext.Album_Actor.Any()) 
                {
                    _dbContext.Album_Actor.AddRange(new List<Album_Actor>()
                    { 
                        new Album_Actor() 
                        {
                            ActorId = 3, 
                            AlbumId = 1
                        },
                        new Album_Actor() 
                        {
                            ActorId = 3, 
                            AlbumId = 2
                        },
                        new Album_Actor() 
                        {
                            ActorId = 3, 
                            AlbumId = 3
                        },
                        new Album_Actor() 
                        {
                            ActorId = 2, 
                            AlbumId = 4
                        },
                        new Album_Actor() 
                        {
                            ActorId = 1, 
                            AlbumId = 5
                        },
                        new Album_Actor() 
                        {
                            ActorId = 1, 
                            AlbumId = 6
                        },
                        new Album_Actor() 
                        {
                            ActorId = 1, 
                            AlbumId = 7
                        }
                    });
                    _dbContext.SaveChanges();
                }
            
            }
        }
    }
}
