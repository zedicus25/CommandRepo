using System.Data.Entity;
using WildNature_Back.Configuration;
using WildNature_Back.Context;
using WildNature_Back.Models;

namespace WildNature_Back.LocalControllers
{
    public class FamilyController : IFamilyController
    {
        private readonly db_a9a6f8_fowon21908Context _dbContext;

        public FamilyController(db_a9a6f8_fowon21908Context dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Family>> Add(Family t)
        {
            var item = _dbContext.Families.FirstOrDefault(x => x.Name.Equals(t.Name, StringComparison.OrdinalIgnoreCase));
            if(item == null)
            {
                _dbContext.Families.Add(t);
                _dbContext.SaveChanges();
            }
            return _dbContext.Families.ToListAsync();
        }

        public Task<List<Family>> Edit(int id, string newName)
        {
            var item = _dbContext.Families.FirstOrDefault(x => x.Id.Equals(x.Id));
            if(item != null)
            {
                item.Name = newName;
                _dbContext.SaveChanges();
            }
            return _dbContext.Families.ToListAsync();
        }

        public Task<List<Family>> Remove(int id)
        {
            var item = _dbContext.Families.FirstOrDefault(x => x.Id.Equals(id));
            if(item != null)
            {
                _dbContext.Families.Remove(item);
                _dbContext.SaveChanges();
            }
            return _dbContext.Families.ToListAsync();
        }

        public Task<List<Family>> Select()
        {
            return _dbContext.Families.ToListAsync();
        }
    }
}
