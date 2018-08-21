using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.App.Interface
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
        void Dispose();
    }
}
