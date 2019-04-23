using Inventory.Domain.Entities;
using Inventory.Repository.Contracts;

namespace Inventory.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<Platform> PlatformRepository { get; }
        void Save();
    }
}
