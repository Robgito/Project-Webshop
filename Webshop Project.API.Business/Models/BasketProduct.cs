namespace Webshop_Project.API.Business.Models
{
    public class BasketProduct
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public Smartphone Product { get; set; }
        public int BasketID { get; set; }
        public int Amount { get; set; }
    }
}