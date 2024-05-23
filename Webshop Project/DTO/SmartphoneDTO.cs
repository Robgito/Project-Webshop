using System.ComponentModel.DataAnnotations;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.DTO
{
    public class SmartphoneDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }

        public double Price { get; set; }

        public string Image { get; set; }

        public int Stock { get; set; }

        public int MemoryCapacity { get; set; }

        public string Colour { get; set; }

        public double ScreenSize { get; set; }

        public string Brand { get; set; }

        public string Category { get; set; }
    }
}
