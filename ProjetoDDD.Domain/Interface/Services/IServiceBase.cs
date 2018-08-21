using System.Collections.Generic;

namespace ProjectDDD.Domain.Interface.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
        void Dispose();

    }
}
