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

        void Delete(int id);

        IList<T> GetAll();

        T GetById(int id);
    }
}
