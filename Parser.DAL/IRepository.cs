using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.DAL
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Delete(int id);

        TEntity GetItem(int id);

        IEnumerable<TEntity> GetList();

        void Create(TEntity entity);

        void Update(TEntity entity);
    }
}
