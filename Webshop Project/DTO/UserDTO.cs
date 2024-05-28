using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.DTO
{
    public class UserDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string[] Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public BasketDTO Basket { get; set; }
    }
}
