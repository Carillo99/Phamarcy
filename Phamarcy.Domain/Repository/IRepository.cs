using Phamarcy.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Phamarcy.Domain.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : EntitiesBase
    {
        TEntity Add(TEntity obj);
        TEntity GetById(int id);
        TEntity GetById(int id, string includes);
        TEntity Update(TEntity obj);
        void Delete(int id);
        void Delete(List<TEntity> obj);
    }
}
