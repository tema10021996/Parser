using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Parser.DAL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        ParserContext context;
        DbSet<TEntity> dbSet;
        private bool isDisposed = false;

        public Repository(ParserContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public Repository()
        {
            this.context = new ParserContext();
            dbSet = context.Set<TEntity>();
        }

        public TEntity GetItem(int id)
        {
            return dbSet.Find(id);
        }
        public IEnumerable<TEntity> GetList()
        {

            return dbSet.ToList();
        }

        public void Create(TEntity item)
        {
            dbSet.Add(item);
            context.SaveChanges();
        }

        public void Update(TEntity item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            TEntity item = dbSet.Find(id);

            dbSet.Remove(item);
            context.SaveChanges();
        }

        public void Save()
        {

            context.SaveChanges();
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Dispose(true);
        }

        ~Repository()
        {
            Dispose(false);
        }

        private void Dispose(bool disposeManaged)
        {
            if (this.isDisposed)
            {
                return;
            }

            if (disposeManaged && this.context != null)
            {
                this.context.Dispose();
            }

            this.isDisposed = true;
        }

        #endregion
    }
}
