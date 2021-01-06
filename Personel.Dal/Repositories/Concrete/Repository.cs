
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.Dal.Repositories.Concrete
{
    using Personel.Dal.Repositories.Abstract;
    using System.Data.Entity;

    public class Repository<TEnt> : IRepository<TEnt> where TEnt : class
    {
        protected DbContext _context;
        private DbSet<TEnt> _dbSet;


        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEnt>();
        }


        public void Add(TEnt entity)
        {
            _dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEnt> entities)
        {
            _dbSet.AddRange(entities);
        }

        public IEnumerable<TEnt> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEnt GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Remove(int id)
        {
            _dbSet.Remove(GetById(id));
        }

        public void RemoveRange(IEnumerable<TEnt> entities)
        {
            _dbSet.RemoveRange(entities);
        }
    }
}
