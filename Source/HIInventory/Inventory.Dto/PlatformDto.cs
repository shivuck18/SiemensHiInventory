using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventory.Dto
{
    public class PlatformDto
    {
        [Key]
        public int Id { get; set; }
        public string PlatformName { get; set; }
        public string ICType { get; set; }
    }
}
