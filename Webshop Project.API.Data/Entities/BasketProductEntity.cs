namespace Webshop_Project.API.Data.Entities
{
    public class BasketProductEntity : IEntity
    {
        public int ID { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsActive { get; set; }
        public int ProductID { get; set; }
        public int BasketID { get; set; }
    }
}
