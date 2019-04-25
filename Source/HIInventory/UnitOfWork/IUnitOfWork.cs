using Inventory.Domain.Entities;
using Inventory.Repository.Contracts;

namespace Inventory.UnitOfWork
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Gets the instance of the Platform Repository
        /// </summary>
        IRepository<Platform> PlatformRepository { get; }

        /// <summary>
        /// Save Data in Database
        /// </summary>
        void Save();
    }
}
