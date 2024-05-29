using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Business.Models
{
    public class Order
    {
        public int ID { get; set; }
        public double TotalPrice { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public int UserID { get; set; } = 1;
        public List<OrderProductEntity> ListProducts { get; set; }
    }
}
