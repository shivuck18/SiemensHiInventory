﻿using Inventory.Data;
using Inventory.Domain.Entities;
using Inventory.Repository;
using Inventory.Repository.Contracts;

namespace UnitOfWork
{
    class UnitOfWork : IUnitOfWork
    {
        private IRepository<Platform> _platformRepository;
        private DatabaseContext _databaseContext;

        public UnitOfWork(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IRepository<Platform> PlatformRepository
        {
            get
            {
                if (_platformRepository == null)
                {
                    _platformRepository = new Repository<Platform>(_databaseContext);
                }

                return _platformRepository;
            }
        }

        public void Save()
        {
            _databaseContext.SaveChanges();
        }
    }
}
