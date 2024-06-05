using System.ComponentModel.DataAnnotations;

namespace Webshop_Project.DTO
{
    public class AddBasketProductDTO
    {
        public int ProductID { get; set; }
        public int BasketID { get; set; }
        public int Amount { get; set; }
    }
}