using System.ComponentModel.DataAnnotations;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.DTO
{
    public class AddOrderDTO
    {
        [Required(ErrorMessage = "This field is required.")]
        public int BasketID { get; set; }
    }
}