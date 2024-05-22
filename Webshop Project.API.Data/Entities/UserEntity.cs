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
        public string Name { get; set; }
        [Required]
        public string[] Role { get; set; }
        [Required]
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int BasketID { get; set; }
        public BasketEntity Basket { get; set; }
    }
}