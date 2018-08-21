using ProjectDDD.Domain.Interface;
using ProjectDDD.Domain.Interface.Services;
using System;
using System.Collections.Generic;

namespace ProjectDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this._repository = repository;
        }

        public void Add(TEntity entity)
        {
            this._repository.Add(entity);
        }

        public void Dispose()
        {
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this._repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return this._repository.GetById(id);
        }

        public void Remove(TEntity entity)
        {
            this.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            this._repository.Update(entity);
        }
    }
}
