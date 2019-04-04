using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventory.Domain
{
    class Platform
    {
        [Key]
        public int Id { get; set; }
        public string PlatformName { get; set; }
        public string PlatformType { get; set; }

        public Platform platform { get; set; }
    }
}
