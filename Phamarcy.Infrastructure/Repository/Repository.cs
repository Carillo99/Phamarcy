using Phamarcy.Domain.Entities;
using Phamarcy.Domain.Repository;
using Phamarcy.Infrastructure.DataContext;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Phamarcy.Infrastructure.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : EntitiesBase
    {
        private readonly ApplicationDbContext _context;
        
        protected Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public TEntity Add(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();

            return obj;
        }

        public void Delete(int id)
        {
            var entity = GetById(id);

            if (entity != null)
            {
                _context.Set<TEntity>().Remove(entity);
                _context.SaveChanges();
            }

        }

        public void Delete(List<TEntity> obj)
        {
            _context.Set<TEntity>().RemoveRange(obj);
            _context.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public TEntity GetById(int id, string includes)
        {

            var contexto = _context.Set<TEntity>().AsQueryable();

            if (!string.IsNullOrEmpty(includes))
            {
                var includesArray = includes.Split(',');

                foreach (var include in includesArray)
                {
                    contexto = contexto.Include(include);
                }
            }
            
            return contexto.FirstOrDefault(x => x.Id == id);
        }
        
        public IQueryable<TEntity> List()
        {
            return _context.Set<TEntity>()
                .AsQueryable()
                .AsNoTracking();
        }

        public TEntity Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Detached;
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
            return obj;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

    }
}