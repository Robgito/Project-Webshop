using System.ComponentModel.DataAnnotations;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.DTO
{
    public class OrderDTO
    {
        [Required(ErrorMessage = "This field is required.")]
        public int ID { get; set; }

        public DateTime Created { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public double TotalPrice { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MinLength(1)]
        [MaxLength(100)]
        public string City { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MinLength(1)]
        [MaxLength(100)]
        public string Street { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int StreetNumber { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int UserID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public List<OrderProductEntity> ListProducts { get; set; }
    }
}