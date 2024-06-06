using System.ComponentModel.DataAnnotations;

namespace Webshop_Project.DTO
{
    public class AddUserDTO
    {
        [Required(ErrorMessage = "This field is required.")]
        [MinLength(1)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string[] Role { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MinLength(1)]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MinLength(1)]
        [MaxLength(100)]
        public string Password { get; set; }
    }
}