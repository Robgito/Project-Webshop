using System.ComponentModel.DataAnnotations;

namespace Webshop_Project.DTO
{
    public class UpdateCategoryDTO
    {
        [Required(ErrorMessage = "This field is required.")]
        [MinLength(1)]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}