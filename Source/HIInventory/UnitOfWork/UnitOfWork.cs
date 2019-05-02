using Inventory.Data;
using Inventory.Domain.Entities;
using Inventory.Repository;
using Inventory.Repository.Contracts;

namespace Inventory.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Fields

        private IRepository<Platform> _platformRepository;

        private DatabaseContext _databaseContext;

        #endregion

        #region Constructors

        public UnitOfWork(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        #endregion

        #region Actions
        /// <summary>
        /// Constructor for Platform Repository
        /// </summary>
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

        #endregion
    }
}
