using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop_Project.API.Data.Entities
{
    public class OrderProductEntity : IEntity
    {
        public int ID { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsActive { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }

        //TODO: Verwijzen naar de basket
    }
}
