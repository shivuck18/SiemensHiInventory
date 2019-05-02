using System.ComponentModel.DataAnnotations;

namespace Inventory.Domain.Entities
{
    public class Platform
    {
        #region Properties
        /// <summary>
        /// Gets the instance of Id
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Gets the instance of PlatformName
        /// </summary>
        public string PlatformName { get; set; }
        /// <summary>
        /// Gets the instance of ICType
        /// </summary>
        public string ICType { get; set; }

        #endregion

    }
}
