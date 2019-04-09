using Inventory.Domain.Entities;
using Inventory.Repository;
using Inventory.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<Platform> PlatformRepository { get; }
        void Save();
    }
}
