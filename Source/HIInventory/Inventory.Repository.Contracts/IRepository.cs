using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Repository.Contracts
{
    public interface IRepository<T>
        where T : class
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        IList<T> GetAll();

        T GetById(int id);
    }
}
