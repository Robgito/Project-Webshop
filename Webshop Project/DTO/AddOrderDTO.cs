using System.ComponentModel.DataAnnotations;

namespace Webshop_Project.DTO
{
    public class AddOrderDTO
    {
        [Required(ErrorMessage = "This field is required.")]
        public int BasketID { get; set; }
    }
}