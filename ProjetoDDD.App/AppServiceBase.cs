using ProjectDDD.App.Interface;
using ProjectDDD.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.App
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase ;

        public AppServiceBase(IServiceBase<TEntity> servicebase)
        {
            this._serviceBase = servicebase;
        }

        public void Add(TEntity entity)
        {
            _serviceBase.Add(entity);
        }

        public void Dispose()
        {

        }

        public TEntity GetById(int id)
        {
            return this._serviceBase.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this._serviceBase.GetAll();
        }

        public void Remove(TEntity entity)
        {
             this._serviceBase.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            this._serviceBase.Update(entity);
        }
    }
}
