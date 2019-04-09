using Inventory.Domain.Entities;
using Inventory.Repository;
using Inventory.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<Platform> Repository { get; }
        void Save();
    }
}
