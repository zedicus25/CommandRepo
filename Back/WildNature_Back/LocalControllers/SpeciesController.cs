using Microsoft.EntityFrameworkCore;
using WildNature_Back.Configuration;
using WildNature_Back.Context;
using WildNature_Back.Models;

namespace WildNature_Back.LocalControllers
{
    public class SpeciesController : ISpeciesController
    {
        private readonly DbA9a6f8Fowon21908Context _dbContext;

        public SpeciesController(DbA9a6f8Fowon21908Context dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Species>> Add(Species t)
        {
            var item = _dbContext.Species.FirstOrDefault(x => x.Name.ToLower().Equals(t.Name.ToLower()));
            if (item == null)
            {
                _dbContext.Species.Add(t);
                _dbContext.SaveChanges();
            }
            return _dbContext.Species.ToListAsync();
        }

        public Task<List<Species>> Edit(int id, string newName)
        {
            var item = _dbContext.Species.FirstOrDefault(x => x.Id.Equals(x.Id));
            if (item != null)
            {
                item.Name = newName;
                _dbContext.SaveChanges();
            }
            return _dbContext.Species.ToListAsync();
        }

        public Task<List<Species>> Remove(int id)
        {
            var item = _dbContext.Species.FirstOrDefault(x => x.Id.Equals(id));
            if (item != null)
            {
                _dbContext.Species.Remove(item);
                _dbContext.SaveChanges();
            }
            return _dbContext.Species.ToListAsync();
        }

        public Task<List<Species>> Select()
        {
            return _dbContext.Species.ToListAsync();
        }
    }
}
