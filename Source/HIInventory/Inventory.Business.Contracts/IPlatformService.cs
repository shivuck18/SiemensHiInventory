
using Inventory.Dto;
using System.Collections.Generic;

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
