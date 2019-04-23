using System.ComponentModel.DataAnnotations;

namespace Inventory.Domain.Entities
{
    public class Platform
    {
        [Key]
        public int Id { get; set; }
        public string PlatformName { get; set; }
        public string ICType { get; set; }

       // public Platform platform { get; set; }
    }
}
