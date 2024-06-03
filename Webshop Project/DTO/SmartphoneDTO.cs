using System.ComponentModel.DataAnnotations;

namespace Webshop_Project.DTO
{
    public class SmartphoneDTO
    {
        [Required(ErrorMessage = "This field is required.")]
        public int ID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MinLength(1)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MinLength(1)]
        [MaxLength(500)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Range(1, 9999, ErrorMessage = "The price can't go below 0!")]
        public double Price { get; set; }

        public string Image { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Range(0, 9999, ErrorMessage = "The stock can't go below 0!")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Range(64, 9999, ErrorMessage = "Memory capacity can't go below 64GB!")]
        public int MemoryCapacity { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MinLength(1)]
        [MaxLength(100)]
        public string Colour { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Range(1, 9999, ErrorMessage = "Screensize can't go below 1 inch!")]
        public double ScreenSize { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Range(1, 5, ErrorMessage = "This brand doesnt exist!")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Range(1, 4, ErrorMessage = "This Category doesn't exist!")]
        public string Category { get; set; }
    }
}