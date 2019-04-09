using Inventory.Data;
using Inventory.Domain.Entities;
using Inventory.Repository;
using Inventory.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.UnitOfWork
{
    class UnitOfWork : IUnitOfWork
    {
        private IRepository<Platform> _repository;
        private DatabaseContext _databaseContext;

        public UnitOfWork(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public IRepository<Platform> Repository
        {
            get
            {
                if (_repository == null)
                {
                    _repository = new Repository<Platform>(_databaseContext);
                }
                return _repository;
            }
        }
        public void Save()
        {
            _databaseContext.SaveChanges();
        }
    }
}
