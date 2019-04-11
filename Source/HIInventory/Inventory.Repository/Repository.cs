using Inventory.Data;
using Inventory.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Repository
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        private readonly DatabaseContext _databaseContext;

        public Repository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public void Add(T entity)
        {
            _databaseContext.Set<T>().Add(entity);
            //_databaseContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _databaseContext.Set<T>().Find(id);
            _databaseContext.Set<T>().Remove(entity);
            //_databaseContext.SaveChanges();
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
            //_databaseContext.SaveChanges();
        }
    }
}
