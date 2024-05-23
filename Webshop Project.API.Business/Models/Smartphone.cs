using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Business.Models
{
    public class Smartphone
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

        public BrandEntity Brand { get; set; }

        public CategoryEntity Category { get; set; }
    }
}
