using System.Collections.Generic;
using Inventory.Dto;

namespace Inventory.Business.Contracts
{
    public interface IPlatformService
    {
        #region Actions

        /// <summary>
        /// Add a new PlatformDto
        /// </summary>
        /// <param name="platformDto">instance of type <see cref="PlatformDto"/></param>
        void Add(PlatformDto platformDto);

        /// <summary>
        /// Get all PlatformDto
        /// </summary>
        /// <returns></returns>
        List<PlatformDto> GetAll();

        /// <summary>
        /// Get PlatformDto by ID
        /// </summary>
        /// <param name="id">instance of type <see cref="int"/></param>
        /// <returns></returns>
        PlatformDto GetById(int id);

        /// <summary>
        /// Update PlatformDto
        /// </summary>
        /// <param name="platformDto">instance of type <see cref="PlatformDto"/></param>

        void Update(PlatformDto platformDto);

        /// <summary>
        /// Delete PlatformDto
        /// </summary>
        /// <param name="id">instance of type <see cref="int"/></param>

        void Delete(int id);

        #endregion

    }
}
