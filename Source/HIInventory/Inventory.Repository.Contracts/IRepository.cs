using System.Collections.Generic;

namespace Inventory.Repository.Contracts
{
    public interface IRepository<T>
        where T : class
    {
        #region Actions

        /// <summary>
        /// Add a new entity to Database
        /// </summary>
        /// <param name="entity">instance of type <see cref="T"/></param>

        void Add(T entity);

        /// <summary>
        /// Update a entity in Database
        /// </summary>
        /// <param name="entity">instance of type <see cref="T"/></param>

        void Update(T entity);

        /// <summary>
        /// Delete a entity from Database
        /// </summary>
        /// <param name="id">instance of type <see cref="T"/></param>

        void Delete(int id);

        /// <summary>
        /// Get all entity from Database
        /// </summary>
        /// <returns></returns>

        IList<T> GetAll();

        /// <summary>
        /// Get entity by ID from Database
        /// </summary>
        /// <param name="id">instance of type <see cref="T"/></param>
        /// <returns></returns>

        T GetById(int id);

        #endregion
    }
}
