using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Business.Models
{
    public class Basket
    {
        public int ID { get; set; }
        public double ShippingPrice { get; set; }
        public List<BasketProductEntity> ListProducts { get; set; }
        public double TotalPrice { get; set; }
        public DateTime ExpectedShippingDate { get; set; }
        public double PriceWithShipping { get; set; }
    }
}