using Microsoft.EntityFrameworkCore;
using Smusic.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smusic.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _dbContext;
        public ActorsService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Actor actor)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await _dbContext.Actors.ToListAsync();
            return result;
            //throw new System.NotImplementedException();
        }

        public Actor GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new System.NotImplementedException();
        }
    }
}
