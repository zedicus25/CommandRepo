using Microsoft.EntityFrameworkCore;
using WildNature_Back.Configuration;
using WildNature_Back.Context;
using WildNature_Back.Models;

namespace WildNature_Back.LocalControllers
{
    public class KingdomController : IKingdomController
    {
        private readonly DbA9a6f8Fowon21908Context _dbContext;

        public KingdomController(DbA9a6f8Fowon21908Context dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Kingdom>> Add(Kingdom t)
        {
            var item = _dbContext.Kingdoms.FirstOrDefault(x => x.Name.ToLower().Equals(t.Name.ToLower()));
            if (item == null)
            {
                _dbContext.Kingdoms.Add(t);
                _dbContext.SaveChanges();
            }
            return _dbContext.Kingdoms.ToListAsync();
        }

        public Task<List<Kingdom>> Edit(int id, string newName)
        {
            var item = _dbContext.Kingdoms.FirstOrDefault(x => x.Id.Equals(x.Id));
            if (item != null)
            {
                item.Name = newName;
                _dbContext.SaveChanges();
            }
            return _dbContext.Kingdoms.ToListAsync();
        }

        public Task<List<Kingdom>> Remove(int id)
        {
            var item = _dbContext.Kingdoms.FirstOrDefault(x => x.Id.Equals(id));
            if (item != null)
            {
                _dbContext.Kingdoms.Remove(item);
                _dbContext.SaveChanges();
            }
            return _dbContext.Kingdoms.ToListAsync();
        }

        public Task<List<Kingdom>> Select()
        {
            return _dbContext.Kingdoms.ToListAsync();
        }
    }
}
