using System.ComponentModel.DataAnnotations;

namespace Webshop_Project.API.Data.Entities
{
    public class UserEntity : IEntity
    {
        [Key]
        public int ID { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public string[] Role { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Email { get; set; }

        [MinLength(1)]
        [MaxLength(9999)]
        public string Password { get; set; }

        public bool IsActive { get; set; }
        public int BasketID { get; set; }

        public BasketEntity Basket { get; set; }
    }
}