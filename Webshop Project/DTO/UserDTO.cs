using System.ComponentModel.DataAnnotations;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.DTO
{
    public class UserDTO
    {
        [Required(ErrorMessage = "This field is required.")]
        public int ID { get; set; }

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

        [Required(ErrorMessage = "This field is required.")]
        public BasketDTO Basket { get; set; }
    }
}
