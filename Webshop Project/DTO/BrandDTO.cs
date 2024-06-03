using System.ComponentModel.DataAnnotations;

namespace Webshop_Project.DTO
{
    public class BrandDTO
    {
        [Required(ErrorMessage = "This field is required.")]
        public int ID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MinLength(1)]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
