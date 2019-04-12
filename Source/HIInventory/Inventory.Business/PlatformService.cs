using Inventory.Business.Contracts;
using Inventory.Domain.Entities;
using Inventory.Dto;
using Inventory.UnitOfWork;
using System.Collections.Generic;


namespace Inventory.Business
{
    public class PlatformService : IPlatformService
    {
        private readonly IUnitOfWork _unitOfWork;
        public PlatformService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public void Add(PlatformDto platformDto)
        {
            var platform = MapDtoToDomain(platformDto);
            _unitOfWork.PlatformRepository.Add(platform);
            _unitOfWork.Save();
        }

       
        public List<PlatformDto> GetAll()
        {
            var platforms = _unitOfWork.PlatformRepository.GetAll();
            var platformDtos = new List<PlatformDto>();

            foreach (var platform in platforms)
            {
                platformDtos.Add(MapDomainToDto(platform));
            }

            return platformDtos;
        }

       
        public PlatformDto GetById(int id)
        {
            var platform = _unitOfWork.PlatformRepository.GetById(id);
            return MapDomainToDto(platform);
        }

        public void Update(PlatformDto platformDto)
        {
            var platform = MapDtoToDomain(platformDto);
            _unitOfWork.PlatformRepository.Update(platform);
            _unitOfWork.Save();
        }

        public void Delete(int id)
        {
            _unitOfWork.PlatformRepository.Delete(id);
            _unitOfWork.Save();
        }

        private Platform MapDtoToDomain(PlatformDto platformDto)
        {
            var PlatformDomain = new Platform
            {
                Id = platformDto.Id,
                PlatformName = platformDto.PlatformName,
                ICType = platformDto.ICType,
            };

            return PlatformDomain;
        }

        private PlatformDto MapDomainToDto(Platform platform)
        {
            var PlatformDto = new PlatformDto
            {
                Id = platform.Id,
                PlatformName = platform.PlatformName,
                ICType = platform.ICType,
            };

            return PlatformDto;
        }
    }
}
