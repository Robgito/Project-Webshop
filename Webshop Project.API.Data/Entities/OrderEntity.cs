namespace Webshop_Project.API.Data.Entities
{
    public class OrderEntity : IEntity
    {
        public int ID { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsActive { get; set; }
        public double TotalPrice { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public int UserID { get; set; } = 1;
        public List<OrderProductEntity> ListProducts { get; set; }
    }
}