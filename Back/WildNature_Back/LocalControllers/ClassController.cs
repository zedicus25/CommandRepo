using Microsoft.EntityFrameworkCore;
using WildNature_Back.Configuration;
using WildNature_Back.Context;
using WildNature_Back.Models;

namespace WildNature_Back.LocalControllers
{
    public class ClassController : IClassController
    {
        private readonly DbA9a6f8Fowon21908Context _dbContext;

        public ClassController(DbA9a6f8Fowon21908Context dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Class>> Add(Class t)
        {
            var item = _dbContext.Classes.FirstOrDefault(x => x.Name.ToLower().Equals(t.Name.ToLower()));
            if(item == null)
            {
                _dbContext.Classes.Add(t);
                _dbContext.SaveChanges();
            }
            return _dbContext.Classes.ToListAsync();
        }

        public Task<List<Class>> Edit(int id, string newName)
        {
            var item = _dbContext.Classes.FirstOrDefault(x => x.Id.Equals(id));
            if (item != null)
            {
                item.Name = newName;
                _dbContext.SaveChanges();
            }
            return _dbContext.Classes.ToListAsync();
        }

        public Task<List<Class>> Remove(int id)
        {
            var item = _dbContext.Classes.FirstOrDefault(x => x.Id.Equals(id));
            if(item != null)
            {
                _dbContext.Classes.Remove(item);
                _dbContext.SaveChanges();
            }
            return _dbContext.Classes.ToListAsync();
        }

        public Task<List<Class>> Select()
        {
            return _dbContext.Classes.ToListAsync();
        }
    }
}
