using System.Collections.Generic;
using Inventory.Dto;

namespace Inventory.Business.Contracts
{
    public interface IPlatformService
    {
        void Add(PlatformDto platform);

        List<PlatformDto> GetAll();

        PlatformDto GetById(int id);

        void Update(PlatformDto platform);

        void Delete(int id);
 
    }
}
