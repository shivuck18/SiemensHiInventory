using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Dto
{
    public class PlatformDto
    {
        #region Properties

        [BindProperty, Required]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Platform Name cannot be blank.") ,MaxLength(6, ErrorMessage ="Platform Name cannot be more than 6 characters"), RegularExpression(@"^[a-zA-Z0-9+""'\s-]*$", ErrorMessage ="Platform name cannot have special characters other than '+'")]
        public string PlatformName { get; set; }

        [Required(ErrorMessage = "ICType cannot be blank"), MaxLength(2, ErrorMessage = "ICType cannot be more than 2 digts"), RegularExpression("^[0-9]*$", ErrorMessage = "IC Type should be numeric")]
        public string ICType { get; set; }

        #endregion
    }
}
