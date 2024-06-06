using System.ComponentModel.DataAnnotations;

namespace Webshop_Project.DTO
{
    public class AddBasketProductDTO
    {
        [Required(ErrorMessage = "This field is required.")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int BasketID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Range(0, 9999, ErrorMessage = "The amount can't go below 0!")]
        public int Amount { get; set; }
    }
}