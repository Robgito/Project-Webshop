using System.ComponentModel.DataAnnotations;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.DTO
{
    public class UpdateOrderDTO
    {
        [Required(ErrorMessage = "This field is required.")]
        public double TotalPrice { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int UserID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public List<OrderProductEntity> ListProducts { get; set; }
    }
}