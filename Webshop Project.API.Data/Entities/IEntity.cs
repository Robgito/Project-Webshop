namespace Webshop_Project.API.Data.Entities
{
    public interface IEntity
    {
        int ID { get; set; }
        DateTime Created { get; set; }
        DateTime Updated { get; set; }
        bool IsActive { get; set; }
    }
}