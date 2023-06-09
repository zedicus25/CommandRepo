﻿using Microsoft.EntityFrameworkCore;
using WildNature_Back.Configuration;
using WildNature_Back.Context;
using WildNature_Back.Models;

namespace WildNature_Back.LocalControllers
{
    public class GenController : IGenController
    {
        private readonly DbA9a6f8Fowon21908Context _dbContext;
        public GenController(DbA9a6f8Fowon21908Context dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Gen>> Add(Gen t)
        {
            var item = _dbContext.Gens.FirstOrDefault(x => x.Name.ToLower().Equals(t.Name.ToLower()));
            if (item == null)
            {
                _dbContext.Gens.Add(t);
                _dbContext.SaveChanges();
            }
            return _dbContext.Gens.ToListAsync();
        }

        public Task<List<Gen>> Edit(int id, string newName)
        {
            var item = _dbContext.Gens.FirstOrDefault(x => x.Id.Equals(x.Id));
            if (item != null)
            {
                item.Name = newName;
                _dbContext.SaveChanges();
            }
            return _dbContext.Gens.ToListAsync();
        }

        public Task<List<Gen>> Remove(int id)
        {
            var item = _dbContext.Gens.FirstOrDefault(x => x.Id.Equals(id));
            if (item != null)
            {
                _dbContext.Gens.Remove(item);
                _dbContext.SaveChanges();
            }
            return _dbContext.Gens.ToListAsync();
        }

        public Task<List<Gen>> Select()
        {
            return _dbContext.Gens.ToListAsync();
        }
    }
}
