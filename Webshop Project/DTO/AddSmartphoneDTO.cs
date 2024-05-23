namespace Webshop_Project.DTO
{
    public class AddSmartphoneDTO
    {
        public string Name { get; set; }

        public string? Description { get; set; }

        public double Price { get; set; }

        public string Image { get; set; }

        public int Stock { get; set; }

        public int MemoryCapacity { get; set; }

        public string Colour { get; set; }

        public double ScreenSize { get; set; }

        public int BrandID { get; set; }

        public int CategoryID { get; set; }
    }
}
