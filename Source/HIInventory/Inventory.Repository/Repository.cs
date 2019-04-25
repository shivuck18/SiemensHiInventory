using System.Collections.Generic;
using System.Linq;
using Inventory.Data;
using Inventory.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Repository
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        #region Fields

        private readonly DatabaseContext _databaseContext;

        #endregion

        #region Constructors

        public Repository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        #endregion

        #region Actions

        public void Add(T entity)
        {
            _databaseContext.Set<T>().Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _databaseContext.Set<T>().Find(id);
            _databaseContext.Set<T>().Remove(entity);
        }

        public IList<T> GetAll()
        {
            return _databaseContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _databaseContext.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _databaseContext.Entry(entity).State = EntityState.Modified;
        }

        #endregion
    }
}
